using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fguru : Form
    {
        private int idGuru = 0;

        public Fguru()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fguru_Load(object sender, EventArgs e)
        {
            cmbklmn.Items.Clear();
            cmbklmn.Items.Add("L");
            cmbklmn.Items.Add("P");

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
                db.crud(@"SELECT
                            id_guru,
                            nip,
                            nama_guru,
                            jenis_kelamin,
                            no_telp,
                            status
                          FROM guru
                          ORDER BY id_guru DESC");

                dgvguru.DataSource = db.ds.Tables[0];

                dgvguru.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvguru.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvguru.MultiSelect        = false;
                dgvguru.ReadOnly           = true;
                dgvguru.AllowUserToAddRows = false;

                // Sembunyikan kolom ID
                if (dgvguru.Columns.Contains("id_guru"))
                    dgvguru.Columns["id_guru"].Visible = false;

                // Nama header yang ramah
                if (dgvguru.Columns.Contains("nip"))
                    dgvguru.Columns["nip"].HeaderText = "NIP";
                if (dgvguru.Columns.Contains("nama_guru"))
                    dgvguru.Columns["nama_guru"].HeaderText = "Nama Guru";
                if (dgvguru.Columns.Contains("jenis_kelamin"))
                    dgvguru.Columns["jenis_kelamin"].HeaderText = "Jenis Kelamin";
                if (dgvguru.Columns.Contains("no_telp"))
                    dgvguru.Columns["no_telp"].HeaderText = "No. Telepon";
                if (dgvguru.Columns.Contains("status"))
                    dgvguru.Columns["status"].HeaderText = "Status";
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
            idGuru = 0;
            txtnip.Clear();
            txtnama.Clear();
            txttelepon.Clear();
            cmbklmn.SelectedIndex   = -1;
            cmbstatus.SelectedIndex = 0;
            txtnip.Focus();
        }

        // =========================================================
        // KLIK BARIS DI GRID
        // =========================================================
        private void dgvguru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvguru.Rows[e.RowIndex];

            idGuru = Convert.ToInt32(row.Cells["id_guru"].Value);

            txtnip.Text =
                row.Cells["nip"].Value?.ToString() ?? "";
            txtnama.Text =
                row.Cells["nama_guru"].Value?.ToString() ?? "";
            cmbklmn.Text =
                row.Cells["jenis_kelamin"].Value?.ToString() ?? "";
            txttelepon.Text =
                row.Cells["no_telp"].Value?.ToString() ?? "";
            cmbstatus.Text =
                row.Cells["status"].Value?.ToString() ?? "";
        }

        // =========================================================
        // SIMPAN (guna2Button1 = Simpan di form lama)
        // =========================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show(
                    "Nama guru wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtnama.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO guru
                                   (nip, nama_guru, jenis_kelamin, no_telp, status)
                                   VALUES
                                   (@nip, @nama, @jk, @telp, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // NIP boleh kosong → simpan NULL agar UNIQUE KEY tidak bertabrakan
                        cmd.Parameters.AddWithValue(
                            "@nip",
                            string.IsNullOrWhiteSpace(txtnip.Text)
                                ? (object)DBNull.Value
                                : txtnip.Text.Trim()
                        );
                        cmd.Parameters.AddWithValue("@nama",   txtnama.Text.Trim());
                        cmd.Parameters.AddWithValue("@jk",     cmbklmn.Text);
                        cmd.Parameters.AddWithValue("@telp",   txttelepon.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbstatus.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data guru berhasil disimpan!",
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
                    "NIP sudah terdaftar untuk guru lain. Gunakan NIP yang berbeda.",
                    "Duplikat NIP",
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
        // UBAH (guna2Button2)
        // =========================================================
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (idGuru == 0)
            {
                MessageBox.Show(
                    "Pilih data guru yang ingin diubah terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show(
                    "Nama guru wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtnama.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE guru SET
                                   nip            = @nip,
                                   nama_guru      = @nama,
                                   jenis_kelamin  = @jk,
                                   no_telp        = @telp,
                                   status         = @status
                                   WHERE id_guru  = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nip",
                            string.IsNullOrWhiteSpace(txtnip.Text)
                                ? (object)DBNull.Value
                                : txtnip.Text.Trim()
                        );
                        cmd.Parameters.AddWithValue("@nama",   txtnama.Text.Trim());
                        cmd.Parameters.AddWithValue("@jk",     cmbklmn.Text);
                        cmd.Parameters.AddWithValue("@telp",   txttelepon.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbstatus.Text);
                        cmd.Parameters.AddWithValue("@id",     idGuru);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data guru berhasil diubah!",
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
                    "NIP sudah terdaftar untuk guru lain. Gunakan NIP yang berbeda.",
                    "Duplikat NIP",
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
        // HAPUS (guna2Button3)
        // =========================================================
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (idGuru == 0)
            {
                MessageBox.Show(
                    "Pilih data guru yang ingin dihapus terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data guru ini?",
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

                    string sql = "DELETE FROM guru WHERE id_guru = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idGuru);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data guru berhasil dihapus!",
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
                    "Data guru tidak dapat dihapus karena masih digunakan\n" +
                    "sebagai pengajar pada jadwal atau wali kelas.",
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
        // KEMBALI (guna2Button1_Click_1)
        // =========================================================
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        private void txtnip_TextChanged(object sender, EventArgs e) { }

        private void txtnip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnama.Focus();
            }
        }

        private void cmbklmn_KeyPress(object sender, KeyPressEventArgs e) { }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            kosongkan();
        }
    }
}
