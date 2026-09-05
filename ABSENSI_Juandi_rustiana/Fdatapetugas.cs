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
    public partial class Fdatapetugas : Form
    {
        public Fdatapetugas()
        {
            InitializeComponent();
        }
        private int idUser = 0;
        private void Fdatapetugas_Load(object sender, EventArgs e)
        {
            cmbrole.Items.Clear();
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Petugas");

            cmbrole.SelectedIndex = 1;

            tampilData();
        }

        private void kosongkan()
        {
            idUser = 0;

            txtnama.Clear();
            txtuser.Clear();
            txtpas.Clear();

            cmbrole.SelectedIndex = 1;

            txtnama.Focus();
        }

        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT 
                            id_user,
                            nama,
                            username,
                            role
                          FROM users
                          ORDER BY id_user DESC");

                dgvdaftarpetu.DataSource = db.ds.Tables[0];

                dgvdaftarpetu.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvdaftarpetu.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvdaftarpetu.MultiSelect = false;
                dgvdaftarpetu.ReadOnly = true;
                dgvdaftarpetu.AllowUserToAddRows = false;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "" ||
               txtuser.Text == "" ||
               txtpas.Text == "" ||
               cmbrole.Text == "")
            {
                MessageBox.Show(
                    "Semua data wajib diisi!",
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

                string sql = @"INSERT INTO users
                               (nama, username, password, role)
                               VALUES
                               (@nama, @username, @password, @role)";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@username",
                    txtuser.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@password",
                    txtpas.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@role",
                    cmbrole.Text.ToLower()
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data petugas berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Username sudah digunakan!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Gagal menyimpan data: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (idUser == 0)
            {
                MessageBox.Show(
                    "Pilih data yang ingin diubah terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (txtnama.Text == "" ||
                txtuser.Text == "" ||
                cmbrole.Text == "")
            {
                MessageBox.Show(
                    "Nama, username, dan role wajib diisi!",
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

                string sql;

                if (txtpas.Text == "")
                {
                    sql = @"UPDATE users SET
                            nama = @nama,
                            username = @username,
                            role = @role
                            WHERE id_user = @id";
                }
                else
                {
                    sql = @"UPDATE users SET
                            nama = @nama,
                            username = @username,
                            password = @password,
                            role = @role
                            WHERE id_user = @id";
                }

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtnama.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@username",
                    txtuser.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@role",
                    cmbrole.Text.ToLower()
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idUser
                );

                if (txtpas.Text != "")
                {
                    db.perintah.Parameters.AddWithValue(
                        "@password",
                        txtpas.Text
                    );
                }

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data petugas berhasil diubah!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Username sudah digunakan!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Gagal mengubah data: " + ex.Message
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data: " + ex.Message
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
            if (idUser == 0)
            {
                MessageBox.Show(
                    "Pilih data yang ingin dihapus terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data petugas ini?",
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
                    "DELETE FROM users WHERE id_user = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idUser
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data petugas berhasil dihapus!",
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }
    }
}
    

