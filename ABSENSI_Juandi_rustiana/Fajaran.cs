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
    public partial class Fajaran : Form
    {
        private int idAjaran = 0;

        public Fajaran()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Fajaran_Load(object sender, EventArgs e)
        {
            cmbsemester.Items.Clear();
            cmbsemester.Items.Add("Ganjil");
            cmbsemester.Items.Add("Genap");

            // Isi ComboBox Status
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");

            cmbsemester.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;

            tampilData();
        }

        private void kosongkan()
        {
            idAjaran = 0;

            txttahun.Clear();

            cmbsemester.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;

            txttahun.Focus();
        }

        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT
                            id_ajaran,
                            tahun_ajaran,
                            semester,
                            status
                          FROM ajaran
                          ORDER BY id_ajaran DESC");

                dgvajaran.DataSource = db.ds.Tables[0];

                dgvajaran.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvajaran.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvajaran.MultiSelect = false;
                dgvajaran.ReadOnly = true;
                dgvajaran.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data ajaran: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txttahun.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Tahun ajaran wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txttahun.Focus();
                return;
            }

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"INSERT INTO ajaran
                               (
                                   tahun_ajaran,
                                   semester,
                                   status
                               )
                               VALUES
                               (
                                   @tahun,
                                   @semester,
                                   @status
                               )";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@tahun",
                    txttahun.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@semester",
                    cmbsemester.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data ajaran berhasil disimpan!",
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
                    "Gagal menyimpan data ajaran: " + ex.Message,
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

        private void dgvajaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvajaran.Rows[e.RowIndex];

                idAjaran = Convert.ToInt32(
                    row.Cells["id_ajaran"].Value
                );

                txttahun.Text =
                    row.Cells["tahun_ajaran"].Value.ToString();

                cmbsemester.Text =
                    row.Cells["semester"].Value.ToString();

                cmbstatus.Text =
                    row.Cells["status"].Value.ToString();
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idAjaran == 0)
            {
                MessageBox.Show(
                    "Pilih data ajaran yang ingin diubah!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (txttahun.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Tahun ajaran wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txttahun.Focus();
                return;
            }

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"UPDATE ajaran SET
                               tahun_ajaran = @tahun,
                               semester = @semester,
                               status = @status
                               WHERE id_ajaran = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@tahun",
                    txttahun.Text.Trim()
                );

                db.perintah.Parameters.AddWithValue(
                    "@semester",
                    cmbsemester.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@status",
                    cmbstatus.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idAjaran
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data ajaran berhasil diubah!",
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
                    "Gagal mengubah data ajaran: " + ex.Message,
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
            if (idAjaran == 0)
            {
                MessageBox.Show(
                    "Pilih data ajaran yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ajaran ini?",
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
                    "DELETE FROM ajaran WHERE id_ajaran = @id";

                db.perintah = new MySqlCommand(
                    sql,
                    db.koneksi
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idAjaran
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data ajaran berhasil dihapus!",
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
                    "Gagal menghapus data ajaran: " + ex.Message,
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

        private void Fajaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
