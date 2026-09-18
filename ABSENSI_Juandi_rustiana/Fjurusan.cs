using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fjurusan : Form
    {
        // id yang sedang dipilih di grid (0 = belum dipilih)
        private int idJurusan = 0;

        public Fjurusan()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fjurusan_Load(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");
            cmbstatus.SelectedIndex = 0;

            tampilData();
        }

        // =========================================================
        // TAMPIL DATA
        // =========================================================
        private void tampilData()
        {
            try
            {
                db.crud("SELECT * FROM jurusan ORDER BY id_jurusan DESC");

                dgvjurusan.DataSource = db.ds.Tables[0];

                dgvjurusan.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvjurusan.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvjurusan.MultiSelect        = false;
                dgvjurusan.ReadOnly           = true;
                dgvjurusan.AllowUserToAddRows = false;

                if (dgvjurusan.Columns.Contains("id_jurusan"))
                    dgvjurusan.Columns["id_jurusan"].Visible = false;

                if (dgvjurusan.Columns.Contains("kode_jurusan"))
                    dgvjurusan.Columns["kode_jurusan"].HeaderText = "Kode Jurusan";
                if (dgvjurusan.Columns.Contains("nama_jurusan"))
                    dgvjurusan.Columns["nama_jurusan"].HeaderText = "Nama Jurusan";
                if (dgvjurusan.Columns.Contains("status"))
                    dgvjurusan.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // KOSONGKAN FORM
        // =========================================================
        private void kosongkan()
        {
            idJurusan = 0;
            txtkode.Clear();
            txtnama.Clear();
            cmbstatus.SelectedIndex = 0;
            txtkode.Focus();
        }

        // =========================================================
        // KLIK BARIS DI GRID — isi form dengan data terpilih
        // =========================================================
        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvjurusan.Rows[e.RowIndex];

            idJurusan      = Convert.ToInt32(row.Cells["id_jurusan"].Value);
            txtkode.Text   = row.Cells["kode_jurusan"].Value?.ToString() ?? "";
            txtnama.Text   = row.Cells["nama_jurusan"].Value?.ToString() ?? "";
            cmbstatus.Text = row.Cells["status"].Value?.ToString()       ?? "";
        }

        // =========================================================
        // SIMPAN
        // =========================================================
        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkode.Text) ||
                string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show(
                    "Kode jurusan dan nama jurusan wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO jurusan
                                   (kode_jurusan, nama_jurusan, status)
                                   VALUES
                                   (@kode, @nama, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode",   txtkode.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@nama",   txtnama.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbstatus.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data jurusan berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Kode jurusan sudah digunakan. Gunakan kode yang berbeda.",
                    "Duplikat Kode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
        }

        // =========================================================
        // UBAH — tombol baru (btnubah di Designer)
        // =========================================================
        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idJurusan == 0)
            {
                MessageBox.Show(
                    "Pilih data jurusan yang ingin diubah!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txtkode.Text) ||
                string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show(
                    "Kode jurusan dan nama jurusan wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE jurusan SET
                                   kode_jurusan = @kode,
                                   nama_jurusan = @nama,
                                   status       = @status
                                   WHERE id_jurusan = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode",   txtkode.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@nama",   txtnama.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbstatus.Text);
                        cmd.Parameters.AddWithValue("@id",     idJurusan);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data jurusan berhasil diubah!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Kode jurusan sudah digunakan. Gunakan kode yang berbeda.",
                    "Duplikat Kode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
        }

        // =========================================================
        // HAPUS — tombol baru (btnhapus di Designer)
        // =========================================================
        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idJurusan == 0)
            {
                MessageBox.Show(
                    "Pilih data jurusan yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data jurusan ini?\n" +
                "Pastikan tidak ada kelas yang menggunakan jurusan ini.",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM jurusan WHERE id_jurusan = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idJurusan);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data jurusan berhasil dihapus!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show(
                    "Data jurusan tidak dapat dihapus karena masih\n" +
                    "digunakan oleh data kelas.",
                    "Tidak Dapat Dihapus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
        }

        // =========================================================
        // BATAL
        // =========================================================
        private void btnkosongkan_Click(object sender, EventArgs e)
        {
            kosongkan();
        }

        // =========================================================
        // KEMBALI
        // =========================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        private void txtkode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnama.Focus();
            }
        }
    }
}
