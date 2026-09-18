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

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Frekapabsensi_Load(object sender, EventArgs e)
        {
            dtdari.Value   = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            tampilKelas();
            setupDataGridView();
        }

        // =========================================================
        // SETUP DATAGRIDVIEW
        // =========================================================
        private void setupDataGridView()
        {
            // Kolom sudah didefinisikan di Designer — tidak perlu AutoGenerate
            dgvrekap.AutoGenerateColumns  = false;
            dgvrekap.AutoSizeColumnsMode  = DataGridViewAutoSizeColumnsMode.Fill;
            dgvrekap.SelectionMode        = DataGridViewSelectionMode.FullRowSelect;
            dgvrekap.MultiSelect          = false;
            dgvrekap.ReadOnly             = true;
            dgvrekap.AllowUserToAddRows   = false;
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
        // TAMPIL REKAP — LEFT JOIN agar siswa tanpa absensi tetap muncul
        // =========================================================
        private void tampilRekap()
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih kelas terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // LEFT JOIN: siswa yang belum punya absensi tetap muncul
                    // dengan nilai 0 di semua kolom status
                    string sql = @"
                        SELECT
                            s.nis       AS NIS,
                            s.nama_siswa AS Nama,
                            k.nama_kelas AS Kelas,

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
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Tambah kolom No ke DataTable (bukan ke grid)
                    // agar DataPropertyName "No" dapat dibinding
                    if (!dt.Columns.Contains("No"))
                        dt.Columns.Add("No", typeof(int));

                    for (int i = 0; i < dt.Rows.Count; i++)
                        dt.Rows[i]["No"] = i + 1;

                    dgvrekap.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan rekap: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // TOMBOL TAMPILKAN
        // =========================================================
        private void btntampil_Click(object sender, EventArgs e)
        {
            if (dtdari.Value.Date > dtsampai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal 'Dari' tidak boleh lebih besar dari tanggal 'Sampai'!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            tampilRekap();
        }

        // =========================================================
        // RESET
        // =========================================================
        private void btnreset_Click_1(object sender, EventArgs e)
        {
            dtdari.Value   = DateTime.Now;
            dtsampai.Value = DateTime.Now;

            cmbkelas.SelectedIndex = -1;
            dgvrekap.DataSource    = null;
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

        private void dgvrekap_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void guna2Panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void guna2Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}
