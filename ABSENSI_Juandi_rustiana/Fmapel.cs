using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fmapel : Form
    {
        private int idMapel = 0;

        public Fmapel()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fmapel_Load(object sender, EventArgs e)
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
                db.crud(@"SELECT
                            id_mapel,
                            kode_mapel,
                            nama_mapel,
                            status
                          FROM mapel
                          ORDER BY id_mapel DESC");

                dgvmapel.DataSource        = db.ds.Tables[0];
                dgvmapel.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvmapel.SelectionMode     =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvmapel.MultiSelect        = false;
                dgvmapel.ReadOnly           = true;
                dgvmapel.AllowUserToAddRows = false;

                if (dgvmapel.Columns.Contains("id_mapel"))
                    dgvmapel.Columns["id_mapel"].Visible = false;
                if (dgvmapel.Columns.Contains("kode_mapel"))
                    dgvmapel.Columns["kode_mapel"].HeaderText = "Kode";
                if (dgvmapel.Columns.Contains("nama_mapel"))
                    dgvmapel.Columns["nama_mapel"].HeaderText = "Nama Mata Pelajaran";
                if (dgvmapel.Columns.Contains("status"))
                    dgvmapel.Columns["status"].HeaderText = "Status";
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
            idMapel = 0;
            txtkode.Clear();
            txtnama.Clear();
            cmbstatus.SelectedIndex = 0;
            txtkode.Focus();
        }

        // =========================================================
        // KLIK BARIS DI GRID
        // =========================================================
        private void dgvmapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvmapel.Rows[e.RowIndex];

            idMapel = Convert.ToInt32(row.Cells["id_mapel"].Value);
            txtkode.Text     = row.Cells["kode_mapel"].Value?.ToString() ?? "";
            txtnama.Text     = row.Cells["nama_mapel"].Value?.ToString() ?? "";
            cmbstatus.Text   = row.Cells["status"].Value?.ToString()    ?? "";
        }

        // =========================================================
        // SIMPAN
        // =========================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkode.Text) ||
                string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show(
                    "Kode dan nama mata pelajaran wajib diisi!",
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

                    string sql = @"INSERT INTO mapel
                                   (kode_mapel, nama_mapel, status)
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
                    "Data mata pelajaran berhasil disimpan!",
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
                    "Kode mata pelajaran sudah digunakan. Gunakan kode yang berbeda.",
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
        // UBAH
        // =========================================================
        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idMapel == 0)
            {
                MessageBox.Show(
                    "Pilih data mata pelajaran yang ingin diubah!",
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
                    "Kode dan nama mata pelajaran wajib diisi!",
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

                    string sql = @"UPDATE mapel SET
                                   kode_mapel = @kode,
                                   nama_mapel = @nama,
                                   status     = @status
                                   WHERE id_mapel = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode",   txtkode.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@nama",   txtnama.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbstatus.Text);
                        cmd.Parameters.AddWithValue("@id",     idMapel);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data mata pelajaran berhasil diubah!",
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
                    "Kode mata pelajaran sudah digunakan. Gunakan kode yang berbeda.",
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
        // HAPUS
        // =========================================================
        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idMapel == 0)
            {
                MessageBox.Show(
                    "Pilih data mata pelajaran yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data mata pelajaran ini?",
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

                    string sql = "DELETE FROM mapel WHERE id_mapel = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idMapel);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data mata pelajaran berhasil dihapus!",
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
                    "Data mata pelajaran tidak dapat dihapus karena masih\n" +
                    "digunakan pada jadwal pelajaran.",
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

        private void btnbatal_Click(object sender, EventArgs e)
        {
            kosongkan();
        }
    }
}
