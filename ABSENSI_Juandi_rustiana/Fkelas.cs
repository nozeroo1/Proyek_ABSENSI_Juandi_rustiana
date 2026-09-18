using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fkelas : Form
    {
        private int idKelas = 0;

        public Fkelas()
        {
            InitializeComponent();
        }

        // =========================================================
        // TAMPIL DATA KELAS
        // =========================================================
        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT
                            k.id_kelas,
                            k.id_jurusan,
                            j.nama_jurusan,
                            k.nama_kelas,
                            k.tingkat,
                            k.id_wali_kelas,
                            g.nama_guru AS wali_kelas,
                            k.status
                          FROM kelas k
                          LEFT JOIN jurusan j
                              ON k.id_jurusan = j.id_jurusan
                          LEFT JOIN guru g
                              ON k.id_wali_kelas = g.id_guru
                          ORDER BY k.id_kelas DESC");

                datagridview.DataSource = db.ds.Tables[0];

                datagridview.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                datagridview.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                datagridview.MultiSelect        = false;
                datagridview.ReadOnly           = true;
                datagridview.AllowUserToAddRows = false;

                // Sembunyikan kolom ID
                if (datagridview.Columns.Contains("id_kelas"))
                    datagridview.Columns["id_kelas"].Visible = false;
                if (datagridview.Columns.Contains("id_jurusan"))
                    datagridview.Columns["id_jurusan"].Visible = false;
                if (datagridview.Columns.Contains("id_wali_kelas"))
                    datagridview.Columns["id_wali_kelas"].Visible = false;

                // Header yang ramah
                if (datagridview.Columns.Contains("nama_jurusan"))
                    datagridview.Columns["nama_jurusan"].HeaderText = "Jurusan";
                if (datagridview.Columns.Contains("nama_kelas"))
                    datagridview.Columns["nama_kelas"].HeaderText = "Nama Kelas";
                if (datagridview.Columns.Contains("tingkat"))
                    datagridview.Columns["tingkat"].HeaderText = "Tingkat";
                if (datagridview.Columns.Contains("wali_kelas"))
                    datagridview.Columns["wali_kelas"].HeaderText = "Wali Kelas";
                if (datagridview.Columns.Contains("status"))
                    datagridview.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD DATA JURUSAN KE COMBOBOX
        // =========================================================
        private void loadJurusan()
        {
            try
            {
                db.crud(@"SELECT id_jurusan, nama_jurusan
                          FROM jurusan
                          WHERE status = 'Aktif'
                          ORDER BY nama_jurusan ASC");

                cmbjurusan.DataSource    = db.ds.Tables[0];
                cmbjurusan.DisplayMember = "nama_jurusan";
                cmbjurusan.ValueMember   = "id_jurusan";
                cmbjurusan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data jurusan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD DATA GURU KE COMBOBOX WALI KELAS
        // =========================================================
        private void loadGuru()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Opsi pertama: kosong (wali kelas belum ditentukan)
                    string sql = @"SELECT 0 AS id_guru, '-- Pilih Wali Kelas --' AS nama_guru
                                   UNION ALL
                                   SELECT id_guru, nama_guru
                                   FROM guru
                                   WHERE status = 'Aktif'
                                   ORDER BY nama_guru ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbwalikelas.DataSource    = dt;
                    cmbwalikelas.DisplayMember = "nama_guru";
                    cmbwalikelas.ValueMember   = "id_guru";
                    cmbwalikelas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data guru: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fkelas_Load(object sender, EventArgs e)
        {
            cmbtingkat.Items.Clear();
            cmbtingkat.Items.Add("X");
            cmbtingkat.Items.Add("XI");
            cmbtingkat.Items.Add("XII");

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");
            cmbstatus.SelectedIndex = 0;

            loadJurusan();
            loadGuru();
            tampilData();
        }

        // =========================================================
        // KOSONGKAN FORM
        // =========================================================
        private void kosongkan()
        {
            idKelas = 0;

            txtnamakelas.Clear();

            cmbjurusan.SelectedIndex  = -1;
            cmbtingkat.SelectedIndex  = -1;
            cmbstatus.SelectedIndex   = 0;

            // Reset wali kelas ke baris pertama ("-- Pilih Wali Kelas --")
            if (cmbwalikelas.Items.Count > 0)
                cmbwalikelas.SelectedIndex = 0;

            txtnamakelas.Focus();
        }

        // =========================================================
        // KLIK BARIS DI GRID
        // =========================================================
        private void datagridview_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                idKelas = Convert.ToInt32(row.Cells["id_kelas"].Value);

                txtnamakelas.Text  = row.Cells["nama_kelas"].Value?.ToString() ?? "";
                cmbtingkat.Text    = row.Cells["tingkat"].Value?.ToString()    ?? "";
                cmbstatus.Text     = row.Cells["status"].Value?.ToString()     ?? "";

                // Set jurusan
                if (row.Cells["id_jurusan"].Value != null &&
                    row.Cells["id_jurusan"].Value != DBNull.Value)
                {
                    cmbjurusan.SelectedValue =
                        Convert.ToInt32(row.Cells["id_jurusan"].Value);
                }
                else
                {
                    cmbjurusan.SelectedIndex = -1;
                }

                // Set wali kelas — cari berdasarkan id_wali_kelas
                if (row.Cells["id_wali_kelas"].Value != null &&
                    row.Cells["id_wali_kelas"].Value != DBNull.Value)
                {
                    int idWali = Convert.ToInt32(row.Cells["id_wali_kelas"].Value);

                    // Cari baris yang ValueMember-nya == idWali
                    for (int i = 0; i < cmbwalikelas.Items.Count; i++)
                    {
                        DataRowView drv = cmbwalikelas.Items[i] as DataRowView;
                        if (drv != null &&
                            Convert.ToInt32(drv["id_guru"]) == idWali)
                        {
                            cmbwalikelas.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    cmbwalikelas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memilih data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // SIMPAN
        // =========================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cmbjurusan.SelectedIndex == -1 ||
                cmbjurusan.SelectedValue == null)
            {
                MessageBox.Show("Jurusan wajib dipilih!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnamakelas.Text) ||
                string.IsNullOrWhiteSpace(cmbtingkat.Text))
            {
                MessageBox.Show("Nama kelas dan tingkat wajib diisi!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil id_wali_kelas (0 = tidak dipilih → simpan NULL)
            int? idWali = null;
            if (cmbwalikelas.SelectedIndex > 0 &&
                cmbwalikelas.SelectedValue != null)
            {
                int val = Convert.ToInt32(cmbwalikelas.SelectedValue);
                if (val > 0) idWali = val;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO kelas
                                   (id_jurusan, nama_kelas, tingkat,
                                    id_wali_kelas, status)
                                   VALUES
                                   (@id_jurusan, @nama, @tingkat,
                                    @id_wali, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_jurusan",
                            Convert.ToInt32(cmbjurusan.SelectedValue)
                        );
                        cmd.Parameters.AddWithValue("@nama",    txtnamakelas.Text.Trim());
                        cmd.Parameters.AddWithValue("@tingkat", cmbtingkat.Text);
                        cmd.Parameters.AddWithValue(
                            "@id_wali",
                            idWali.HasValue ? (object)idWali.Value : DBNull.Value
                        );
                        cmd.Parameters.AddWithValue("@status",  cmbstatus.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kelas berhasil disimpan!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Nama kelas sudah ada dalam jurusan yang sama.",
                    "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // UBAH
        // =========================================================
        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idKelas == 0)
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbjurusan.SelectedIndex == -1 ||
                cmbjurusan.SelectedValue == null)
            {
                MessageBox.Show("Jurusan wajib dipilih!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnamakelas.Text) ||
                string.IsNullOrWhiteSpace(cmbtingkat.Text))
            {
                MessageBox.Show("Nama kelas dan tingkat wajib diisi!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idWali = null;
            if (cmbwalikelas.SelectedIndex > 0 &&
                cmbwalikelas.SelectedValue != null)
            {
                int val = Convert.ToInt32(cmbwalikelas.SelectedValue);
                if (val > 0) idWali = val;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE kelas SET
                                   id_jurusan    = @id_jurusan,
                                   nama_kelas    = @nama,
                                   tingkat       = @tingkat,
                                   id_wali_kelas = @id_wali,
                                   status        = @status
                                   WHERE id_kelas = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_jurusan",
                            Convert.ToInt32(cmbjurusan.SelectedValue)
                        );
                        cmd.Parameters.AddWithValue("@nama",    txtnamakelas.Text.Trim());
                        cmd.Parameters.AddWithValue("@tingkat", cmbtingkat.Text);
                        cmd.Parameters.AddWithValue(
                            "@id_wali",
                            idWali.HasValue ? (object)idWali.Value : DBNull.Value
                        );
                        cmd.Parameters.AddWithValue("@status",  cmbstatus.Text);
                        cmd.Parameters.AddWithValue("@id",      idKelas);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kelas berhasil diubah!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Nama kelas sudah ada dalam jurusan yang sama.",
                    "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // HAPUS
        // =========================================================
        private void btnhapus_Click_1(object sender, EventArgs e)
        {
            if (idKelas == 0)
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data kelas ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM kelas WHERE id_kelas = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idKelas);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kelas berhasil dihapus!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show(
                    "Data kelas tidak dapat dihapus karena masih\n" +
                    "digunakan oleh data siswa atau jadwal.",
                    "Tidak Dapat Dihapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // KEMBALI KE ADMIN
        // =========================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        private void txtnamakelas_TextChanged(object sender, EventArgs e) { }

        private void cmbjurusan_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            kosongkan();
        }
    }
}
