-- ============================================================
-- MIGRATION v2 — Sistem Absensi Sekolah
-- Tanggal  : 2026-09-18
-- Deskripsi: Perbaikan struktur database
--            - Tambah kolom id_wali_kelas di tabel kelas
--            - Tambah kolom id_ajaran di tabel jadwal
--            - Tambah UNIQUE KEY yang hilang
--            - Perbaiki ON DELETE/UPDATE pada FK jadwal
--            - Migrasi data wali_kelas ke id_wali_kelas
-- ============================================================

-- Selalu mulai dalam satu transaksi agar aman
SET FOREIGN_KEY_CHECKS = 0;

-- ============================================================
-- 1. TABEL kelas
--    - Tambah kolom id_wali_kelas (FK ke guru)
--    - Pertahankan kolom wali_kelas untuk backward compat
--      (akan dihapus setelah migrasi data)
--    - Tambah UNIQUE KEY (nama_kelas, id_jurusan)
-- ============================================================

-- 1a. Tambah kolom id_wali_kelas
ALTER TABLE kelas
  ADD COLUMN id_wali_kelas INT(11) DEFAULT NULL
    AFTER wali_kelas;

-- 1b. Migrasi data: cocokan nama wali_kelas ke nama_guru di tabel guru
--     Update id_wali_kelas berdasarkan kecocokan nama (case-insensitive)
UPDATE kelas k
  INNER JOIN guru g
    ON LOWER(TRIM(k.wali_kelas)) = LOWER(TRIM(g.nama_guru))
SET k.id_wali_kelas = g.id_guru;

-- 1c. Tambah FK id_wali_kelas → guru.id_guru
ALTER TABLE kelas
  ADD CONSTRAINT fk_kelas_wali
    FOREIGN KEY (id_wali_kelas)
    REFERENCES guru (id_guru)
    ON DELETE SET NULL
    ON UPDATE CASCADE;

-- 1d. Tambah UNIQUE KEY nama kelas per jurusan
--     (cek dulu apakah ada duplikat sebelum menjalankan ini)
ALTER TABLE kelas
  ADD UNIQUE KEY unik_kelas (nama_kelas, id_jurusan);

-- ============================================================
-- 2. TABEL jadwal
--    - Tambah kolom id_ajaran (FK ke ajaran)
--    - Perbaiki ON DELETE/UPDATE pada FK yang sudah ada
-- ============================================================

-- 2a. Tambah kolom id_ajaran
ALTER TABLE jadwal
  ADD COLUMN id_ajaran INT(11) NOT NULL
    AFTER id_jadwal;

-- 2b. Isi id_ajaran dengan ajaran aktif yang ada
--     (untuk data jadwal lama yang belum punya id_ajaran)
UPDATE jadwal
SET id_ajaran = (
  SELECT id_ajaran
  FROM ajaran
  WHERE status = 'Aktif'
  ORDER BY id_ajaran DESC
  LIMIT 1
);

-- 2c. Tambah FK id_ajaran → ajaran.id_ajaran
ALTER TABLE jadwal
  ADD CONSTRAINT fk_jadwal_ajaran
    FOREIGN KEY (id_ajaran)
    REFERENCES ajaran (id_ajaran)
    ON DELETE RESTRICT
    ON UPDATE CASCADE;

-- 2d. Drop FK lama yang tidak punya ON DELETE rule, lalu buat ulang
ALTER TABLE jadwal
  DROP FOREIGN KEY jadwal_ibfk_1,
  DROP FOREIGN KEY jadwal_ibfk_2,
  DROP FOREIGN KEY jadwal_ibfk_3;

ALTER TABLE jadwal
  ADD CONSTRAINT jadwal_ibfk_1
    FOREIGN KEY (id_kelas)
    REFERENCES kelas (id_kelas)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  ADD CONSTRAINT jadwal_ibfk_2
    FOREIGN KEY (id_mapel)
    REFERENCES mapel (id_mapel)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  ADD CONSTRAINT jadwal_ibfk_3
    FOREIGN KEY (id_guru)
    REFERENCES guru (id_guru)
    ON DELETE RESTRICT
    ON UPDATE CASCADE;

-- ============================================================
-- 3. UNIQUE KEY yang hilang
-- ============================================================

-- 3a. guru.nip — NULL diperbolehkan, duplikat tidak
--     (MariaDB: nilai NULL tidak dianggap duplikat dalam UNIQUE)
ALTER TABLE guru
  ADD UNIQUE KEY unik_nip (nip);

-- 3b. mapel.kode_mapel
ALTER TABLE mapel
  ADD UNIQUE KEY unik_kode_mapel (kode_mapel);

-- 3c. ajaran — kombinasi tahun_ajaran + semester tidak boleh duplikat
ALTER TABLE ajaran
  ADD UNIQUE KEY unik_ajaran (tahun_ajaran, semester);

-- 3d. siswa.nisn — NULL diperbolehkan
ALTER TABLE siswa
  ADD UNIQUE KEY unik_nisn (nisn);

-- ============================================================
-- 4. Setelah semua FK dan UNIQUE selesai,
--    kolom wali_kelas (teks lama) bisa di-drop
--    OPSIONAL: hanya jalankan jika migrasi id_wali_kelas sudah benar
--    Uncomment baris di bawah ini jika siap:
-- ============================================================
-- ALTER TABLE kelas DROP COLUMN wali_kelas;

SET FOREIGN_KEY_CHECKS = 1;

-- ============================================================
-- VERIFIKASI
-- ============================================================
SELECT 'KELAS' AS tabel, id_kelas, nama_kelas, wali_kelas, id_wali_kelas
  FROM kelas;

SELECT 'JADWAL' AS tabel, id_jadwal, id_ajaran, hari, id_kelas
  FROM jadwal;

SELECT TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE
  FROM information_schema.TABLE_CONSTRAINTS
  WHERE TABLE_SCHEMA = 'db_absensi'
  ORDER BY TABLE_NAME;
