
namespace ABSENSI_Juandi_rustiana
{
    partial class Fabsensi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle s1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle s2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle s3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelSidebar    = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSidebarRole   = new System.Windows.Forms.Label();
            this.lblSidebarTitle  = new System.Windows.Forms.Label();
            this.guna2Button1     = new Guna.UI2.WinForms.Guna2Button(); // Kembali
            this.guna2Panel1      = new Guna.UI2.WinForms.Guna2Panel(); // Header
            this.lblHeaderDesc    = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1  = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent     = new Guna.UI2.WinForms.Guna2Panel();
            this.cardFilter       = new Guna.UI2.WinForms.Guna2Panel(); // filter atas
            this.cardDaftar       = new Guna.UI2.WinForms.Guna2Panel(); // tabel bawah

            // Filter inputs
            this.dts       = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbkelas  = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbjadwal = new Guna.UI2.WinForms.Guna2ComboBox();

            // Filter labels
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblKelas   = new System.Windows.Forms.Label();
            this.lblJadwal  = new System.Windows.Forms.Label();

            // DataGridView — kolom dibuat programatik di SetupDataGridView()
            this.dgvabsensi = new Guna.UI2.WinForms.Guna2DataGridView();
            // Kolom statis yang harus ada agar binding nama di .cs bekerja
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            // Action buttons
            this.btnhadir  = new Guna.UI2.WinForms.Guna2Button();
            this.btnsimpan = new Guna.UI2.WinForms.Guna2Button();

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardFilter.SuspendLayout();
            this.cardDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsensi)).BeginInit();
            this.SuspendLayout();

            // Sidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.Controls.Add(this.lblSidebarRole);
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.guna2Button1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(260, 720);
            this.panelSidebar.TabIndex = 0;

            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(20, 24);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.TabIndex = 1;
            this.lblSidebarTitle.Text = "Sistem Absensi";

            this.lblSidebarRole.AutoSize = true;
            this.lblSidebarRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSidebarRole.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSidebarRole.Location = new System.Drawing.Point(22, 52);
            this.lblSidebarRole.Name = "lblSidebarRole";
            this.lblSidebarRole.TabIndex = 2;
            this.lblSidebarRole.Text = "Petugas";

            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.guna2Button1.Location = new System.Drawing.Point(16, 662);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(228, 42);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Kembali";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            // Header
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Controls.Add(this.lblHeaderDesc);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1110, 88);
            this.guna2Panel1.TabIndex = 15;

            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 18);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(120, 32);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Input Absensi";

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Catat kehadiran siswa per kelas dan jadwal.";

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.cardDaftar);
            this.panelContent.Controls.Add(this.cardFilter);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(1110, 632);
            this.panelContent.TabIndex = 2;

            // cardFilter — 3 kolom: Tanggal | Kelas | Jadwal
            this.cardFilter.BackColor = System.Drawing.Color.White;
            this.cardFilter.FillColor = System.Drawing.Color.White;
            this.cardFilter.BorderRadius = 12;
            this.cardFilter.ShadowDecoration.Enabled = true;
            this.cardFilter.ShadowDecoration.Depth = 6;
            this.cardFilter.ShadowDecoration.BorderRadius = 12;
            this.cardFilter.Controls.Add(this.lblTanggal);
            this.cardFilter.Controls.Add(this.dts);
            this.cardFilter.Controls.Add(this.lblKelas);
            this.cardFilter.Controls.Add(this.cmbkelas);
            this.cardFilter.Controls.Add(this.lblJadwal);
            this.cardFilter.Controls.Add(this.cmbjadwal);
            this.cardFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.Size = new System.Drawing.Size(1062, 120);
            this.cardFilter.TabIndex = 0;

            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTanggal.Location = new System.Drawing.Point(16, 16);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal";

            this.dts.BorderRadius = 8;
            this.dts.Checked = true;
            this.dts.FillColor = System.Drawing.Color.White;
            this.dts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dts.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dts.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dts.Location = new System.Drawing.Point(16, 40);
            this.dts.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dts.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dts.Name = "dts";
            this.dts.Size = new System.Drawing.Size(300, 36);
            this.dts.TabIndex = 1;
            this.dts.Value = new System.DateTime(2026, 8, 28, 0, 0, 0, 0);

            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKelas.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblKelas.Location = new System.Drawing.Point(340, 16);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas";

            this.cmbkelas.BackColor = System.Drawing.Color.Transparent;
            this.cmbkelas.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbkelas.BorderRadius = 8;
            this.cmbkelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkelas.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbkelas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbkelas.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbkelas.ItemHeight = 30;
            this.cmbkelas.Location = new System.Drawing.Point(340, 40);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(280, 36);
            this.cmbkelas.TabIndex = 3;
            this.cmbkelas.SelectedIndexChanged += new System.EventHandler(this.cmbkelas_SelectedIndexChanged);

            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblJadwal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblJadwal.Location = new System.Drawing.Point(644, 16);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.TabIndex = 4;
            this.lblJadwal.Text = "Jadwal";

            this.cmbjadwal.BackColor = System.Drawing.Color.Transparent;
            this.cmbjadwal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbjadwal.BorderRadius = 8;
            this.cmbjadwal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbjadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjadwal.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbjadwal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbjadwal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbjadwal.ItemHeight = 30;
            this.cmbjadwal.Location = new System.Drawing.Point(644, 40);
            this.cmbjadwal.Name = "cmbjadwal";
            this.cmbjadwal.Size = new System.Drawing.Size(380, 36);
            this.cmbjadwal.TabIndex = 5;
            this.cmbjadwal.SelectedIndexChanged += new System.EventHandler(this.cmbjadwal_SelectedIndexChanged);

            // cardDaftar — berisi dgvabsensi + tombol aksi
            this.cardDaftar.BackColor = System.Drawing.Color.White;
            this.cardDaftar.FillColor = System.Drawing.Color.White;
            this.cardDaftar.BorderRadius = 12;
            this.cardDaftar.ShadowDecoration.Enabled = true;
            this.cardDaftar.ShadowDecoration.Depth = 6;
            this.cardDaftar.ShadowDecoration.BorderRadius = 12;
            this.cardDaftar.Controls.Add(this.dgvabsensi);
            this.cardDaftar.Controls.Add(this.btnhadir);
            this.cardDaftar.Controls.Add(this.btnsimpan);
            this.cardDaftar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDaftar.Name = "cardDaftar";
            this.cardDaftar.Padding = new System.Windows.Forms.Padding(16, 16, 16, 68);
            this.cardDaftar.Size = new System.Drawing.Size(1062, 460);
            this.cardDaftar.TabIndex = 1;

            // dgvabsensi — kolom dikelola sepenuhnya oleh SetupDataGridView() di constructor .cs
            // Kolom di bawah hanya placeholder agar field binding di .cs tidak error saat compile
            this.dgvabsensi.AllowUserToAddRows = false;
            this.dgvabsensi.AllowUserToDeleteRows = false;
            s1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvabsensi.AlternatingRowsDefaultCellStyle = s1;
            this.dgvabsensi.BackgroundColor = System.Drawing.Color.White;
            s2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            s2.ForeColor = System.Drawing.Color.White;
            s2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.SelectionForeColor = System.Drawing.Color.White;
            s2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvabsensi.ColumnHeadersDefaultCellStyle = s2;
            this.dgvabsensi.ColumnHeadersHeight = 42;
            this.dgvabsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            s3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s3.BackColor = System.Drawing.Color.White;
            s3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            s3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            s3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvabsensi.DefaultCellStyle = s3;
            this.dgvabsensi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvabsensi.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvabsensi.Location = new System.Drawing.Point(16, 16);
            this.dgvabsensi.Name = "dgvabsensi";
            this.dgvabsensi.RowHeadersVisible = false;
            this.dgvabsensi.RowTemplate.Height = 36;
            this.dgvabsensi.Size = new System.Drawing.Size(1030, 376);
            this.dgvabsensi.TabIndex = 0;
            this.dgvabsensi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvabsensi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvabsensi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvabsensi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvabsensi.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvabsensi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvabsensi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvabsensi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvabsensi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvabsensi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvabsensi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvabsensi_CellContentClick);

            // Column placeholders — hanya untuk compile; SetupDataGridView() akan Clear dan rebuild
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column2.HeaderText = "Nis";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column3.HeaderText = "Nama_Siswa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column4.HeaderText = "Hadir";
            this.Column4.Name = "Column4";
            this.Column5.HeaderText = "Izin";
            this.Column5.Name = "Column5";
            this.Column6.HeaderText = "Sakit";
            this.Column6.Name = "Column6";
            this.Column7.HeaderText = "Alpa";
            this.Column7.Name = "Column7";

            // Tombol Hadir Semua
            this.btnhadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnhadir.BorderRadius = 8;
            this.btnhadir.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnhadir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnhadir.ForeColor = System.Drawing.Color.White;
            this.btnhadir.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnhadir.Location = new System.Drawing.Point(16, 412);
            this.btnhadir.Name = "btnhadir";
            this.btnhadir.Size = new System.Drawing.Size(160, 40);
            this.btnhadir.TabIndex = 1;
            this.btnhadir.Text = "Hadir Semua";
            this.btnhadir.Click += new System.EventHandler(this.btnhadir_Click);

            // Tombol Simpan
            this.btnsimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsimpan.BorderRadius = 8;
            this.btnsimpan.FillColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnsimpan.Location = new System.Drawing.Point(886, 412);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(160, 40);
            this.btnsimpan.TabIndex = 2;
            this.btnsimpan.Text = "Simpan Absensi";
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Fabsensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Absensi - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fabsensi_FormClosing);
            this.Load += new System.EventHandler(this.Fabsensi_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardFilter.ResumeLayout(false);
            this.cardFilter.PerformLayout();
            this.cardDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsensi)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblSidebarRole;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblHeaderDesc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2Panel cardFilter;
        private Guna.UI2.WinForms.Guna2Panel cardDaftar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dts;
        private Guna.UI2.WinForms.Guna2ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2ComboBox cmbjadwal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblJadwal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvabsensi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Button btnhadir;
        private Guna.UI2.WinForms.Guna2Button btnsimpan;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
