using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        // =========================================================
        // LOGIN — parameterized query (tidak ada SQL Injection)
        // =========================================================
        private void BTNLOG_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Username dan password wajib diisi!",
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

                    // Parameterized query — aman dari SQL Injection
                    string sql = @"SELECT id_user, nama, role
                                   FROM users
                                   WHERE username = @username
                                     AND password = @password
                                   LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();

                                if (role == "admin")
                                {
                                    Fadmin halaman = new Fadmin();
                                    halaman.Show();
                                    this.Hide();
                                }
                                else if (role == "petugas")
                                {
                                    Fpetugas halaman = new Fpetugas();
                                    halaman.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "Role tidak dikenali. Hubungi administrator.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Username atau password salah!",
                                    "Login Gagal",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                textBox2.Clear();
                                textBox2.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal terhubung ke database: " + ex.Message,
                    "Error Koneksi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && textBox1.Text != "")
            {
                textBox2.Select();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BTNLOG.PerformClick();
            }
        }

        private void BTNLOG_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
