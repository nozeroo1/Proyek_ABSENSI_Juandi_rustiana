using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fsiswa : Form
    {
        private int idSiswa = 0;

        public Fsiswa()
        {
            InitializeComponent();

            cmbbjurusan.SelectedIndexChanged += cmbbjurusan_SelectedIndexChanged;
        }

        // =========================================================
        // LOAD JURUSAN
        // =========================================================
        private void loadJurusan()
        {
            try
            {
                db.crud(@"SELECT
                            id_jurusan,
                            nama_jurusan
                          FROM jurusan
                          WHERE status = 'Aktif'
                          ORDER BY nama_jurusan ASC");

                cmbbjurusan.DataSource = null;
                cmbbjurusan.DisplayMember = "nama_jurusan";
                cmbbjurusan.ValueMember = "id_jurusan";
                cmbbjurusan.DataSource = db.ds.Tables[0];

                cmbbjurusan.SelectedIndex = -1;
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
        // LOAD KELAS BERDASARKAN JURUSAN
        // =========================================================
        private void loadKelasByJurusan()
        {
            try
            {
                if (cmbbjurusan.SelectedValue == null ||
                    cmbbjurusan.SelectedValue is DataRowView)
                {
                    cmbKelas.DataSource = null;
                    return;
                }

                int idJurusan = Convert.ToInt32(
                    cmbbjurusan.SelectedValue
                );

                db.crud(@"SELECT
                            id_kelas,
                            nama_kelas
                          FROM kelas
                          WHERE id_jurusan = " + idJurusan + @"
                          AND status = 'Aktif'
                          ORDER BY nama_kelas ASC");

                cmbKelas.DataSource = null;

                cmbKelas.DisplayMember = "nama_kelas";
                cmbKelas.ValueMember = "id_kelas";

                cmbKelas.DataSource = db.ds.Tables[0];

                cmbKelas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat kelas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fsiswa_Load(object sender, EventArgs e)
        {
            // Jenis kelamin
            cmbjk.Items.Clear();
            cmbjk.Items.Add("Laki-laki");
            cmbjk.Items.Add("Perempuan");
            cmbjk.SelectedIndex = -1;

            // Status
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");
            cmbstatus.SelectedIndex = 0;

            // Load jurusan
            loadJurusan();

            // Kosongkan kelas sebelum jurusan dipilih
            cmbKelas.DataSource = null;
            cmbKelas.Items.Clear();

            // Tampilkan data siswa
            tampilData();

            txtnis.Select();
        }

        // =========================================================
        // TAMPIL DATA SISWA
        // =========================================================
        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT
                            s.id_siswa,
                            s.nis,
                            s.nisn,
                            s.nama_siswa,
                            s.jenis_kelamin,
                            s.tempat_lahir,
                            s.tanggal_lahir,
                            s.alamat,
                            s.id_kelas,
                            k.nama_kelas,
                            k.tingkat,
                            j.nama_jurusan,
                            s.status
                          FROM siswa s

                          LEFT JOIN kelas k
                            ON s.id_kelas = k.id_kelas

                          LEFT JOIN jurusan j
                            ON k.id_jurusan = j.id_jurusan

                          ORDER BY s.id_siswa DESC");

                datagridview.DataSource = db.ds.Tables[0];

                datagridview.Columns["id_siswa"].HeaderText = "ID";
                datagridview.Columns["nis"].HeaderText = "NIS";
                datagridview.Columns["nisn"].HeaderText = "NISN";
                datagridview.Columns["nama_siswa"].HeaderText = "Nama Siswa";
                datagridview.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
                datagridview.Columns["tempat_lahir"].HeaderText = "Tempat Lahir";
                datagridview.Columns["tanggal_lahir"].HeaderText = "Tanggal Lahir";
                datagridview.Columns["alamat"].HeaderText = "Alamat";
                datagridview.Columns["nama_jurusan"].HeaderText = "Jurusan";
                datagridview.Columns["nama_kelas"].HeaderText = "Kelas";
                datagridview.Columns["tingkat"].HeaderText = "Tingkat";
                datagridview.Columns["status"].HeaderText = "Status";

                // Sembunyikan ID
                datagridview.Columns["id_siswa"].Visible = false;
                datagridview.Columns["id_kelas"].Visible = false;

                datagridview.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                datagridview.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                datagridview.MultiSelect = false;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // KOSONGKAN FORM
        // =========================================================
        private void kosongkan()
        {
            idSiswa = 0;

            txtnis.Clear();
            txtnisn.Clear();
            txtnama.Clear();
            txttempat.Clear();
            txtalamat.Clear();

            cmbjk.SelectedIndex = -1;

            // Kosongkan kelas
            cmbKelas.DataSource = null;
            cmbKelas.Items.Clear();

            // Kosongkan jurusan
            cmbbjurusan.SelectedIndex = -1;

            // Status kembali Aktif
            cmbstatus.SelectedIndex = 0;

            tanggallahir.Value = DateTime.Now;

            txtnis.Focus();
        }

        // =========================================================
        // SIMPAN DATA SISWA
        // =========================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtnis.Text == "" ||
                txtnama.Text == "" ||
                cmbjk.Text == "" ||
                cmbbjurusan.SelectedValue == null ||
                cmbKelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "NIS, nama, jenis kelamin, jurusan, dan kelas wajib diisi!",
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

                string sql = @"INSERT INTO siswa
                               (
                                   nis,
                                   nisn,
                                   nama_siswa,
                                   jenis_kelamin,
                                   tempat_lahir,
                                   tanggal_lahir,
                                   alamat,
                                   id_kelas,
                                   status
                               )
                               VALUES
                               (
                                   @nis,
                                   @nisn,
                                   @nama,
                                   @jk,
                                   @tempat,
                                   @tanggal,
                                   @alamat,
                                   @id_kelas,
                                   @status
                               )";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nis",
                    txtnis.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nisn",
                    txtnisn.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jk",
                    cmbjk.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@tempat",
                    txttempat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@tanggal",
                    tanggallahir.Value
                );

                db.perintah.Parameters.AddWithValue(
                    "@alamat",
                    txtalamat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbKelas.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data siswa berhasil disimpan!",
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
                    "Gagal menyimpan data: " + ex.Message,
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
        // KLIK DATA SISWA
        // =========================================================
        private void datagridview_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                datagridview.Rows[e.RowIndex];

            idSiswa = Convert.ToInt32(
                row.Cells["id_siswa"].Value
            );

            txtnis.Text =
                row.Cells["nis"].Value.ToString();

            txtnisn.Text =
                row.Cells["nisn"].Value.ToString();

            txtnama.Text =
                row.Cells["nama_siswa"].Value.ToString();

            cmbjk.Text =
                row.Cells["jenis_kelamin"].Value.ToString();

            txttempat.Text =
                row.Cells["tempat_lahir"].Value.ToString();

            txtalamat.Text =
                row.Cells["alamat"].Value.ToString();

            cmbstatus.Text =
                row.Cells["status"].Value.ToString();

            if (row.Cells["tanggal_lahir"].Value != DBNull.Value)
            {
                tanggallahir.Value =
                    Convert.ToDateTime(
                        row.Cells["tanggal_lahir"].Value
                    );
            }

            // =====================================================
            // LOAD JURUSAN DAN KELAS SAAT DATA DIPILIH
            // =====================================================
            if (row.Cells["id_kelas"].Value != DBNull.Value)
            {
                int idKelas =
                    Convert.ToInt32(
                        row.Cells["id_kelas"].Value
                    );

                try
                {
                    db.crud(@"SELECT id_jurusan
                              FROM kelas
                              WHERE id_kelas = " + idKelas);

                    if (db.ds.Tables[0].Rows.Count > 0)
                    {
                        int idJurusan =
                            Convert.ToInt32(
                                db.ds.Tables[0].Rows[0]["id_jurusan"]
                            );

                        // Pilih jurusan
                        cmbbjurusan.SelectedValue =
                            idJurusan;

                        // Load kelas sesuai jurusan
                        loadKelasByJurusan();

                        // Pilih kelas
                        cmbKelas.SelectedValue =
                            idKelas;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal mengambil data jurusan/kelas: "
                        + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // =========================================================
        // UBAH DATA SISWA
        // =========================================================
        private void guna2Button2_Click(
            object sender,
            EventArgs e)
        {
            if (idSiswa == 0)
            {
                MessageBox.Show(
                    "Pilih data siswa yang ingin diubah!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (txtnis.Text == "" ||
                txtnama.Text == "" ||
                cmbjk.Text == "" ||
                cmbbjurusan.SelectedValue == null ||
                cmbKelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "NIS, nama, jenis kelamin, jurusan, dan kelas wajib diisi!",
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

                string sql = @"UPDATE siswa SET
                               nis = @nis,
                               nisn = @nisn,
                               nama_siswa = @nama,
                               jenis_kelamin = @jk,
                               tempat_lahir = @tempat,
                               tanggal_lahir = @tanggal,
                               alamat = @alamat,
                               id_kelas = @id_kelas,
                               status = @status
                               WHERE id_siswa = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nis",
                    txtnis.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nisn",
                    txtnisn.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jk",
                    cmbjk.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@tempat",
                    txttempat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@tanggal",
                    tanggallahir.Value
                );

                db.perintah.Parameters.AddWithValue(
                    "@alamat",
                    txtalamat.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbKelas.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idSiswa
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data siswa berhasil diubah!",
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
                    "Gagal mengubah data: " + ex.Message,
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
        // HAPUS DATA SISWA
        // =========================================================
        private void guna2Button3_Click(
            object sender,
            EventArgs e)
        {
            if (idSiswa == 0)
            {
                MessageBox.Show(
                    "Pilih data siswa yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult konfirmasi =
                MessageBox.Show(
                    "Yakin ingin menghapus data siswa ini?",
                    "Konfirmasi Hapus",
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
                    "DELETE FROM siswa WHERE id_siswa = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idSiswa
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data siswa berhasil dihapus!",
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
                    "Gagal menghapus data: " + ex.Message,
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
        // JURUSAN BERUBAH
        // =========================================================
        private void cmbbjurusan_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbbjurusan.SelectedIndex == -1)
            {
                cmbKelas.DataSource = null;
                return;
            }

            if (cmbbjurusan.SelectedValue == null)
            {
                cmbKelas.DataSource = null;
                return;
            }

            if (cmbbjurusan.SelectedValue is DataRowView)
            {
                return;
            }

            loadKelasByJurusan();
        }

        // =========================================================
        // KELAS BERUBAH
        // =========================================================
        private void cmbKelas_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Dikosongkan.
            // Kelas tidak perlu memanggil loadKelasByJurusan().
        }

        // =========================================================
        // ENTER
        // =========================================================
        private void txtnis_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnisn.Focus();
            }
        }

        private void txtnisn_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnama.Focus();
            }
        }

        private void txtnama_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmbjk.Focus();
            }
        }

        private void cmbjk_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txttempat.Focus();
            }
        }

        private void txttempat_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tanggallahir.Focus();
            }
        }

        private void tanggallahir_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtalamat.Focus();
            }
        }

        private void txtalamat_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmbbjurusan.Focus();
            }
        }

        private void cmbKelas_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmbstatus.Focus();
            }
        }

        // =========================================================
        // BATAL
        // =========================================================
        private void btnbatal_Click(
            object sender,
            EventArgs e)
        {
            kosongkan();
        }

        // =========================================================
        // KEMBALI
        // =========================================================
        private void guna2Button1_Click(
            object sender,
            EventArgs e)
        {
            Fadmin halaman = new Fadmin();

            halaman.Show();

            this.Hide();
        }

        // =========================================================
        // EVENT KOSONG
        // =========================================================
        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txttanggal_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void Fsiswa_KeyDown(
            object sender,
            KeyEventArgs e)
        {
        }

        private void txtnisn_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void Fsiswa_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
        }
    }
}