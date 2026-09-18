using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Fabsensi : Form
    {
        public Fabsensi()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        // =========================================================
        // SETUP DATAGRIDVIEW
        // =========================================================
        private void SetupDataGridView()
        {
            dgvabsensi.Columns.Clear();
            dgvabsensi.AutoGenerateColumns  = false;
            dgvabsensi.AllowUserToAddRows    = false;
            dgvabsensi.AllowUserToDeleteRows = false;
            dgvabsensi.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
            dgvabsensi.MultiSelect           = false;
            dgvabsensi.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;

            // Kolom tersembunyi
            dgvabsensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id_siswa", HeaderText = "ID Siswa",
                Visible = false, ReadOnly = true
            });

            // Kolom data
            dgvabsensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "No", HeaderText = "No", ReadOnly = true
            });
            dgvabsensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NIS", HeaderText = "NIS", ReadOnly = true
            });
            dgvabsensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nama", HeaderText = "Nama Siswa", ReadOnly = true
            });

            // Kolom status (radio-style via checkbox)
            dgvabsensi.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Hadir", HeaderText = "Hadir"
            });
            dgvabsensi.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Izin", HeaderText = "Izin"
            });
            dgvabsensi.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Sakit", HeaderText = "Sakit"
            });
            dgvabsensi.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Alpa", HeaderText = "Alpa"
            });
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void Fabsensi_Load(object sender, EventArgs e)
        {
            dts.Value = DateTime.Now;
            tampilKelas();
        }

        // =========================================================
        // LOAD KELAS
        // =========================================================
        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT id_kelas, nama_kelas
                          FROM kelas
                          WHERE status = 'Aktif'
                          ORDER BY nama_kelas ASC");

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
        // LOAD JADWAL — difilter berdasarkan kelas DAN hari
        // =========================================================
        private void tampilJadwal()
        {
            if (cmbkelas.SelectedValue == null) return;

            try
            {
                // Mapping hari dari DayOfWeek ke nama Indonesia
                string[] namaHari = {
                    "Minggu","Senin","Selasa","Rabu","Kamis","Jumat","Sabtu"
                };
                string hari = namaHari[(int)dts.Value.DayOfWeek];

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT
                                    j.id_jadwal,
                                    CONCAT(
                                        m.nama_mapel,
                                        ' | ',
                                        TIME_FORMAT(j.jam_mulai, '%H:%i'),
                                        ' - ',
                                        TIME_FORMAT(j.jam_selesai, '%H:%i')
                                    ) AS jadwal
                                   FROM jadwal j
                                   INNER JOIN mapel m ON j.id_mapel = m.id_mapel
                                   WHERE j.id_kelas = @id_kelas
                                     AND j.hari     = @hari
                                   ORDER BY j.jam_mulai ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(
                        new MySqlCommand(sql, conn)
                    );
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@id_kelas", cmbkelas.SelectedValue
                    );
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@hari", hari
                    );

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbjadwal.DataSource    = dt;
                    cmbjadwal.DisplayMember = "jadwal";
                    cmbjadwal.ValueMember   = "id_jadwal";
                    cmbjadwal.SelectedIndex = -1;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            $"Tidak ada jadwal untuk hari {hari} pada kelas ini.",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil jadwal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD SISWA
        // =========================================================
        private void tampilSiswa()
        {
            if (cmbkelas.SelectedValue == null) return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT id_siswa, nis, nama_siswa
                                   FROM siswa
                                   WHERE id_kelas = @id_kelas
                                     AND status   = 'Aktif'
                                   ORDER BY nama_siswa ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(
                        new MySqlCommand(sql, conn)
                    );
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@id_kelas", cmbkelas.SelectedValue
                    );

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvabsensi.Rows.Clear();

                    int no = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvabsensi.Rows.Add(
                            row["id_siswa"].ToString(),
                            no,
                            row["nis"].ToString(),
                            row["nama_siswa"].ToString(),
                            false, false, false, false
                        );
                        no++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data siswa: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // KELAS BERUBAH
        // =========================================================
        private void cmbkelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedIndex == -1) return;
            tampilJadwal();
            dgvabsensi.Rows.Clear();
        }

        // =========================================================
        // JADWAL BERUBAH
        // =========================================================
        private void cmbjadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjadwal.SelectedIndex == -1) return;
            tampilSiswa();
        }

        // =========================================================
        // TANGGAL BERUBAH — refresh jadwal
        // =========================================================
        private void dts_ValueChanged(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedValue != null)
            {
                tampilJadwal();
                dgvabsensi.Rows.Clear();
            }
        }

        // =========================================================
        // KLIK CHECKBOX — radio-style (satu status per baris)
        // =========================================================
        private void dgvabsensi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 3) return;

            DataGridViewRow row  = dgvabsensi.Rows[e.RowIndex];
            string          kolom = dgvabsensi.Columns[e.ColumnIndex].Name;

            row.Cells["Hadir"].Value = false;
            row.Cells["Izin"].Value  = false;
            row.Cells["Sakit"].Value = false;
            row.Cells["Alpa"].Value  = false;

            row.Cells[kolom].Value = true;
        }

        // =========================================================
        // HADIR SEMUA
        // =========================================================
        private void btnhadir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvabsensi.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["Hadir"].Value = true;
                row.Cells["Izin"].Value  = false;
                row.Cells["Sakit"].Value = false;
                row.Cells["Alpa"].Value  = false;
            }
        }

        // =========================================================
        // SIMPAN — dengan transaksi dan ON DUPLICATE KEY UPDATE
        // =========================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih kelas terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbjadwal.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih jadwal terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvabsensi.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada data siswa di kelas ini!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi semua siswa sudah dipilih statusnya
            foreach (DataGridViewRow row in dgvabsensi.Rows)
            {
                if (row.IsNewRow) continue;

                bool hadir = Convert.ToBoolean(row.Cells["Hadir"].Value);
                bool izin  = Convert.ToBoolean(row.Cells["Izin"].Value);
                bool sakit = Convert.ToBoolean(row.Cells["Sakit"].Value);
                bool alpa  = Convert.ToBoolean(row.Cells["Alpa"].Value);

                if (!hadir && !izin && !sakit && !alpa)
                {
                    MessageBox.Show(
                        "Status absensi belum dipilih untuk siswa: " +
                        row.Cells["Nama"].Value.ToString(),
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            // Simpan dalam satu transaksi
            MySqlTransaction transaksi = null;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    transaksi = conn.BeginTransaction();

                    // INSERT ... ON DUPLICATE KEY UPDATE → aman untuk submit ulang
                    string sql = @"INSERT INTO absensi
                                   (tanggal, id_jadwal, id_siswa, status)
                                   VALUES (@tanggal, @id_jadwal, @id_siswa, @status)
                                   ON DUPLICATE KEY UPDATE status = @status";

                    foreach (DataGridViewRow row in dgvabsensi.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string status = "";
                        if (Convert.ToBoolean(row.Cells["Hadir"].Value)) status = "Hadir";
                        else if (Convert.ToBoolean(row.Cells["Izin"].Value))  status = "Izin";
                        else if (Convert.ToBoolean(row.Cells["Sakit"].Value)) status = "Sakit";
                        else if (Convert.ToBoolean(row.Cells["Alpa"].Value))  status = "Alpa";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn, transaksi))
                        {
                            cmd.Parameters.AddWithValue("@tanggal",   dts.Value.Date);
                            cmd.Parameters.AddWithValue("@id_jadwal", cmbjadwal.SelectedValue);
                            cmd.Parameters.AddWithValue("@id_siswa",
                                Convert.ToInt32(row.Cells["id_siswa"].Value));
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaksi.Commit();
                }

                MessageBox.Show("Absensi berhasil disimpan!",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvabsensi.Rows.Clear();
                cmbkelas.SelectedIndex  = -1;
                cmbjadwal.DataSource    = null;
            }
            catch (Exception ex)
            {
                try { transaksi?.Rollback(); } catch { }

                MessageBox.Show(
                    "Gagal menyimpan absensi: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // EVENT KOSONG
        // =========================================================
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }

        // =========================================================
        // FORM CLOSING & KEMBALI
        // =========================================================
        private void Fabsensi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fpetugas halaman = new Fpetugas();
            halaman.Show();
            this.Hide();
        }
    }
}
