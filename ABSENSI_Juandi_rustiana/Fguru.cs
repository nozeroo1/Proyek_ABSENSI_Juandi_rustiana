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
    public partial class Fguru : Form
    {
        public Fguru()
        {
            InitializeComponent();
        }
        private int idGuru = 0;
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

        private void kosongkan()
        {
            idGuru = 0;

            txtnip.Clear();
            txtnama.Clear();
            txttelepon.Clear();

            cmbklmn.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;

            txtnip.Focus();
        }

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

                dgvguru.MultiSelect = false;
                dgvguru.ReadOnly = true;
                dgvguru.AllowUserToAddRows = false;
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

      

        private void dgvguru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvguru.Rows[e.RowIndex];

                idGuru = Convert.ToInt32(
                    row.Cells["id_guru"].Value
                );

                txtnip.Text =
                    row.Cells["nip"].Value.ToString();

                txtnama.Text =
                    row.Cells["nama_guru"].Value.ToString();

                cmbklmn.Text =
                    row.Cells["jenis_kelamin"].Value.ToString();

                txttelepon.Text =
                    row.Cells["no_telp"].Value.ToString();

                cmbstatus.Text =
                    row.Cells["status"].Value.ToString();
            }
        }

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

            if (txtnip.Text == "" || txtnama.Text == "")
            {
                MessageBox.Show(
                    "NIP dan nama guru wajib diisi!",
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

                string sql = @"UPDATE guru SET
                               nip = @nip,
                               nama_guru = @nama,
                               jenis_kelamin = @jk,
                               no_telp = @telp,
                               status = @status
                               WHERE id_guru = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nip",
                    txtnip.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jk",
                    cmbklmn.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@telp",
                    txttelepon.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idGuru
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data guru berhasil diubah!",
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtnip.Text == "" || txtnama.Text == "")
            {
                MessageBox.Show(
                    "NIP dan nama guru wajib diisi!",
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

                string sql = @"INSERT INTO guru
                               (nip, nama_guru, jenis_kelamin, no_telp, status)
                               VALUES
                               (@nip, @nama, @jk, @telp, @status)";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nip",
                    txtnip.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jk",
                    cmbklmn.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@telp",
                    txttelepon.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data guru berhasil disimpan!",
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
                    "DELETE FROM guru WHERE id_guru = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idGuru
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data guru berhasil dihapus!",
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        private void txtnip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnama.Focus();
            }
        }

        private void cmbklmn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
