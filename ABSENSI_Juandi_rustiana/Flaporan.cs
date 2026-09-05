using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Flaporan : Form
    {
        private DataTable dtLaporan = new DataTable();

        private int nomorHalaman = 1;

        public Flaporan()
        {
            InitializeComponent();

            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Flaporan_Load(object sender, EventArgs e)
        {
            dtdari.Value = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            tampilKelas();
        }

        // =========================================
        // TAMPIL DATA KELAS
        // =========================================
        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT
                            id_kelas,
                            nama_kelas
                          FROM kelas
                          WHERE status = 'Aktif'
                          ORDER BY nama_kelas ASC");

                cmbkelas.DataSource = db.ds.Tables[0];
                cmbkelas.DisplayMember = "nama_kelas";
                cmbkelas.ValueMember = "id_kelas";

                cmbkelas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data kelas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================
        // AMBIL DATA LAPORAN
        // =========================================
        private bool ambilDataLaporan()
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "Silakan pilih kelas terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (dtdari.Value.Date > dtsampai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal Dari tidak boleh lebih besar dari tanggal Sampai!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"
                    SELECT
                        s.nis AS NIS,
                        s.nama_siswa AS Nama,
                        k.nama_kelas AS Kelas,

                        SUM(
                            CASE
                                WHEN a.status = 'Hadir'
                                THEN 1 ELSE 0
                            END
                        ) AS Hadir,

                        SUM(
                            CASE
                                WHEN a.status = 'Izin'
                                THEN 1 ELSE 0
                            END
                        ) AS Izin,

                        SUM(
                            CASE
                                WHEN a.status = 'Sakit'
                                THEN 1 ELSE 0
                            END
                        ) AS Sakit,

                        SUM(
                            CASE
                                WHEN a.status = 'Alpa'
                                THEN 1 ELSE 0
                            END
                        ) AS Alpa

                    FROM absensi a

                    INNER JOIN siswa s
                        ON a.id_siswa = s.id_siswa

                    INNER JOIN kelas k
                        ON s.id_kelas = k.id_kelas

                    WHERE a.tanggal BETWEEN @dari AND @sampai
                    AND s.id_kelas = @id_kelas

                    GROUP BY
                        s.id_siswa,
                        s.nis,
                        s.nama_siswa,
                        k.nama_kelas

                    ORDER BY s.nama_siswa ASC;
                ";

                MySqlCommand cmd =
                    new MySqlCommand(sql, db.koneksi);

                cmd.Parameters.AddWithValue(
                    "@dari",
                    dtdari.Value.Date
                );

                cmd.Parameters.AddWithValue(
                    "@sampai",
                    dtsampai.Value.Date
                );

                cmd.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbkelas.SelectedValue
                );

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                dtLaporan = new DataTable();

                adapter.Fill(dtLaporan);

                if (dtLaporan.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Tidak ada data absensi pada periode tersebut.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data laporan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            finally
            {
                if (db.koneksi.State == ConnectionState.Open)
                {
                    db.koneksi.Close();
                }
            }
        }

        // =========================================
        // TOMBOL CETAK
        // =========================================
        private void printDocument1_PrintPage(
          object sender,
          PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

        Font fontJudul =
            new Font("Arial", 14, FontStyle.Bold);

        Font fontSubjudul =
            new Font("Arial", 10, FontStyle.Bold);

        Font fontNormal =
            new Font("Arial", 9);

        Font fontHeader =
            new Font("Arial", 9, FontStyle.Bold);

        float x = e.MarginBounds.Left;
        float y = e.MarginBounds.Top;

        // =====================================
        // JUDUL
        // =====================================

        string judul = "LAPORAN REKAP ABSENSI SISWA";

        SizeF ukuranJudul =
            g.MeasureString(judul, fontJudul);

        float posisiJudul =
            e.PageBounds.Width / 2 -
            ukuranJudul.Width / 2;

        g.DrawString(
            judul,
            fontJudul,
            Brushes.Black,
            posisiJudul,
            y
        );

            y += 35;

            string sekolah =
                "SMK TI PEMBANGUNAN";

        SizeF ukuranSekolah =
            g.MeasureString(sekolah, fontSubjudul);

        float posisiSekolah =
            e.PageBounds.Width / 2 -
            ukuranSekolah.Width / 2;

        g.DrawString(
            sekolah,
            fontSubjudul,
            Brushes.Black,
            posisiSekolah,
            y
        );

            y += 35;

            // =====================================
            // INFORMASI LAPORAN
            // =====================================

            string kelas =
                cmbkelas.Text;

        g.DrawString(
                "Kelas   : " + kelas,
                fontNormal,
                Brushes.Black,
                x,
                y
            );

            y += 20;

            g.DrawString(
                "Periode : " +
                dtdari.Value.ToString("dd/MM/yyyy") +
                " - " +
                dtsampai.Value.ToString("dd/MM/yyyy"),
                fontNormal,
                Brushes.Black,
                x,
                y
            );

            y += 30;

            // =====================================
            // TABEL
            // =====================================

            float lebarNo = 35;
        float lebarNis = 70;
        float lebarNama = 170;
        float lebarKelas = 80;
        float lebarStatus = 50;

        float tinggiBaris = 25;

        float posisiX = x;

        // Header
        Brush brushHeader = Brushes.LightGray;

        g.FillRectangle(
            brushHeader,
            posisiX,
            y,
            lebarNo,
            tinggiBaris
        );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo,
                y,
                lebarNis,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis,
                y,
                lebarNama,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis + lebarNama,
                y,
                lebarKelas,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas,
                y,
                lebarStatus,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus,
                y,
                lebarStatus,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 2),
                y,
                lebarStatus,
                tinggiBaris
            );

            g.FillRectangle(
                brushHeader,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 3),
                y,
                lebarStatus,
                tinggiBaris
            );

            // Teks header
            g.DrawString("No", fontHeader, Brushes.Black,
                posisiX + 8, y + 5);

            g.DrawString("NIS", fontHeader, Brushes.Black,
                posisiX + lebarNo + 8, y + 5);

            g.DrawString("Nama", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + 8, y + 5);

            g.DrawString("Kelas", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + lebarNama + 8,
                y + 5);

            g.DrawString("Hadir", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + 5,
                y + 5);

            g.DrawString("Izin", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus + 8,
                y + 5);

            g.DrawString("Sakit", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 2) + 5,
                y + 5);

            g.DrawString("Alpa", fontHeader, Brushes.Black,
                posisiX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 3) + 8,
                y + 5);

            y += tinggiBaris;

            // =====================================
            // ISI DATA
            // =====================================

            int nomor = 1;

            foreach (DataRow row in dtLaporan.Rows)
            {
                // Jika halaman penuh
                if (y + tinggiBaris >
                    e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    nomorHalaman++;
                    return;
                }

    float currentX = x;

    // Garis tabel
    g.DrawRectangle(
        Pens.Black,
        currentX,
        y,
        lebarNo,
        tinggiBaris
    );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo,
                    y,
                    lebarNis,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis,
                    y,
                    lebarNama,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis + lebarNama,
                    y,
                    lebarKelas,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas,
                    y,
                    lebarStatus,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus,
                    y,
                    lebarStatus,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 2),
                    y,
                    lebarStatus,
                    tinggiBaris
                );

                g.DrawRectangle(
                    Pens.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 3),
                    y,
                    lebarStatus,
                    tinggiBaris
                );

                g.DrawString(
                    nomor.ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + 10,
                    y + 5
                );

                g.DrawString(
                    row["NIS"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + 5,
                    y + 5
                );

                g.DrawString(
                    row["Nama"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + 5,
                    y + 5
                );

                g.DrawString(
                    row["Kelas"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + lebarNama + 5,
                    y + 5
                );

                g.DrawString(
                    row["Hadir"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + 15,
                    y + 5
                );

                g.DrawString(
                    row["Izin"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus + 15,
                    y + 5
                );

                g.DrawString(
                    row["Sakit"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 2) + 15,
                    y + 5
                );

                g.DrawString(
                    row["Alpa"].ToString(),
                    fontNormal,
                    Brushes.Black,
                    currentX + lebarNo + lebarNis + lebarNama + lebarKelas + (lebarStatus* 3) + 15,
                    y + 5
                );

                y += tinggiBaris;
                nomor++;
            }

// =====================================
// TANDA TANGAN
// =====================================

y += 30;

float posisiTtd =
    e.MarginBounds.Right - 180;

g.DrawString(
    "Mengetahui,",
    fontNormal,
    Brushes.Black,
    posisiTtd,
    y
);

y += 20;

g.DrawString(
    "Petugas",
    fontNormal,
    Brushes.Black,
    posisiTtd,
    y
);

y += 60;

g.DrawString(
    "(____________________)",
    fontNormal,
    Brushes.Black,
    posisiTtd,
    y
);

e.HasMorePages = false;
        }


        // =========================================
        // AWAL PRINT
        // =========================================
        private void printDocument1_BeginPrint(
            object sender,
            PrintEventArgs e)
        {
            nomorHalaman = 1;
        }

        
       
            
       
        

        private void btncetak_Click(object sender, EventArgs e)
        {
            if (!ambilDataLaporan())
            {
                return;
            }

            nomorHalaman = 1;

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Fpetugas halaman = new Fpetugas();
            halaman.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}