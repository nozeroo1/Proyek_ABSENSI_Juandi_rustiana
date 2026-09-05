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
    public partial class Fabsensi : Form
    {
        public Fabsensi()
        {
            InitializeComponent();

            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvabsensi.Columns.Clear();

            dgvabsensi.AutoGenerateColumns = false;
            dgvabsensi.AllowUserToAddRows = false;
            dgvabsensi.AllowUserToDeleteRows = false;
            dgvabsensi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvabsensi.MultiSelect = false;
            dgvabsensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn idSiswa =
            new DataGridViewTextBoxColumn();

            idSiswa.Name = "id_siswa";
            idSiswa.HeaderText = "ID Siswa";
            idSiswa.Visible = false;
            idSiswa.ReadOnly = true;

            dgvabsensi.Columns.Add(idSiswa);


            // Kolom No
            DataGridViewTextBoxColumn no = new DataGridViewTextBoxColumn();
            no.Name = "No";
            no.HeaderText = "No";
            no.ReadOnly = true;

            // Kolom NIS
            DataGridViewTextBoxColumn nis = new DataGridViewTextBoxColumn();
            nis.Name = "NIS";
            nis.HeaderText = "NIS";
            nis.ReadOnly = true;

            // Kolom Nama
            DataGridViewTextBoxColumn nama = new DataGridViewTextBoxColumn();
            nama.Name = "Nama";
            nama.HeaderText = "Nama Siswa";
            nama.ReadOnly = true;

            // Kolom Hadir
            DataGridViewCheckBoxColumn hadir = new DataGridViewCheckBoxColumn();
            hadir.Name = "Hadir";
            hadir.HeaderText = "Hadir";

            // Kolom Izin
            DataGridViewCheckBoxColumn izin = new DataGridViewCheckBoxColumn();
            izin.Name = "Izin";
            izin.HeaderText = "Izin";

            // Kolom Sakit
            DataGridViewCheckBoxColumn sakit = new DataGridViewCheckBoxColumn();
            sakit.Name = "Sakit";
            sakit.HeaderText = "Sakit";

            // Kolom Alpa
            DataGridViewCheckBoxColumn alpa = new DataGridViewCheckBoxColumn();
            alpa.Name = "Alpa";
            alpa.HeaderText = "Alpa";

            dgvabsensi.Columns.Add(no);
            dgvabsensi.Columns.Add(nis);
            dgvabsensi.Columns.Add(nama);
            dgvabsensi.Columns.Add(hadir);
            dgvabsensi.Columns.Add(izin);
            dgvabsensi.Columns.Add(sakit);
            dgvabsensi.Columns.Add(alpa);
        }

        private void tampilKelas()
        {
            try
            {
                db.crud(@"SELECT 
                    id_kelas,
                    nama_kelas
                  FROM kelas
                  WHERE status = 'Aktif'
                  ORDER BY nama_kelas ASC");

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


        private void tampilJadwal()
        {
            if (cmbkelas.SelectedValue == null)
                return;

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                    db.koneksi.Open();

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
                       INNER JOIN mapel m
                           ON j.id_mapel = m.id_mapel
                       WHERE j.id_kelas = @id_kelas
                       ORDER BY j.jam_mulai ASC";

                MySqlCommand cmd = new MySqlCommand(sql, db.koneksi);

                cmd.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbkelas.SelectedValue
                );

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbjadwal.DataSource = dt;
                cmbjadwal.DisplayMember = "jadwal";
                cmbjadwal.ValueMember = "id_jadwal";
                cmbjadwal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil jadwal: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State == ConnectionState.Open)
                    db.koneksi.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvabsensi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex < 3)
                return;

            DataGridViewRow row =
                dgvabsensi.Rows[e.RowIndex];

            string kolom =
                dgvabsensi.Columns[e.ColumnIndex].Name;

            row.Cells["Hadir"].Value = false;
            row.Cells["Izin"].Value = false;
            row.Cells["Sakit"].Value = false;
            row.Cells["Alpa"].Value = false;

            row.Cells[kolom].Value = true;
        }

        private void Fabsensi_Load(object sender, EventArgs e)
        {
            dts.Value = DateTime.Now;

            tampilKelas();
        }

        private void cmbkelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedIndex == -1)
                return;

            tampilJadwal();

            dgvabsensi.Rows.Clear();
        }

        private void tampilSiswa()
        {
            if (cmbkelas.SelectedValue == null)
                return;

            try
            {
                if (db.koneksi.State == ConnectionState.Closed)
                    db.koneksi.Open();

                string sql = @"SELECT
                        id_siswa,
                        nis,
                        nama_siswa
                       FROM siswa
                       WHERE id_kelas = @id_kelas
                       AND status = 'Aktif'
                       ORDER BY nama_siswa ASC";

                MySqlCommand cmd =
                    new MySqlCommand(sql, db.koneksi);

                cmd.Parameters.AddWithValue(
                    "@id_kelas",
                    cmbkelas.SelectedValue
                );

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

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
                    false,
                    false,
                    false,
                    false
                );

                    no++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data siswa: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (db.koneksi.State == ConnectionState.Open)
                    db.koneksi.Close();
            }
        }

        private void btnhadir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvabsensi.Rows)
            {
                if (row.IsNewRow)
                    continue;

                row.Cells["Hadir"].Value = true;
                row.Cells["Izin"].Value = false;
                row.Cells["Sakit"].Value = false;
                row.Cells["Alpa"].Value = false;
            }
        }

        private void cmbjadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjadwal.SelectedIndex == -1)
                return;

            tampilSiswa();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cmbkelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "Silakan pilih kelas terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbjadwal.SelectedValue == null)
            {
                MessageBox.Show(
                    "Silakan pilih jadwal terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (dgvabsensi.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Belum ada data siswa!",
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

                foreach (DataGridViewRow row in dgvabsensi.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int idSiswa =
                        Convert.ToInt32(row.Cells["id_siswa"].Value);

                    string status = "";

                    if (Convert.ToBoolean(row.Cells["Hadir"].Value))
                        status = "Hadir";
                    else if (Convert.ToBoolean(row.Cells["Izin"].Value))
                        status = "Izin";
                    else if (Convert.ToBoolean(row.Cells["Sakit"].Value))
                        status = "Sakit";
                    else if (Convert.ToBoolean(row.Cells["Alpa"].Value))
                        status = "Alpa";

                    if (status == "")
                    {
                        MessageBox.Show(
                            "Status absensi belum dipilih untuk siswa: " +
                            row.Cells["Nama"].Value.ToString(),
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    string sql = @"INSERT INTO absensi
                           (
                               tanggal,
                               id_jadwal,
                               id_siswa,
                               status
                           )
                           VALUES
                           (
                               @tanggal,
                               @id_jadwal,
                               @id_siswa,
                               @status
                           )";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, db.koneksi);

                    cmd.Parameters.AddWithValue(
                        "@tanggal",
                        dts.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@id_jadwal",
                        cmbjadwal.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@id_siswa",
                        idSiswa
                    );

                    cmd.Parameters.AddWithValue(
                        "@status",
                        status
                    );

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Absensi berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dgvabsensi.Rows.Clear();

                cmbkelas.SelectedIndex = -1;
                cmbjadwal.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan absensi: " + ex.Message,
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
