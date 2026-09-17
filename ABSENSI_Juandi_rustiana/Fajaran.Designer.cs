
namespace ABSENSI_Juandi_rustiana
{
    partial class Fajaran
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
            this.cardForm         = new Guna.UI2.WinForms.Guna2Panel();
            this.cardGrid         = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvajaran        = new Guna.UI2.WinForms.Guna2DataGridView();

            this.txttahun    = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbsemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbstatus   = new Guna.UI2.WinForms.Guna2ComboBox();

            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.btnsimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnubah   = new Guna.UI2.WinForms.Guna2Button();
            this.btnhapus  = new Guna.UI2.WinForms.Guna2Button();
            this.btnbatal  = new Guna.UI2.WinForms.Guna2Button();

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardForm.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvajaran)).BeginInit();
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
            this.lblSidebarRole.Text = "Administrator";

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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 32);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Tahun Ajaran";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Kelola tahun ajaran dan semester aktif.";

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

            // cardForm — 3 kolom: Tahun Ajaran, Semester, Status
            this.cardForm.BackColor = System.Drawing.Color.White;
            this.cardForm.FillColor = System.Drawing.Color.White;
            this.cardForm.BorderRadius = 12;
            this.cardForm.ShadowDecoration.Enabled = true;
            this.cardForm.ShadowDecoration.Depth = 6;
            this.cardForm.ShadowDecoration.BorderRadius = 12;
            this.cardForm.Controls.Add(this.guna2HtmlLabel2);
            this.cardForm.Controls.Add(this.txttahun);
            this.cardForm.Controls.Add(this.guna2HtmlLabel3);
            this.cardForm.Controls.Add(this.cmbsemester);
            this.cardForm.Controls.Add(this.guna2HtmlLabel4);
            this.cardForm.Controls.Add(this.cmbstatus);
            this.cardForm.Controls.Add(this.btnsimpan);
            this.cardForm.Controls.Add(this.btnubah);
            this.cardForm.Controls.Add(this.btnhapus);
            this.cardForm.Controls.Add(this.btnbatal);
            this.cardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardForm.Name = "cardForm";
            this.cardForm.Size = new System.Drawing.Size(1062, 172);
            this.cardForm.TabIndex = 0;

            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(16, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(85, 19);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Tahun Ajaran";

            this.txttahun.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.txttahun.BorderRadius = 8;
            this.txttahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttahun.DefaultText = "";
            this.txttahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txttahun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txttahun.Location = new System.Drawing.Point(16, 44);
            this.txttahun.Name = "txttahun";
            this.txttahun.PlaceholderText = "Contoh: 2026-2027";
            this.txttahun.SelectedText = "";
            this.txttahun.Size = new System.Drawing.Size(240, 36);
            this.txttahun.TabIndex = 1;

            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(280, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(60, 19);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Semester";

            this.cmbsemester.BackColor = System.Drawing.Color.Transparent;
            this.cmbsemester.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbsemester.BorderRadius = 8;
            this.cmbsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsemester.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbsemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbsemester.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbsemester.ItemHeight = 30;
            this.cmbsemester.Location = new System.Drawing.Point(280, 44);
            this.cmbsemester.Name = "cmbsemester";
            this.cmbsemester.Size = new System.Drawing.Size(240, 36);
            this.cmbsemester.TabIndex = 2;

            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(540, 20);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(43, 19);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Status";

            this.cmbstatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbstatus.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbstatus.BorderRadius = 8;
            this.cmbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbstatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbstatus.ItemHeight = 30;
            this.cmbstatus.Location = new System.Drawing.Point(540, 44);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(240, 36);
            this.cmbstatus.TabIndex = 3;

            this.btnsimpan.BorderRadius = 8;
            this.btnsimpan.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnsimpan.Location = new System.Drawing.Point(16, 120);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(120, 40);
            this.btnsimpan.TabIndex = 4;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);

            this.btnubah.BorderRadius = 8;
            this.btnubah.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnubah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnubah.ForeColor = System.Drawing.Color.White;
            this.btnubah.HoverState.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnubah.Location = new System.Drawing.Point(148, 120);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(120, 40);
            this.btnubah.TabIndex = 5;
            this.btnubah.Text = "Ubah";
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);

            this.btnhapus.BorderRadius = 8;
            this.btnhapus.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnhapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnhapus.ForeColor = System.Drawing.Color.White;
            this.btnhapus.HoverState.FillColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnhapus.Location = new System.Drawing.Point(280, 120);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(120, 40);
            this.btnhapus.TabIndex = 6;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);

            this.btnbatal.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnbatal.BorderRadius = 8;
            this.btnbatal.BorderThickness = 1;
            this.btnbatal.FillColor = System.Drawing.Color.White;
            this.btnbatal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnbatal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnbatal.HoverState.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnbatal.Location = new System.Drawing.Point(412, 120);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(120, 40);
            this.btnbatal.TabIndex = 7;
            this.btnbatal.Text = "Batal";
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);

            // cardGrid
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.BorderRadius = 12;
            this.cardGrid.ShadowDecoration.Enabled = true;
            this.cardGrid.ShadowDecoration.Depth = 6;
            this.cardGrid.ShadowDecoration.BorderRadius = 12;
            this.cardGrid.Controls.Add(this.dgvajaran);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(16);
            this.cardGrid.Size = new System.Drawing.Size(1062, 388);
            this.cardGrid.TabIndex = 1;

            s1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvajaran.AlternatingRowsDefaultCellStyle = s1;
            this.dgvajaran.BackgroundColor = System.Drawing.Color.White;
            s2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            s2.ForeColor = System.Drawing.Color.White;
            s2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s2.SelectionForeColor = System.Drawing.Color.White;
            s2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvajaran.ColumnHeadersDefaultCellStyle = s2;
            this.dgvajaran.ColumnHeadersHeight = 42;
            this.dgvajaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            s3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            s3.BackColor = System.Drawing.Color.White;
            s3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            s3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            s3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            s3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvajaran.DefaultCellStyle = s3;
            this.dgvajaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvajaran.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvajaran.Name = "dgvajaran";
            this.dgvajaran.RowHeadersVisible = false;
            this.dgvajaran.RowTemplate.Height = 36;
            this.dgvajaran.Size = new System.Drawing.Size(1030, 356);
            this.dgvajaran.TabIndex = 0;
            this.dgvajaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvajaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvajaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvajaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvajaran.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvajaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvajaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvajaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvajaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvajaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvajaran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvajaran_CellContentClick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Fajaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahun Ajaran - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fajaran_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fajaran_KeyPress);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvajaran)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvajaran;
        private Guna.UI2.WinForms.Guna2TextBox txttahun;
        private Guna.UI2.WinForms.Guna2ComboBox cmbsemester;
        private Guna.UI2.WinForms.Guna2ComboBox cmbstatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnsimpan;
        private Guna.UI2.WinForms.Guna2Button btnubah;
        private Guna.UI2.WinForms.Guna2Button btnhapus;
        private Guna.UI2.WinForms.Guna2Button btnbatal;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
