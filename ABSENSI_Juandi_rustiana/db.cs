using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ABSENSI_Juandi_rustiana
{
    /// <summary>
    /// Kelas helper koneksi dan query database.
    /// Connection string dibaca dari App.config (key "DbAbsensi").
    /// </summary>
    static class db
    {
        // ── Connection string dari App.config ─────────────────────────────────
        private static readonly string _connStr =
            ConfigurationManager.ConnectionStrings["DbAbsensi"].ConnectionString;

        // ── Objek global yang dipakai oleh form-form lama (backward-compat) ───
        public static MySqlConnection koneksi = new MySqlConnection(_connStr);
        public static DataSet         ds      = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand     perintah;

        // ── Helper: buka koneksi baru (dipakai oleh kode baru) ────────────────
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connStr);
        }

        /// <summary>
        /// Jalankan query SELECT dan simpan hasilnya ke ds.Tables[0].
        /// Dipakai oleh form-form lama yang mengakses db.ds secara langsung.
        /// </summary>
        public static void crud(string sql)
        {
            try
            {
                ds.Tables.Clear();
                perintah = new MySqlCommand(sql, koneksi);
                da       = new MySqlDataAdapter(perintah);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menjalankan query: " + ex.Message,
                    "Error Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
