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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNLOG_Click(object sender, EventArgs e)
        {
            db.crud($"select * from users where username = '{textBox1.Text}' && password = '{textBox2.Text}'");

            int cekbaris = db.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                string nama = db.ds.Tables[0].Rows[0]["nama"].ToString();
                string role = db.ds.Tables[0].Rows[0]["role"].ToString();
             
                if (role == "admin")
                {
                    Fadmin halaman = new Fadmin();
                    halaman.Show();
                    this.Hide();
                }else if (role == "petugas")
                {
                    Fpetugas halaman = new Fpetugas();
                    halaman.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("username/password salah");
            }





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
