using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Frekapabsensi : Form
    {
        public Frekapabsensi()
        {
            InitializeComponent();
        }

        private void Frekapabsensi_Load(object sender, EventArgs e)
        {
            dtdari.Value = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            tampilKelas();
            setupDataGridView();
        }

        // =========================
        // SETUP DATAGRIDVIEW
        // =========================
        private void setupDataGridView()
        {
            dgvrekap.AutoGenerateColumns = false;
            dgvrekap.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvrekap.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvrekap.MultiSelect = false;
            dgvrekap.ReadOnly = true;
            dgvrekap.AllowUserToAddRows = false;
        }

        // =========================
        // TAMPIL KELAS
        // =========================
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

        // =========================
        // TAMPIL REKAP
        // =========================
        private void tampilRekap()
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "Silakan pilih kelas terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
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

                    ORDER BY s.nama_siswa ASC
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

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvrekap.DataSource = dt;
                for (int i = 0; i < dgvrekap.Rows.Count; i++)
                {
                    dgvrekap.Rows[i].Cells["No"].Value = i + 1;
                }



                // Judul kolom
                dgvrekap.Columns["NIS"].HeaderText = "NIS";
                dgvrekap.Columns["Nama"].HeaderText = "Nama";
                dgvrekap.Columns["Kelas"].HeaderText = "Kelas";
                dgvrekap.Columns["Hadir"].HeaderText = "Hadir";
                dgvrekap.Columns["Izin"].HeaderText = "Izin";
                dgvrekap.Columns["Sakit"].HeaderText = "Sakit";
                dgvrekap.Columns["Alpa"].HeaderText = "Alpa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan rekap: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State == ConnectionState.Open)
                {
                    db.koneksi.Close();
                }
            }
        }

       
       

       
    
       

        private void btntampil_Click(object sender, EventArgs e)
        {
            if (dtdari.Value.Date > dtsampai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal 'Dari' tidak boleh lebih besar dari tanggal 'Sampai'!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            tampilRekap();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            dtdari.Value = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            cmbkelas.SelectedIndex = -1;

            dgvrekap.DataSource = null;
        }

        private void dgvrekap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Fpetugas halaman = new Fpetugas();
            halaman.Show();
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}