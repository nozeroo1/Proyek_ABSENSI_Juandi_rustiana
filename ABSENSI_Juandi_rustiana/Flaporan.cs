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
        private DataTable dtLaporan    = new DataTable();
        private int       nomorHalaman = 1;

        public Flaporan()
        {
            InitializeComponent();

            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage  += printDocument1_PrintPage;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Flaporan_Load(object sender, EventArgs e)
        {
            dtdari.Value   = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            tampilKelas();
        }

        // =========================================================
        // TAMPIL KELAS
        // =========================================================
        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT id_kelas, nama_kelas
                          FROM kelas
                          WHERE status = 'Aktif'
                          ORDER BY nama_kelas ASC");

                cmbkelas.DataSource    = db.ds.Tables[0];
                cmbkelas.DisplayMember = "nama_kelas";
                cmbkelas.ValueMember   = "id_kelas";
                cmbkelas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // AMBIL DATA LAPORAN — LEFT JOIN agar semua siswa muncul
        // =========================================================
        private bool ambilDataLaporan()
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih kelas terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtdari.Value.Date > dtsampai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal Dari tidak boleh lebih besar dari tanggal Sampai!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // LEFT JOIN: siswa tanpa absensi tetap muncul dengan nilai 0
                    string sql = @"
                        SELECT
                            s.nis        AS NIS,
                            s.nama_siswa  AS Nama,
                            k.nama_kelas  AS Kelas,

                            SUM(CASE WHEN a.status = 'Hadir' THEN 1 ELSE 0 END) AS Hadir,
                            SUM(CASE WHEN a.status = 'Izin'  THEN 1 ELSE 0 END) AS Izin,
                            SUM(CASE WHEN a.status = 'Sakit' THEN 1 ELSE 0 END) AS Sakit,
                            SUM(CASE WHEN a.status = 'Alpa'  THEN 1 ELSE 0 END) AS Alpa

                        FROM siswa s
                        INNER JOIN kelas k ON s.id_kelas = k.id_kelas
                        LEFT JOIN absensi a
                            ON s.id_siswa = a.id_siswa
                           AND a.tanggal BETWEEN @dari AND @sampai

                        WHERE s.id_kelas = @id_kelas
                          AND s.status   = 'Aktif'

                        GROUP BY
                            s.id_siswa,
                            s.nis,
                            s.nama_siswa,
                            k.nama_kelas

                        ORDER BY s.nama_siswa ASC";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@dari",     dtdari.Value.Date);
                    cmd.Parameters.AddWithValue("@sampai",   dtsampai.Value.Date);
                    cmd.Parameters.AddWithValue("@id_kelas", cmbkelas.SelectedValue);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    dtLaporan = new DataTable();
                    adapter.Fill(dtLaporan);

                    if (dtLaporan.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "Tidak ada data siswa aktif pada kelas ini.",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data laporan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return false;
            }
        }

        // =========================================================
        // CETAK
        // =========================================================
        private void btncetak_Click(object sender, EventArgs e)
        {
            if (!ambilDataLaporan()) return;

            nomorHalaman = 1;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // =========================================================
        // AWAL PRINT
        // =========================================================
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            nomorHalaman = 1;
        }

        // =========================================================
        // PRINT PAGE
        // =========================================================
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font fontJudul    = new Font("Arial", 14, FontStyle.Bold);
            Font fontSubjudul = new Font("Arial", 10, FontStyle.Bold);
            Font fontNormal   = new Font("Arial", 9);
            Font fontHeader   = new Font("Arial", 9, FontStyle.Bold);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // ── JUDUL ────────────────────────────────────────────
            string judul      = "LAPORAN REKAP ABSENSI SISWA";
            SizeF  ukuranJudul = g.MeasureString(judul, fontJudul);
            g.DrawString(judul, fontJudul, Brushes.Black,
                e.PageBounds.Width / 2 - ukuranJudul.Width / 2, y);
            y += 35;

            string sekolah = "SMK TI PEMBANGUNAN";
            SizeF  ukuranS  = g.MeasureString(sekolah, fontSubjudul);
            g.DrawString(sekolah, fontSubjudul, Brushes.Black,
                e.PageBounds.Width / 2 - ukuranS.Width / 2, y);
            y += 35;

            // ── INFO LAPORAN ─────────────────────────────────────
            g.DrawString("Kelas   : " + cmbkelas.Text, fontNormal, Brushes.Black, x, y);
            y += 20;
            g.DrawString(
                "Periode : " + dtdari.Value.ToString("dd/MM/yyyy") +
                " - "       + dtsampai.Value.ToString("dd/MM/yyyy"),
                fontNormal, Brushes.Black, x, y
            );
            y += 30;

            // ── HEADER TABEL ─────────────────────────────────────
            float lebarNo     = 35;
            float lebarNis    = 70;
            float lebarNama   = 170;
            float lebarKelas  = 80;
            float lebarStatus = 50;
            float tinggi      = 25;

            Brush brushHeader = Brushes.LightGray;

            float[] kolX = {
                x,
                x + lebarNo,
                x + lebarNo + lebarNis,
                x + lebarNo + lebarNis + lebarNama,
                x + lebarNo + lebarNis + lebarNama + lebarKelas,
                x + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus,
                x + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus * 2,
                x + lebarNo + lebarNis + lebarNama + lebarKelas + lebarStatus * 3
            };
            float[] kolLebar = {
                lebarNo, lebarNis, lebarNama, lebarKelas,
                lebarStatus, lebarStatus, lebarStatus, lebarStatus
            };
            string[] kolJudul = { "No", "NIS", "Nama", "Kelas", "Hadir", "Izin", "Sakit", "Alpa" };

            for (int i = 0; i < 8; i++)
            {
                g.FillRectangle(brushHeader, kolX[i], y, kolLebar[i], tinggi);
                g.DrawString(kolJudul[i], fontHeader, Brushes.Black, kolX[i] + 5, y + 5);
            }
            y += tinggi;

            // ── ISI DATA ─────────────────────────────────────────
            int nomor = 1;
            string[] kolomData = { "NIS", "Nama", "Kelas", "Hadir", "Izin", "Sakit", "Alpa" };

            foreach (DataRow row in dtLaporan.Rows)
            {
                if (y + tinggi > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    nomorHalaman++;
                    return;
                }

                // Gambar kotak
                for (int i = 0; i < 8; i++)
                    g.DrawRectangle(Pens.Black, kolX[i], y, kolLebar[i], tinggi);

                // Isi teks
                g.DrawString(nomor.ToString(), fontNormal, Brushes.Black, kolX[0] + 8, y + 5);
                for (int i = 0; i < kolomData.Length; i++)
                    g.DrawString(
                        row[kolomData[i]].ToString(),
                        fontNormal, Brushes.Black,
                        kolX[i + 1] + 5, y + 5
                    );

                y += tinggi;
                nomor++;
            }

            // ── TANDA TANGAN ─────────────────────────────────────
            y += 30;
            float posisiTtd = e.MarginBounds.Right - 180;

            g.DrawString("Mengetahui,", fontNormal, Brushes.Black, posisiTtd, y);
            y += 20;
            g.DrawString("Petugas",    fontNormal, Brushes.Black, posisiTtd, y);
            y += 60;
            g.DrawString("(____________________)", fontNormal, Brushes.Black, posisiTtd, y);

            e.HasMorePages = false;
        }

        // =========================================================
        // KEMBALI
        // =========================================================
        private void btnkembali_Click(object sender, EventArgs e)
        {
            Fpetugas halaman = new Fpetugas();
            halaman.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}
