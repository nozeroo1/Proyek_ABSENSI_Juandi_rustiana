using System;
using System.Data;
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

        // =========================================================
        // FORM LOAD
        // =========================================================
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

            dtmulai.Format    = DateTimePickerFormat.Time;
            dtmulai.ShowUpDown  = true;
            dtselesai.Format  = DateTimePickerFormat.Time;
            dtselesai.ShowUpDown = true;
            dtmulai.Value   = DateTime.Today.AddHours(7);
            dtselesai.Value = DateTime.Today.AddHours(8);

            tampilAjaran();
            tampilKelas();
            tampilMapel();
            tampilGuru();
            tampilData();
        }

        // =========================================================
        // LOAD TAHUN AJARAN
        // =========================================================
        private void tampilAjaran()
        {
            try
            {
                db.crud(@"SELECT
                            id_ajaran,
                            CONCAT(tahun_ajaran, ' - ', semester) AS label_ajaran
                          FROM ajaran
                          WHERE status = 'Aktif'
                          ORDER BY id_ajaran DESC");

                cmbajaran.DataSource    = db.ds.Tables[0];
                cmbajaran.DisplayMember = "label_ajaran";
                cmbajaran.ValueMember   = "id_ajaran";

                // Pilih ajaran aktif pertama secara default
                if (cmbajaran.Items.Count > 0)
                    cmbajaran.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data tahun ajaran: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD KELAS
        // =========================================================
        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT
                            k.id_kelas,
                            CONCAT(k.nama_kelas, ' - ', j.kode_jurusan) AS nama_kelas
                          FROM kelas k
                          INNER JOIN jurusan j ON k.id_jurusan = j.id_jurusan
                          WHERE k.status = 'Aktif'
                            AND j.status = 'Aktif'
                          ORDER BY k.tingkat, k.nama_kelas ASC");

                cmbkelas.DataSource    = db.ds.Tables[0];
                cmbkelas.DisplayMember = "nama_kelas";
                cmbkelas.ValueMember   = "id_kelas";
                cmbkelas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data kelas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD MAPEL
        // =========================================================
        private void tampilMapel()
        {
            try
            {
                db.crud(@"SELECT id_mapel, nama_mapel
                          FROM mapel
                          WHERE status = 'Aktif'
                          ORDER BY nama_mapel ASC");

                cmbmapel.DataSource    = db.ds.Tables[0];
                cmbmapel.DisplayMember = "nama_mapel";
                cmbmapel.ValueMember   = "id_mapel";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data mata pelajaran: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD GURU
        // =========================================================
        private void tampilGuru()
        {
            try
            {
                db.crud(@"SELECT id_guru, nama_guru
                          FROM guru
                          WHERE status = 'Aktif'
                          ORDER BY nama_guru ASC");

                cmbguru.DataSource    = db.ds.Tables[0];
                cmbguru.DisplayMember = "nama_guru";
                cmbguru.ValueMember   = "id_guru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data guru: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // TAMPIL DATA JADWAL
        // =========================================================
        private void tampilData()
        {
            try
            {
                db.crud(@"SELECT
                            j.id_jadwal,
                            j.id_ajaran,
                            j.id_kelas,
                            j.id_mapel,
                            j.id_guru,
                            CONCAT(a.tahun_ajaran, ' - ', a.semester) AS tahun_ajaran,
                            j.hari,
                            j.jam_mulai,
                            j.jam_selesai,
                            k.nama_kelas,
                            k.tingkat,
                            jr.kode_jurusan,
                            m.nama_mapel,
                            g.nama_guru
                          FROM jadwal j
                          INNER JOIN ajaran a  ON j.id_ajaran = a.id_ajaran
                          INNER JOIN kelas k   ON j.id_kelas  = k.id_kelas
                          INNER JOIN jurusan jr ON k.id_jurusan = jr.id_jurusan
                          INNER JOIN mapel m   ON j.id_mapel  = m.id_mapel
                          INNER JOIN guru g    ON j.id_guru   = g.id_guru
                          ORDER BY
                            FIELD(j.hari,'Senin','Selasa','Rabu','Kamis','Jumat','Sabtu'),
                            j.jam_mulai");

                dgvjadwal.DataSource = db.ds.Tables[0];

                dgvjadwal.AutoSizeColumnsMode  = DataGridViewAutoSizeColumnsMode.Fill;
                dgvjadwal.SelectionMode        = DataGridViewSelectionMode.FullRowSelect;
                dgvjadwal.MultiSelect          = false;
                dgvjadwal.ReadOnly             = true;
                dgvjadwal.AllowUserToAddRows   = false;

                // Sembunyikan kolom ID
                foreach (string col in new[] {
                    "id_jadwal", "id_ajaran", "id_kelas", "id_mapel", "id_guru"
                })
                {
                    if (dgvjadwal.Columns.Contains(col))
                        dgvjadwal.Columns[col].Visible = false;
                }

                if (dgvjadwal.Columns.Contains("tahun_ajaran"))
                    dgvjadwal.Columns["tahun_ajaran"].HeaderText = "Tahun Ajaran";
                if (dgvjadwal.Columns.Contains("hari"))
                    dgvjadwal.Columns["hari"].HeaderText = "Hari";
                if (dgvjadwal.Columns.Contains("jam_mulai"))
                    dgvjadwal.Columns["jam_mulai"].HeaderText = "Mulai";
                if (dgvjadwal.Columns.Contains("jam_selesai"))
                    dgvjadwal.Columns["jam_selesai"].HeaderText = "Selesai";
                if (dgvjadwal.Columns.Contains("kode_jurusan"))
                    dgvjadwal.Columns["kode_jurusan"].HeaderText = "Jurusan";
                if (dgvjadwal.Columns.Contains("nama_kelas"))
                    dgvjadwal.Columns["nama_kelas"].HeaderText = "Kelas";
                if (dgvjadwal.Columns.Contains("tingkat"))
                    dgvjadwal.Columns["tingkat"].HeaderText = "Tingkat";
                if (dgvjadwal.Columns.Contains("nama_mapel"))
                    dgvjadwal.Columns["nama_mapel"].HeaderText = "Mata Pelajaran";
                if (dgvjadwal.Columns.Contains("nama_guru"))
                    dgvjadwal.Columns["nama_guru"].HeaderText = "Guru";
                if (dgvjadwal.Columns.Contains("nama_jurusan"))
                    dgvjadwal.Columns["nama_jurusan"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // KOSONGKAN FORM
        // =========================================================
        private void kosongkan()
        {
            idJadwal = 0;
            cmbhari.SelectedIndex = 0;
            dtmulai.Value   = DateTime.Today.AddHours(7);
            dtselesai.Value = DateTime.Today.AddHours(8);

            if (cmbajaran.Items.Count > 0) cmbajaran.SelectedIndex = 0;
            if (cmbkelas.Items.Count  > 0) cmbkelas.SelectedIndex  = 0;
            if (cmbmapel.Items.Count  > 0) cmbmapel.SelectedIndex  = 0;
            if (cmbguru.Items.Count   > 0) cmbguru.SelectedIndex   = 0;
        }

        // =========================================================
        // SIMPAN (guna2Button1)
        // =========================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!validasiForm()) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO jadwal
                                   (id_ajaran, hari, jam_mulai, jam_selesai,
                                    id_kelas, id_mapel, id_guru)
                                   VALUES
                                   (@id_ajaran, @hari, @mulai, @selesai,
                                    @id_kelas, @id_mapel, @id_guru)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        isiParameter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data jadwal berhasil disimpan!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // UBAH (guna2Button2)
        // =========================================================
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (idJadwal == 0)
            {
                MessageBox.Show("Pilih data jadwal yang ingin diubah!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validasiForm()) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE jadwal SET
                                   id_ajaran   = @id_ajaran,
                                   hari        = @hari,
                                   jam_mulai   = @mulai,
                                   jam_selesai = @selesai,
                                   id_kelas    = @id_kelas,
                                   id_mapel    = @id_mapel,
                                   id_guru     = @id_guru
                                   WHERE id_jadwal = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        isiParameter(cmd);
                        cmd.Parameters.AddWithValue("@id", idJadwal);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data jadwal berhasil diubah!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // HAPUS (guna2Button3)
        // =========================================================
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (idJadwal == 0)
            {
                MessageBox.Show("Pilih data jadwal yang ingin dihapus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data jadwal ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM jadwal WHERE id_jadwal = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idJadwal);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data jadwal berhasil dihapus!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosongkan();
                tampilData();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show(
                    "Data jadwal tidak dapat dihapus karena masih\n" +
                    "memiliki data absensi.",
                    "Tidak Dapat Dihapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // KLIK BARIS DI GRID
        // =========================================================
        private void dgvjadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvjadwal.Rows[e.RowIndex];

            idJadwal = Convert.ToInt32(row.Cells["id_jadwal"].Value);

            cmbhari.Text = row.Cells["hari"].Value.ToString();

            // Jam mulai
            TimeSpan jamMulai = row.Cells["jam_mulai"].Value is TimeSpan
                ? (TimeSpan)row.Cells["jam_mulai"].Value
                : TimeSpan.Parse(row.Cells["jam_mulai"].Value.ToString());
            dtmulai.Value = DateTime.Today.Add(jamMulai);

            // Jam selesai
            TimeSpan jamSelesai = row.Cells["jam_selesai"].Value is TimeSpan
                ? (TimeSpan)row.Cells["jam_selesai"].Value
                : TimeSpan.Parse(row.Cells["jam_selesai"].Value.ToString());
            dtselesai.Value = DateTime.Today.Add(jamSelesai);

            // Tahun ajaran
            if (row.Cells["id_ajaran"].Value != null &&
                row.Cells["id_ajaran"].Value != DBNull.Value)
                cmbajaran.SelectedValue =
                    Convert.ToInt32(row.Cells["id_ajaran"].Value);

            cmbkelas.SelectedValue =
                Convert.ToInt32(row.Cells["id_kelas"].Value);
            cmbmapel.SelectedValue =
                Convert.ToInt32(row.Cells["id_mapel"].Value);
            cmbguru.SelectedValue  =
                Convert.ToInt32(row.Cells["id_guru"].Value);
        }

        // =========================================================
        // BATAL
        // =========================================================
        private void btnbatal_Click(object sender, EventArgs e)
        {
            kosongkan();
        }

        // =========================================================
        // KEMBALI
        // =========================================================
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Fadmin halaman = new Fadmin();
            halaman.Show();
            this.Hide();
        }

        // =========================================================
        // HELPER — validasi form
        // =========================================================
        private bool validasiForm()
        {
            if (cmbajaran.SelectedValue == null)
            {
                MessageBox.Show("Tahun ajaran wajib dipilih!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbkelas.SelectedValue == null ||
                cmbmapel.SelectedValue == null ||
                cmbguru.SelectedValue  == null)
            {
                MessageBox.Show("Kelas, mata pelajaran, dan guru wajib dipilih!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtselesai.Value.TimeOfDay <= dtmulai.Value.TimeOfDay)
            {
                MessageBox.Show("Jam selesai harus lebih besar dari jam mulai!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // =========================================================
        // HELPER — isi parameter query
        // =========================================================
        private void isiParameter(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id_ajaran", cmbajaran.SelectedValue);
            cmd.Parameters.AddWithValue("@hari",      cmbhari.Text);
            cmd.Parameters.AddWithValue("@mulai",     dtmulai.Value.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@selesai",   dtselesai.Value.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@id_kelas",  cmbkelas.SelectedValue);
            cmd.Parameters.AddWithValue("@id_mapel",  cmbmapel.SelectedValue);
            cmd.Parameters.AddWithValue("@id_guru",   cmbguru.SelectedValue);
        }
    }
}
