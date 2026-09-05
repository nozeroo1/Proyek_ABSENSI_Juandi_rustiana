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
    public partial class Fjurusan : Form
    {
        public Fjurusan()
        {
            InitializeComponent();
        }

        private void Fjurusan_Load(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Nonaktif");

            cmbstatus.SelectedIndex = 0;

            tampilData();
        }

        private void kosongkan()
        {
            txtkode.Clear();
            txtnama.Clear();

            cmbstatus.SelectedIndex = 0;

            txtkode.Focus();
        }

        private void tampilData()
        {
            try
            {
                db.crud("SELECT * FROM jurusan ORDER BY id_jurusan DESC");

                dgvjurusan.DataSource = db.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

       
            
        

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvjurusan.Rows[e.RowIndex];

                txtkode.Text = row.Cells["kode_jurusan"].Value.ToString();
                txtnama.Text = row.Cells["nama_jurusan"].Value.ToString();
                cmbstatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (txtkode.Text == "" || txtnama.Text == "")
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
                if (db.koneksi.State == ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"INSERT INTO jurusan
                       (kode_jurusan, nama_jurusan, status)
                       VALUES
                       (@kode, @nama, @status)";

                db.perintah = new MySqlCommand(sql, db.koneksi);

                db.perintah.Parameters.AddWithValue("@kode", txtkode.Text);
                db.perintah.Parameters.AddWithValue("@nama", txtnama.Text);
                db.perintah.Parameters.AddWithValue("@status", cmbstatus.Text);

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data jurusan berhasil disimpan!",
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

        private void btnkosongkan_Click(object sender, EventArgs e)
        {
            kosongkan();
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
