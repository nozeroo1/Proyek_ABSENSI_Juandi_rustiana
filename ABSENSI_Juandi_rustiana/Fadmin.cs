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
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fsiswa halaman = new Fsiswa();
            halaman.Show();
            this.Hide();
        }

        private void Fadmin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));
            lblCountSiswa.Text = Hitung("SELECT COUNT(*) FROM siswa");
            lblCountKelas.Text = Hitung("SELECT COUNT(*) FROM kelas");
            lblCountJurusan.Text = Hitung("SELECT COUNT(*) FROM jurusan");
            lblCountGuru.Text = Hitung("SELECT COUNT(*) FROM guru");
            lblCountMapel.Text = Hitung("SELECT COUNT(*) FROM mapel");
            lblCountJadwal.Text = Hitung("SELECT COUNT(*) FROM jadwal");

            cardSiswa.ShadowDecoration.Parent = cardSiswa;
            cardKelas.ShadowDecoration.Parent = cardKelas;
            cardJurusan.ShadowDecoration.Parent = cardJurusan;
            cardGuru.ShadowDecoration.Parent = cardGuru;
            cardMapel.ShadowDecoration.Parent = cardMapel;
            cardJadwal.ShadowDecoration.Parent = cardJadwal;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Fkelas halaman = new Fkelas();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Fjurusan halaman = new Fjurusan();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Fdatapetugas halaman = new Fdatapetugas();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Fguru halaman = new Fguru();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Fmapel halaman = new Fmapel();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Fajaran halaman = new Fajaran();
            halaman.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Fjadwal halaman = new Fjadwal();
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

        private void Fadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
