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
        // MENAMPILKAN DATA KELAS
        // =========================================================
        private void tampilData()
        {
            try
            {
                string sql = @"
                    SELECT 
                        k.id_kelas,
                        k.id_jurusan,
                        j.nama_jurusan,
                        k.nama_kelas,
                        k.tingkat,
                        k.wali_kelas,
                        k.status
                    FROM kelas k
                    LEFT JOIN jurusan j 
                        ON k.id_jurusan = j.id_jurusan
                    ORDER BY k.id_kelas DESC";

                db.crud(sql);

                datagridview.DataSource = db.ds.Tables[0];

                // Pengaturan DataGridView
                datagridview.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                datagridview.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                datagridview.MultiSelect = false;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;

                // Sembunyikan ID
                if (datagridview.Columns.Contains("id_kelas"))
                {
                    datagridview.Columns["id_kelas"].Visible = false;
                }

                if (datagridview.Columns.Contains("id_jurusan"))
                {
                    datagridview.Columns["id_jurusan"].Visible = false;
                }

                // Ubah nama header
                if (datagridview.Columns.Contains("nama_jurusan"))
                {
                    datagridview.Columns["nama_jurusan"].HeaderText =
                        "Jurusan";
                }

                if (datagridview.Columns.Contains("nama_kelas"))
                {
                    datagridview.Columns["nama_kelas"].HeaderText =
                        "Nama Kelas";
                }

                if (datagridview.Columns.Contains("tingkat"))
                {
                    datagridview.Columns["tingkat"].HeaderText =
                        "Tingkat";
                }

                if (datagridview.Columns.Contains("wali_kelas"))
                {
                    datagridview.Columns["wali_kelas"].HeaderText =
                        "Wali Kelas";
                }

                if (datagridview.Columns.Contains("status"))
                {
                    datagridview.Columns["status"].HeaderText =
                        "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data kelas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
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
                db.crud(@"
                    SELECT 
                        id_jurusan,
                        nama_jurusan
                    FROM jurusan
                    WHERE status = 'Aktif'
                    ORDER BY nama_jurusan ASC");

                cmbjurusan.DataSource = db.ds.Tables[0];
                cmbjurusan.DisplayMember = "nama_jurusan";
                cmbjurusan.ValueMember = "id_jurusan";
                cmbjurusan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data jurusan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fkelas_Load(object sender, EventArgs e)
        {
            // ComboBox Tingkat
            cmbtingkat.Items.Clear();
            cmbtingkat.Items.Add("X");
            cmbtingkat.Items.Add("XI");
            cmbtingkat.Items.Add("XII");

            // ComboBox Status
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");
            cmbstatus.SelectedIndex = 0;

            // Load data
            loadJurusan();
            tampilData();
        }

        // =========================================================
        // KOSONGKAN FORM
        // =========================================================
        private void kosongkan()
        {
            idKelas = 0;

            txtnamakelas.Clear();
            txtwalikelas.Clear();

            cmbjurusan.SelectedIndex = -1;
            cmbtingkat.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;

            txtnamakelas.Focus();
        }

        // =========================================================
        // KLIK DATA PADA DATAGRIDVIEW
        // =========================================================
        private void datagridview_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                // Ambil ID kelas
                idKelas = Convert.ToInt32(
                    row.Cells["id_kelas"].Value
                );

                // Nama kelas
                txtnamakelas.Text =
                    row.Cells["nama_kelas"].Value?.ToString() ?? "";

                // Tingkat
                cmbtingkat.Text =
                    row.Cells["tingkat"].Value?.ToString() ?? "";

                // Wali kelas
                txtwalikelas.Text =
                    row.Cells["wali_kelas"].Value?.ToString() ?? "";

                // Status
                cmbstatus.Text =
                    row.Cells["status"].Value?.ToString() ?? "";

                // Jurusan
                if (row.Cells["id_jurusan"].Value != null &&
                    row.Cells["id_jurusan"].Value != DBNull.Value)
                {
                    int idJurusan = Convert.ToInt32(
                        row.Cells["id_jurusan"].Value
                    );

                    cmbjurusan.SelectedValue = idJurusan;
                }
                else
                {
                    cmbjurusan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memilih data kelas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // SIMPAN DATA KELAS
        // =========================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            // Validasi jurusan
            if (cmbjurusan.SelectedIndex == -1 ||
                cmbjurusan.SelectedValue == null)
            {
                MessageBox.Show(
                    "Jurusan wajib dipilih!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validasi nama dan tingkat
            if (string.IsNullOrWhiteSpace(txtnamakelas.Text) ||
                string.IsNullOrWhiteSpace(cmbtingkat.Text))
            {
                MessageBox.Show(
                    "Nama kelas dan tingkat wajib diisi!",
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
                    INSERT INTO kelas
                    (
                        id_jurusan,
                        nama_kelas,
                        tingkat,
                        wali_kelas,
                        status
                    )
                    VALUES
                    (
                        @id_jurusan,
                        @nama,
                        @tingkat,
                        @wali,
                        @status
                    )";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_jurusan",
                    Convert.ToInt32(cmbjurusan.SelectedValue)
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnamakelas.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@tingkat",
                    cmbtingkat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@wali",
                    txtwalikelas.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data kelas berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data kelas: " + ex.Message,
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

        // =========================================================
        // UBAH DATA KELAS
        // =========================================================
        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idKelas == 0)
            {
                MessageBox.Show(
                    "Pilih data pada tabel terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validasi jurusan
            if (cmbjurusan.SelectedIndex == -1 ||
                cmbjurusan.SelectedValue == null)
            {
                MessageBox.Show(
                    "Jurusan wajib dipilih!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validasi nama dan tingkat
            if (string.IsNullOrWhiteSpace(txtnamakelas.Text) ||
                string.IsNullOrWhiteSpace(cmbtingkat.Text))
            {
                MessageBox.Show(
                    "Nama kelas dan tingkat wajib diisi!",
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
                    UPDATE kelas SET
                        id_jurusan = @id_jurusan,
                        nama_kelas = @nama,
                        tingkat = @tingkat,
                        wali_kelas = @wali,
                        status = @status
                    WHERE id_kelas = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                // INI YANG SEBELUMNYA BELUM ADA
                db.perintah.Parameters.AddWithValue(
                    "@id_jurusan",
                    Convert.ToInt32(cmbjurusan.SelectedValue)
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnamakelas.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@tingkat",
                    cmbtingkat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@wali",
                    txtwalikelas.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idKelas
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data kelas berhasil diubah!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data kelas: " + ex.Message,
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

        // =========================================================
        // HAPUS DATA KELAS
        // =========================================================
        private void btnhapus_Click_1(object sender, EventArgs e)
        {
            if (idKelas == 0)
            {
                MessageBox.Show(
                    "Pilih data pada tabel terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data kelas ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql =
                    "DELETE FROM kelas WHERE id_kelas = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idKelas
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data kelas berhasil dihapus!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex)
            {
                // Kemungkinan kelas masih digunakan oleh siswa
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "Data kelas tidak dapat dihapus karena masih digunakan oleh data siswa.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Gagal menghapus data kelas: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data kelas: " + ex.Message,
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

        // =========================================================
        // KEMBALI KE ADMIN
        // =========================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        // =========================================================
        // EVENT TEXTBOX
        // =========================================================
        private void txtnamakelas_TextChanged(object sender, EventArgs e)
        {
        }

        // =========================================================
        // EVENT COMBOBOX JURUSAN
        // =========================================================
        private void cmbjurusan_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}