
namespace ABSENSI_Juandi_rustiana
{
    partial class Fdatapetugas
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
            System.Windows.Forms.DataGridViewCellStyle dgvStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

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
            this.dgvdaftarpetu    = new Guna.UI2.WinForms.Guna2DataGridView();

            this.txtnama  = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser  = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpas   = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbrole  = new Guna.UI2.WinForms.Guna2ComboBox();

            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button(); // Simpan
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button(); // Ubah
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button(); // Hapus
            this.btnbatal     = new Guna.UI2.WinForms.Guna2Button(); // Batal

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardForm.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftarpetu)).BeginInit();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelSidebar.Controls.Add(this.lblSidebarRole);
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.guna2Button4);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
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
            this.guna2Panel1.Location = new System.Drawing.Point(260, 0);
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
            this.guna2HtmlLabel1.Text = "Data Petugas";

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Kelola akun login dan role pengguna sistem.";

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.cardGrid);
            this.panelContent.Controls.Add(this.cardForm);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(260, 88);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(1110, 632);
            this.panelContent.TabIndex = 2;

            // cardForm — 4 kolom: Nama, Username, Password, Role
            this.cardForm.BackColor = System.Drawing.Color.White;
            this.cardForm.FillColor = System.Drawing.Color.White;
            this.cardForm.BorderRadius = 12;
            this.cardForm.ShadowDecoration.Enabled = true;
            this.cardForm.ShadowDecoration.Depth = 6;
            this.cardForm.ShadowDecoration.BorderRadius = 12;
            this.cardForm.Controls.Add(this.guna2HtmlLabel2);
            this.cardForm.Controls.Add(this.txtnama);
            this.cardForm.Controls.Add(this.guna2HtmlLabel3);
            this.cardForm.Controls.Add(this.txtuser);
            this.cardForm.Controls.Add(this.guna2HtmlLabel4);
            this.cardForm.Controls.Add(this.txtpas);
            this.cardForm.Controls.Add(this.guna2HtmlLabel5);
            this.cardForm.Controls.Add(this.cmbrole);
            this.cardForm.Controls.Add(this.guna2Button1);
            this.cardForm.Controls.Add(this.guna2Button2);
            this.cardForm.Controls.Add(this.guna2Button3);
            this.cardForm.Controls.Add(this.btnbatal);
            this.cardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardForm.Location = new System.Drawing.Point(24, 24);
            this.cardForm.Name = "cardForm";
            this.cardForm.Size = new System.Drawing.Size(1062, 172);
            this.cardForm.TabIndex = 0;

            // Nama Petugas
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(16, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 19);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Nama Petugas";

            this.txtnama.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.txtnama.BorderRadius = 8;
            this.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama.DefaultText = "";
            this.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtnama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnama.HoverState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtnama.Location = new System.Drawing.Point(16, 44);
            this.txtnama.Name = "txtnama";
            this.txtnama.PlaceholderText = "Nama lengkap";
            this.txtnama.SelectedText = "";
            this.txtnama.Size = new System.Drawing.Size(240, 36);
            this.txtnama.TabIndex = 1;

            // Username
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(280, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 19);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Username";

            this.txtuser.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.txtuser.BorderRadius = 8;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtuser.Location = new System.Drawing.Point(280, 44);
            this.txtuser.Name = "txtuser";
            this.txtuser.PlaceholderText = "Username login";
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(240, 36);
            this.txtuser.TabIndex = 2;

            // Password
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(540, 20);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(65, 19);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Password";

            this.txtpas.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.txtpas.BorderRadius = 8;
            this.txtpas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpas.DefaultText = "";
            this.txtpas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtpas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpas.HoverState.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.txtpas.Location = new System.Drawing.Point(540, 44);
            this.txtpas.Name = "txtpas";
            this.txtpas.PlaceholderText = "Kosongkan jika tidak diubah";
            this.txtpas.SelectedText = "";
            this.txtpas.Size = new System.Drawing.Size(240, 36);
            this.txtpas.TabIndex = 3;

            // Role
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(800, 20);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(35, 19);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Role";

            this.cmbrole.BackColor = System.Drawing.Color.Transparent;
            this.cmbrole.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cmbrole.BorderRadius = 8;
            this.cmbrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrole.FocusedColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.cmbrole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbrole.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbrole.ItemHeight = 30;
            this.cmbrole.Location = new System.Drawing.Point(800, 44);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(240, 36);
            this.cmbrole.TabIndex = 4;

            // Buttons
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.guna2Button1.Location = new System.Drawing.Point(16, 120);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 40);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Simpan";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.guna2Button2.Location = new System.Drawing.Point(148, 120);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 40);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Ubah";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);

            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.guna2Button3.Location = new System.Drawing.Point(280, 120);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 40);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Hapus";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);

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
            this.btnbatal.TabIndex = 8;
            this.btnbatal.Text = "Batal";
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);

            // cardGrid + dgvdaftarpetu
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.BorderRadius = 12;
            this.cardGrid.ShadowDecoration.Enabled = true;
            this.cardGrid.ShadowDecoration.Depth = 6;
            this.cardGrid.ShadowDecoration.BorderRadius = 12;
            this.cardGrid.Controls.Add(this.dgvdaftarpetu);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Location = new System.Drawing.Point(24, 220);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(16);
            this.cardGrid.Size = new System.Drawing.Size(1062, 388);
            this.cardGrid.TabIndex = 1;

            dgvStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvdaftarpetu.AlternatingRowsDefaultCellStyle = dgvStyle1;
            this.dgvdaftarpetu.BackgroundColor = System.Drawing.Color.White;
            dgvStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvStyle2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dgvStyle2.ForeColor = System.Drawing.Color.White;
            dgvStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvStyle2.SelectionForeColor = System.Drawing.Color.White;
            dgvStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdaftarpetu.ColumnHeadersDefaultCellStyle = dgvStyle2;
            this.dgvdaftarpetu.ColumnHeadersHeight = 42;
            this.dgvdaftarpetu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = System.Drawing.Color.White;
            dgvStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdaftarpetu.DefaultCellStyle = dgvStyle3;
            this.dgvdaftarpetu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdaftarpetu.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvdaftarpetu.Location = new System.Drawing.Point(16, 16);
            this.dgvdaftarpetu.Name = "dgvdaftarpetu";
            this.dgvdaftarpetu.RowHeadersVisible = false;
            this.dgvdaftarpetu.RowTemplate.Height = 36;
            this.dgvdaftarpetu.Size = new System.Drawing.Size(1030, 356);
            this.dgvdaftarpetu.TabIndex = 0;
            this.dgvdaftarpetu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvdaftarpetu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvdaftarpetu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvdaftarpetu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdaftarpetu.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvdaftarpetu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdaftarpetu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvdaftarpetu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvdaftarpetu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvdaftarpetu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Fdatapetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Petugas - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fdatapetugas_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftarpetu)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvdaftarpetu;
        private Guna.UI2.WinForms.Guna2TextBox txtnama;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2TextBox txtpas;
        private Guna.UI2.WinForms.Guna2ComboBox cmbrole;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnbatal;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
