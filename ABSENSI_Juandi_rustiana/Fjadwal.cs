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
    public partial class Fjadwal : Form
    {
        private int idJadwal = 0;

        public Fjadwal()
        {
            InitializeComponent();
        }

        private void Fjadwal_Load(object sender, EventArgs e)
        {
            cmbhari.Items.Clear();

            cmbhari.Items.Add("Senin");
            cmbhari.Items.Add("Selasa");
            cmbhari.Items.Add("Rabu");
            cmbhari.Items.Add("Kamis");
            cmbhari.Items.Add("Jumat");
            cmbhari.Items.Add("Sabtu");

            cmbhari.SelectedIndex = 0;

         

            dtmulai.Format =
                DateTimePickerFormat.Time;

            dtmulai.ShowUpDown = true;

            dtselesai.Format =
                DateTimePickerFormat.Time;

            dtselesai.ShowUpDown = true;

            dtmulai.Value =
                DateTime.Today.AddHours(7);

            dtselesai.Value =
                DateTime.Today.AddHours(8);

          

            tampilKelas();
            tampilMapel();
            tampilGuru();

       

            tampilData();
        }

        private void kosongkan()
        {
            idJadwal = 0;

            cmbhari.SelectedIndex = 0;

            dtmulai.Value =
                DateTime.Today.AddHours(7);

            dtselesai.Value =
                DateTime.Today.AddHours(8);

            if (cmbkelas.Items.Count > 0)
                cmbkelas.SelectedIndex = 0;

            if (cmbmapel.Items.Count > 0)
                cmbmapel.SelectedIndex = 0;

            if (cmbguru.Items.Count > 0)
                cmbguru.SelectedIndex = 0;
        }

        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT
                    k.id_kelas,
                    CONCAT(k.nama_kelas, ' - ', j.kode_jurusan) AS nama_kelas
                  FROM kelas k
                  INNER JOIN jurusan j
                      ON k.id_jurusan = j.id_jurusan
                  WHERE k.status = 'Aktif'
                    AND j.status = 'Aktif'
                  ORDER BY k.tingkat, k.nama_kelas ASC");

                cmbkelas.DataSource = db.ds.Tables[0];
                cmbkelas.DisplayMember = "nama_kelas";
                cmbkelas.ValueMember = "id_kelas";
                cmbkelas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data kelas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void tampilMapel()
        {
            try
            {
                db.crud(@"SELECT
                            id_mapel,
                            nama_mapel
                          FROM mapel
                          WHERE status = 'Aktif'
                          ORDER BY nama_mapel ASC");

                cmbmapel.DataSource =
                    db.ds.Tables[0];

                cmbmapel.DisplayMember =
                    "nama_mapel";

                cmbmapel.ValueMember =
                    "id_mapel";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data mata pelajaran: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void tampilGuru()
        {
            try
            {
                db.crud(@"SELECT
                            id_guru,
                            nama_guru
                          FROM guru
                          WHERE status = 'Aktif'
                          ORDER BY nama_guru ASC");

                cmbguru.DataSource =
                    db.ds.Tables[0];

                cmbguru.DisplayMember =
                    "nama_guru";

                cmbguru.ValueMember =
                    "id_guru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data guru: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT
                    j.id_jadwal,
                    j.hari,
                    j.jam_mulai,
                    j.jam_selesai,

                    j.id_kelas,
                    j.id_mapel,
                    j.id_guru,

                    k.nama_kelas,
                    k.tingkat,

                    jr.kode_jurusan,
                    jr.nama_jurusan,

                    m.nama_mapel,
                    g.nama_guru

                  FROM jadwal j

                  INNER JOIN kelas k
                      ON j.id_kelas = k.id_kelas

                  INNER JOIN jurusan jr
                      ON k.id_jurusan = jr.id_jurusan

                  INNER JOIN mapel m
                      ON j.id_mapel = m.id_mapel

                  INNER JOIN guru g
                      ON j.id_guru = g.id_guru

                  ORDER BY
                      FIELD(
                          j.hari,
                          'Senin',
                          'Selasa',
                          'Rabu',
                          'Kamis',
                          'Jumat',
                          'Sabtu'
                      ),
                      j.jam_mulai");

                dgvjadwal.DataSource = db.ds.Tables[0];

                dgvjadwal.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvjadwal.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvjadwal.MultiSelect = false;
                dgvjadwal.ReadOnly = true;
                dgvjadwal.AllowUserToAddRows = false;

                dgvjadwal.Columns["id_jadwal"].Visible = false;
                dgvjadwal.Columns["id_kelas"].Visible = false;
                dgvjadwal.Columns["id_mapel"].Visible = false;
                dgvjadwal.Columns["id_guru"].Visible = false;

                dgvjadwal.Columns["hari"].HeaderText = "Hari";
                dgvjadwal.Columns["jam_mulai"].HeaderText = "Mulai";
                dgvjadwal.Columns["jam_selesai"].HeaderText = "Selesai";
                dgvjadwal.Columns["kode_jurusan"].HeaderText = "Jurusan";
                dgvjadwal.Columns["nama_kelas"].HeaderText = "Kelas";
                dgvjadwal.Columns["tingkat"].HeaderText = "Tingkat";
                dgvjadwal.Columns["nama_mapel"].HeaderText = "Mata Pelajaran";
                dgvjadwal.Columns["nama_guru"].HeaderText = "Guru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data jadwal: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedValue == null ||
               cmbmapel.SelectedValue == null ||
               cmbguru.SelectedValue == null)
            {
                MessageBox.Show(
                    "Kelas, mata pelajaran, dan guru wajib dipilih!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (dtselesai.Value.TimeOfDay <=
                dtmulai.Value.TimeOfDay)
            {
                MessageBox.Show(
                    "Jam selesai harus lebih besar dari jam mulai!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                if (db.koneksi.State ==
                    ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"INSERT INTO jadwal
                               (
                                   hari,
                                   jam_mulai,
                                   jam_selesai,
                                   id_kelas,
                                   id_mapel,
                                   id_guru
                               )
                               VALUES
                               (
                                   @hari,
                                   @jam_mulai,
                                   @jam_selesai,
                                   @id_kelas,
                                   @id_mapel,
                                   @id_guru
                               )";

                db.perintah =
                    new MySqlCommand(
                        sql,
                        db.koneksi
                    );

                db.perintah.Parameters.AddWithValue(
                    "@hari",
                    cmbhari.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jam_mulai",
                    dtmulai.Value.ToString("HH:mm:ss")
                );

                db.perintah.Parameters.AddWithValue(
                    "@jam_selesai",
                    dtselesai.Value.ToString("HH:mm:ss")
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbkelas.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_mapel",
                    cmbmapel.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_guru",
                    cmbguru.SelectedValue
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data jadwal berhasil disimpan!",
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
                    "Gagal menyimpan data jadwal: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State ==
                    ConnectionState.Open)
                {
                    db.koneksi.Close();
                }
            }
        }

        private void dgvjadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvjadwal.Rows[e.RowIndex];

                idJadwal =
                    Convert.ToInt32(
                        row.Cells["id_jadwal"].Value
                    );

                cmbhari.Text =
                    row.Cells["hari"].Value.ToString();

                // Ambil jam mulai
                TimeSpan jamMulai;

                if (row.Cells["jam_mulai"].Value
                    is TimeSpan)
                {
                    jamMulai =
                        (TimeSpan)row.Cells["jam_mulai"].Value;
                }
                else
                {
                    jamMulai =
                        TimeSpan.Parse(
                            row.Cells["jam_mulai"]
                                .Value.ToString()
                        );
                }

                dtmulai.Value =
                    DateTime.Today.Add(jamMulai);

                // Ambil jam selesai
                TimeSpan jamSelesai;

                if (row.Cells["jam_selesai"].Value
                    is TimeSpan)
                {
                    jamSelesai =
                        (TimeSpan)row.Cells["jam_selesai"].Value;
                }
                else
                {
                    jamSelesai =
                        TimeSpan.Parse(
                            row.Cells["jam_selesai"]
                                .Value.ToString()
                        );
                }

                dtselesai.Value =
                    DateTime.Today.Add(jamSelesai);

                cmbkelas.SelectedValue =
                    row.Cells["id_kelas"].Value;

                cmbmapel.SelectedValue =
                    row.Cells["id_mapel"].Value;

                cmbguru.SelectedValue =
                    row.Cells["id_guru"].Value;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (idJadwal == 0)
            {
                MessageBox.Show(
                    "Pilih data jadwal yang ingin diubah!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbkelas.SelectedValue == null ||
                cmbmapel.SelectedValue == null ||
                cmbguru.SelectedValue == null)
            {
                MessageBox.Show(
                    "Kelas, mata pelajaran, dan guru wajib dipilih!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (dtselesai.Value.TimeOfDay <=
                dtmulai.Value.TimeOfDay)
            {
                MessageBox.Show(
                    "Jam selesai harus lebih besar dari jam mulai!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                if (db.koneksi.State ==
                    ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql = @"UPDATE jadwal SET
                               hari = @hari,
                               jam_mulai = @jam_mulai,
                               jam_selesai = @jam_selesai,
                               id_kelas = @id_kelas,
                               id_mapel = @id_mapel,
                               id_guru = @id_guru
                               WHERE id_jadwal = @id";

                db.perintah =
                    new MySqlCommand(
                        sql,
                        db.koneksi
                    );

                db.perintah.Parameters.AddWithValue(
                    "@hari",
                    cmbhari.Text
                );

                db.perintah.Parameters.AddWithValue(
                    "@jam_mulai",
                    dtmulai.Value.ToString("HH:mm:ss")
                );

                db.perintah.Parameters.AddWithValue(
                    "@jam_selesai",
                    dtselesai.Value.ToString("HH:mm:ss")
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbkelas.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_mapel",
                    cmbmapel.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@id_guru",
                    cmbguru.SelectedValue
                );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idJadwal
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data jadwal berhasil diubah!",
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
                    "Gagal mengubah data jadwal: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State ==
                    ConnectionState.Open)
                {
                    db.koneksi.Close();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (idJadwal == 0)
            {
                MessageBox.Show(
                    "Pilih data jadwal yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult konfirmasi =
                MessageBox.Show(
                    "Yakin ingin menghapus data jadwal ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (konfirmasi !=
                DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (db.koneksi.State ==
                    ConnectionState.Closed)
                {
                    db.koneksi.Open();
                }

                string sql =
                    "DELETE FROM jadwal " +
                    "WHERE id_jadwal = @id";

                db.perintah =
                    new MySqlCommand(
                        sql,
                        db.koneksi
                    );

                db.perintah.Parameters.AddWithValue(
                    "@id",
                    idJadwal
                );

                db.perintah.ExecuteNonQuery();

                MessageBox.Show(
                    "Data jadwal berhasil dihapus!",
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
                    "Gagal menghapus data jadwal: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State ==
                    ConnectionState.Open)
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
