
namespace ABSENSI_Juandi_rustiana
{
    partial class Fjadwal
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
            this.guna2Button4     = new Guna.UI2.WinForms.Guna2Button(); // Kembali
            this.guna2Panel1      = new Guna.UI2.WinForms.Guna2Panel(); // Header
            this.lblHeaderDesc    = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1  = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent     = new Guna.UI2.WinForms.Guna2Panel();
            this.cardForm         = new Guna.UI2.WinForms.Guna2Panel();
            this.cardGrid         = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvjadwal        = new Guna.UI2.WinForms.Guna2DataGridView();

            // Inputs — row 1
            this.cmbhari   = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmulai   = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtselesai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            // Inputs — row 2
            this.cmbkelas  = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbmapel  = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbguru   = new Guna.UI2.WinForms.Guna2ComboBox();

            // Labels
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();

            // Buttons
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button(); // Simpan
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button(); // Ubah
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button(); // Hapus
            this.btnbatal     = new Guna.UI2.WinForms.Guna2Button(); // Batal

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardForm.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjadwal)).BeginInit();
            this.SuspendLayout();

            // Sidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.Controls.Add(this.lblSidebarRole);
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.guna2Button4);
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
            this.lblSidebarRole.Text = "Administrator";

            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.guna2Button4.Location = new System.Drawing.Point(16, 662);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(228, 42);
            this.guna2Button4.TabIndex = 26;
            this.guna2Button4.Text = "Kembali";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);

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
            this.guna2HtmlLabel1.Text = "Data Jadwal";

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Kelola jadwal pelajaran, kelas, dan pengajar.";

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.cardGrid);
            this.panelContent.Controls.Add(this.cardForm);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(1110, 632);
            this.panelContent.TabIndex = 2;

            // cardForm — 2 rows: [Hari | Jam Mulai | Jam Selesai] + [Kelas | Mapel | Guru]
            this.cardForm.BackColor = System.Drawing.Color.White;
            this.cardForm.FillColor = System.Drawing.Color.White;
            this.cardForm.BorderRadius = 12;
            this.cardForm.ShadowDecoration.Enabled = true;
            this.cardForm.ShadowDecoration.Depth = 6;
            this.cardForm.ShadowDecoration.BorderRadius = 12;
            this.cardForm.Controls.Add(this.guna2HtmlLabel2);
            this.cardForm.Controls.Add(this.cmbhari);
            this.cardForm.Controls.Add(this.guna2HtmlLabel3);
            this.cardForm.Controls.Add(this.dtmulai);
            this.cardForm.Controls.Add(this.guna2HtmlLabel4);
            this.cardForm.Controls.Add(this.dtselesai);
            this.cardForm.Controls.Add(this.guna2HtmlLabel5);
            this.cardForm.Controls.Add(this.cmbkelas);
            this.cardForm.Controls.Add(this.guna2HtmlLabel7);
            this.cardForm.Controls.Add(this.cmbmapel);
            this.cardForm.Controls.Add(this.guna2HtmlLabel8);
            this.cardForm.Controls.Add(this.cmbguru);
            this.cardForm.Controls.Add(this.guna2Button1);
            this.cardForm.Controls.Add(this.guna2Button2);
            this.cardForm.Controls.Add(this.guna2Button3);
            this.cardForm.Controls.Add(this.btnbatal);
            this.cardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardForm.Name = "cardForm";
            this.cardForm.Size = new System.Drawing.Size(1062, 252);
            this.cardForm.TabIndex = 0;

            // Row 1 labels
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(16, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(30, 19);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Hari";

            this.cmbhari.BackColor = System.Drawing.Color.Transparent;
            this.cmbhari.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbhari.BorderRadius = 8;
            this.cmbhari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbhari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhari.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbhari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbhari.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbhari.ItemHeight = 30;
            this.cmbhari.Location = new System.Drawing.Point(16, 44);
            this.cmbhari.Name = "cmbhari";
            this.cmbhari.Size = new System.Drawing.Size(240, 36);
            this.cmbhari.TabIndex = 1;

            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(280, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 19);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Jam Mulai";

            this.dtmulai.BorderRadius = 8;
            this.dtmulai.Checked = true;
            this.dtmulai.FillColor = System.Drawing.Color.White;
            this.dtmulai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtmulai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtmulai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmulai.Location = new System.Drawing.Point(280, 44);
            this.dtmulai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmulai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmulai.Name = "dtmulai";
            this.dtmulai.ShowUpDown = true;
            this.dtmulai.Size = new System.Drawing.Size(240, 36);
            this.dtmulai.TabIndex = 2;
            this.dtmulai.Value = new System.DateTime(2026, 1, 1, 7, 0, 0, 0);

            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(540, 20);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(75, 19);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Jam Selesai";

            this.dtselesai.BorderRadius = 8;
            this.dtselesai.Checked = true;
            this.dtselesai.FillColor = System.Drawing.Color.White;
            this.dtselesai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtselesai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtselesai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtselesai.Location = new System.Drawing.Point(540, 44);
            this.dtselesai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtselesai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtselesai.Name = "dtselesai";
            this.dtselesai.ShowUpDown = true;
            this.dtselesai.Size = new System.Drawing.Size(240, 36);
            this.dtselesai.TabIndex = 3;
            this.dtselesai.Value = new System.DateTime(2026, 1, 1, 8, 0, 0, 0);

            // Row 2 labels
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(16, 100);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(36, 19);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Kelas";

            this.cmbkelas.BackColor = System.Drawing.Color.Transparent;
            this.cmbkelas.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbkelas.BorderRadius = 8;
            this.cmbkelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkelas.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbkelas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbkelas.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbkelas.ItemHeight = 30;
            this.cmbkelas.Location = new System.Drawing.Point(16, 124);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(240, 36);
            this.cmbkelas.TabIndex = 4;

            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(280, 100);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(90, 19);
            this.guna2HtmlLabel7.TabIndex = 4;
            this.guna2HtmlLabel7.Text = "Mata Pelajaran";

            this.cmbmapel.BackColor = System.Drawing.Color.Transparent;
            this.cmbmapel.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbmapel.BorderRadius = 8;
            this.cmbmapel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmapel.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbmapel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmapel.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbmapel.ItemHeight = 30;
            this.cmbmapel.Location = new System.Drawing.Point(280, 124);
            this.cmbmapel.Name = "cmbmapel";
            this.cmbmapel.Size = new System.Drawing.Size(240, 36);
            this.cmbmapel.TabIndex = 5;

            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(540, 100);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(35, 19);
            this.guna2HtmlLabel8.TabIndex = 5;
            this.guna2HtmlLabel8.Text = "Guru";

            this.cmbguru.BackColor = System.Drawing.Color.Transparent;
            this.cmbguru.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbguru.BorderRadius = 8;
            this.cmbguru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbguru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbguru.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbguru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbguru.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbguru.ItemHeight = 30;
            this.cmbguru.Location = new System.Drawing.Point(540, 124);
            this.cmbguru.Name = "cmbguru";
            this.cmbguru.Size = new System.Drawing.Size(240, 36);
            this.cmbguru.TabIndex = 6;

            // Buttons
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.guna2Button1.Location = new System.Drawing.Point(16, 200);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 40);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Simpan";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.guna2Button2.Location = new System.Drawing.Point(148, 200);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 40);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Ubah";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);

            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.guna2Button3.Location = new System.Drawing.Point(280, 200);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 40);
            this.guna2Button3.TabIndex = 9;
            this.guna2Button3.Text = "Hapus";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);

            this.btnbatal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnbatal.BorderRadius = 8;
            this.btnbatal.BorderThickness = 1;
            this.btnbatal.FillColor = System.Drawing.Color.White;
            this.btnbatal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnbatal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnbatal.HoverState.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnbatal.Location = new System.Drawing.Point(412, 200);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(120, 40);
            this.btnbatal.TabIndex = 10;
            this.btnbatal.Text = "Batal";
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);

            // cardGrid
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.BorderRadius = 12;
            this.cardGrid.ShadowDecoration.Enabled = true;
            this.cardGrid.ShadowDecoration.Depth = 6;
            this.cardGrid.ShadowDecoration.BorderRadius = 12;
            this.cardGrid.Controls.Add(this.dgvjadwal);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(16);
            this.cardGrid.Size = new System.Drawing.Size(1062, 308);
            this.cardGrid.TabIndex = 1;

            s1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvjadwal.AlternatingRowsDefaultCellStyle = s1;
            this.dgvjadwal.BackgroundColor = System.Drawing.Color.White;
            s2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            s2.ForeColor = System.Drawing.Color.White;
            s2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.SelectionForeColor = System.Drawing.Color.White;
            s2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvjadwal.ColumnHeadersDefaultCellStyle = s2;
            this.dgvjadwal.ColumnHeadersHeight = 42;
            this.dgvjadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            s3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s3.BackColor = System.Drawing.Color.White;
            s3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            s3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            s3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvjadwal.DefaultCellStyle = s3;
            this.dgvjadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvjadwal.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvjadwal.Name = "dgvjadwal";
            this.dgvjadwal.RowHeadersVisible = false;
            this.dgvjadwal.RowTemplate.Height = 36;
            this.dgvjadwal.Size = new System.Drawing.Size(1030, 276);
            this.dgvjadwal.TabIndex = 0;
            this.dgvjadwal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvjadwal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvjadwal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvjadwal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvjadwal.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvjadwal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvjadwal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvjadwal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvjadwal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvjadwal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvjadwal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjadwal_CellContentClick);

            // Form — FormBorderStyle normal (hapus Borderless)
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Fjadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Jadwal - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fjadwal_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjadwal)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel cardForm;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dgvjadwal;
        private Guna.UI2.WinForms.Guna2ComboBox cmbhari;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmulai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtselesai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2ComboBox cmbmapel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbguru;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnbatal;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
