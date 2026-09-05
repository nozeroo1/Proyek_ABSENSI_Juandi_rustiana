using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
