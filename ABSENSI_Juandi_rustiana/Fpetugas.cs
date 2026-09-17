using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fpetugas : Form
    {
        public Fpetugas()
        {
            InitializeComponent();
        }

        private void Fpetugas_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));
            lblCountAbsensi.Text = Hitung("SELECT COUNT(*) FROM absensi WHERE tanggal = CURDATE()");
            lblCountSiswa.Text = Hitung("SELECT COUNT(*) FROM siswa");
            lblCountKelas.Text = Hitung("SELECT COUNT(*) FROM kelas");

            cardAbsensi.ShadowDecoration.Parent = cardAbsensi;
            cardSiswa.ShadowDecoration.Parent = cardSiswa;
            cardKelas.ShadowDecoration.Parent = cardKelas;
        }

        private string Hitung(string sql)
        {
            try
            {
                db.crud(sql);
                if (db.ds.Tables.Count > 0 && db.ds.Tables[0].Rows.Count > 0)
                {
                    return db.ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch
            {
            }

            return "0";
        }

        private void Fpetugas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fabsensi halaman = new Fabsensi();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
            "Apakah Anda yakin ingin logout?",
            "Konfirmasi Logout",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
              );

            if (konfirmasi == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();

                this.Hide();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frekapabsensi halaman = new Frekapabsensi();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Flaporan halaman = new Flaporan();
            halaman.Show();
            this.Hide();
        }
    }
}
