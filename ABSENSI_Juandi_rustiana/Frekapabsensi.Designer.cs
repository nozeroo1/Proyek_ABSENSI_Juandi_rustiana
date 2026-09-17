
namespace ABSENSI_Juandi_rustiana
{
    partial class Frekapabsensi
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
            this.btnkembali       = new Guna.UI2.WinForms.Guna2Button(); // Kembali di sidebar
            this.guna2Panel1      = new Guna.UI2.WinForms.Guna2Panel(); // Header
            this.lblHeaderDesc    = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1  = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent     = new Guna.UI2.WinForms.Guna2Panel();
            this.cardFilter       = new Guna.UI2.WinForms.Guna2Panel();
            this.cardGrid         = new Guna.UI2.WinForms.Guna2Panel();

            // Filter
            this.dtdari   = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtsampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbkelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btntampil = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset  = new Guna.UI2.WinForms.Guna2Button();

            this.lblDari    = new System.Windows.Forms.Label();
            this.lblSampai  = new System.Windows.Forms.Label();
            this.lblKelas   = new System.Windows.Forms.Label();

            // Grid — kolom statis dipertahankan agar DataPropertyName binding bekerja
            this.dgvrekap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIS   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izin  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpa  = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardFilter.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrekap)).BeginInit();
            this.SuspendLayout();

            // Sidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.Controls.Add(this.lblSidebarRole);
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.btnkembali);
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

            this.btnkembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkembali.BorderRadius = 8;
            this.btnkembali.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnkembali.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnkembali.ForeColor = System.Drawing.Color.White;
            this.btnkembali.HoverState.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnkembali.Location = new System.Drawing.Point(16, 662);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(228, 42);
            this.btnkembali.TabIndex = 26;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);

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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(140, 32);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Rekap Absensi";

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Lihat rekapitulasi kehadiran siswa per periode.";

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.cardGrid);
            this.panelContent.Controls.Add(this.cardFilter);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(1110, 632);
            this.panelContent.TabIndex = 2;

            // cardFilter
            this.cardFilter.BackColor = System.Drawing.Color.White;
            this.cardFilter.FillColor = System.Drawing.Color.White;
            this.cardFilter.BorderRadius = 12;
            this.cardFilter.ShadowDecoration.Enabled = true;
            this.cardFilter.ShadowDecoration.Depth = 6;
            this.cardFilter.ShadowDecoration.BorderRadius = 12;
            this.cardFilter.Controls.Add(this.lblDari);
            this.cardFilter.Controls.Add(this.dtdari);
            this.cardFilter.Controls.Add(this.lblSampai);
            this.cardFilter.Controls.Add(this.dtsampai);
            this.cardFilter.Controls.Add(this.lblKelas);
            this.cardFilter.Controls.Add(this.cmbkelas);
            this.cardFilter.Controls.Add(this.btntampil);
            this.cardFilter.Controls.Add(this.btnreset);
            this.cardFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.Size = new System.Drawing.Size(1062, 168);
            this.cardFilter.TabIndex = 0;

            // Row 1: Dari | Sampai | Kelas
            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDari.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDari.Location = new System.Drawing.Point(16, 16);
            this.lblDari.Name = "lblDari";
            this.lblDari.TabIndex = 0;
            this.lblDari.Text = "Dari Tanggal";

            this.dtdari.BorderRadius = 8;
            this.dtdari.Checked = true;
            this.dtdari.FillColor = System.Drawing.Color.White;
            this.dtdari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtdari.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtdari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtdari.Location = new System.Drawing.Point(16, 40);
            this.dtdari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtdari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtdari.Name = "dtdari";
            this.dtdari.Size = new System.Drawing.Size(280, 36);
            this.dtdari.TabIndex = 1;
            this.dtdari.Value = new System.DateTime(2026, 8, 28, 0, 0, 0, 0);

            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSampai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSampai.Location = new System.Drawing.Point(316, 16);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.TabIndex = 2;
            this.lblSampai.Text = "Sampai Tanggal";

            this.dtsampai.BorderRadius = 8;
            this.dtsampai.Checked = true;
            this.dtsampai.FillColor = System.Drawing.Color.White;
            this.dtsampai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtsampai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtsampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtsampai.Location = new System.Drawing.Point(316, 40);
            this.dtsampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtsampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(280, 36);
            this.dtsampai.TabIndex = 3;
            this.dtsampai.Value = new System.DateTime(2026, 8, 28, 0, 0, 0, 0);

            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKelas.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblKelas.Location = new System.Drawing.Point(616, 16);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.TabIndex = 4;
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
            this.cmbkelas.Location = new System.Drawing.Point(616, 40);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(280, 36);
            this.cmbkelas.TabIndex = 5;

            // Row 2: tombol
            this.btntampil.BorderRadius = 8;
            this.btntampil.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btntampil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btntampil.ForeColor = System.Drawing.Color.White;
            this.btntampil.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btntampil.Location = new System.Drawing.Point(16, 116);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(160, 40);
            this.btntampil.TabIndex = 6;
            this.btntampil.Text = "Tampilkan";
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);

            this.btnreset.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnreset.BorderRadius = 8;
            this.btnreset.BorderThickness = 1;
            this.btnreset.FillColor = System.Drawing.Color.White;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnreset.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnreset.HoverState.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnreset.Location = new System.Drawing.Point(188, 116);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(120, 40);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);

            // cardGrid
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.BorderRadius = 12;
            this.cardGrid.ShadowDecoration.Enabled = true;
            this.cardGrid.ShadowDecoration.Depth = 6;
            this.cardGrid.ShadowDecoration.BorderRadius = 12;
            this.cardGrid.Controls.Add(this.dgvrekap);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(16);
            this.cardGrid.Size = new System.Drawing.Size(1062, 392);
            this.cardGrid.TabIndex = 1;

            // dgvrekap — kolom statis dengan DataPropertyName dipertahankan
            this.dgvrekap.AllowUserToAddRows = false;
            this.dgvrekap.AllowUserToDeleteRows = false;
            s1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvrekap.AlternatingRowsDefaultCellStyle = s1;
            this.dgvrekap.BackgroundColor = System.Drawing.Color.White;
            s2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            s2.ForeColor = System.Drawing.Color.White;
            s2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.SelectionForeColor = System.Drawing.Color.White;
            s2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrekap.ColumnHeadersDefaultCellStyle = s2;
            this.dgvrekap.ColumnHeadersHeight = 42;
            this.dgvrekap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            s3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s3.BackColor = System.Drawing.Color.White;
            s3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            s3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            s3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrekap.DefaultCellStyle = s3;
            this.dgvrekap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrekap.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvrekap.Location = new System.Drawing.Point(16, 16);
            this.dgvrekap.Name = "dgvrekap";
            this.dgvrekap.ReadOnly = true;
            this.dgvrekap.RowHeadersVisible = false;
            this.dgvrekap.RowTemplate.Height = 36;
            this.dgvrekap.Size = new System.Drawing.Size(1030, 360);
            this.dgvrekap.TabIndex = 0;
            this.dgvrekap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvrekap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvrekap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvrekap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvrekap.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvrekap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrekap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvrekap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvrekap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvrekap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvrekap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.no, this.NIS, this.Nama, this.Kelas,
                this.Hadir, this.Izin, this.Sakit, this.Alpa });
            this.dgvrekap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrekap_CellContentClick);

            // Kolom
            this.no.HeaderText = "No";
            this.no.Name = "No";
            this.NIS.DataPropertyName = "NIS";
            this.NIS.HeaderText = "NIS";
            this.NIS.Name = "NIS";
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Kelas.DataPropertyName = "Kelas";
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.Name = "Kelas";
            this.Hadir.DataPropertyName = "Hadir";
            this.Hadir.HeaderText = "Hadir";
            this.Hadir.Name = "Hadir";
            this.Izin.DataPropertyName = "Izin";
            this.Izin.HeaderText = "Izin";
            this.Izin.Name = "Izin";
            this.Sakit.DataPropertyName = "Sakit";
            this.Sakit.HeaderText = "Sakit";
            this.Sakit.Name = "Sakit";
            this.Alpa.DataPropertyName = "Alpa";
            this.Alpa.HeaderText = "Alpa";
            this.Alpa.Name = "Alpa";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Frekapabsensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rekap Absensi - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frekapabsensi_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardFilter.ResumeLayout(false);
            this.cardFilter.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrekap)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtdari;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtsampai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2Button btntampil;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Button btnkembali;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.Label lblKelas;
        private Guna.UI2.WinForms.Guna2DataGridView dgvrekap;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpa;
    }
}
