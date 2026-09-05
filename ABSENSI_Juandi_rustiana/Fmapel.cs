using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Fmapel_Load(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");

            cmbstatus.SelectedIndex = 0;

            tampilData();
        }

        private void kosongkan()
        {
            idMapel = 0;

            txtkode.Clear();
            txtnama.Clear();

            cmbstatus.SelectedIndex = 0;

            txtkode.Focus();
        }

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

                dgvmapel.DataSource = db.ds.Tables[0];

                dgvmapel.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvmapel.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvmapel.MultiSelect = false;
                dgvmapel.ReadOnly = true;
                dgvmapel.AllowUserToAddRows = false;
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

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtkode.Text == "" || txtnama.Text == "")
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
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"INSERT INTO mapel
                               (kode_mapel, nama_mapel, status)
                               VALUES
                               (@kode, @nama, @status)";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@kode",
                    txtkode.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data mata pelajaran berhasil disimpan!",
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

        private void dgvmapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvmapel.Rows[e.RowIndex];

                idMapel = Convert.ToInt32(
                    row.Cells["id_mapel"].Value
                );

                txtkode.Text =
                    row.Cells["kode_mapel"].Value.ToString();

                txtnama.Text =
                    row.Cells["nama_mapel"].Value.ToString();

                cmbstatus.Text =
                    row.Cells["status"].Value.ToString();
            }
        }

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

            if (txtkode.Text == "" || txtnama.Text == "")
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
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"UPDATE mapel SET
                               kode_mapel = @kode,
                               nama_mapel = @nama,
                               status = @status
                               WHERE id_mapel = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@kode",
                    txtkode.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idMapel
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data mata pelajaran berhasil diubah!",
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
                    "DELETE FROM mapel WHERE id_mapel = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idMapel
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data mata pelajaran berhasil dihapus!",
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
