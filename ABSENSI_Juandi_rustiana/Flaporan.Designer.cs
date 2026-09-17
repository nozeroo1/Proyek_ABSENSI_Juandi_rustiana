
namespace ABSENSI_Juandi_rustiana
{
    partial class Flaporan
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Flaporan));

            this.panelSidebar    = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSidebarRole   = new System.Windows.Forms.Label();
            this.lblSidebarTitle  = new System.Windows.Forms.Label();
            this.btnkembali       = new Guna.UI2.WinForms.Guna2Button(); // Kembali sidebar
            this.guna2Panel1      = new Guna.UI2.WinForms.Guna2Panel(); // Header
            this.lblHeaderDesc    = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1  = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent     = new Guna.UI2.WinForms.Guna2Panel();
            this.cardFilter       = new Guna.UI2.WinForms.Guna2Panel();

            this.dtdari   = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtsampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbkelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btncetak = new Guna.UI2.WinForms.Guna2Button();

            this.lblDari   = new System.Windows.Forms.Label();
            this.lblSampai = new System.Windows.Forms.Label();
            this.lblKelas  = new System.Windows.Forms.Label();

            this.printDocument1     = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();

            this.panelSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardFilter.SuspendLayout();
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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(160, 32);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Laporan Absensi";

            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 50);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Buat dan cetak laporan rekap absensi.";

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.FillColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.cardFilter);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(1110, 632);
            this.panelContent.TabIndex = 2;

            // cardFilter — satu card berisi semua filter + tombol cetak
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
            this.cardFilter.Controls.Add(this.btncetak);
            this.cardFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.Size = new System.Drawing.Size(1062, 196);
            this.cardFilter.TabIndex = 0;

            // Row 1: Dari | Sampai | Kelas
            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDari.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDari.Location = new System.Drawing.Point(16, 20);
            this.lblDari.Name = "lblDari";
            this.lblDari.TabIndex = 0;
            this.lblDari.Text = "Dari Tanggal";

            this.dtdari.BorderRadius = 8;
            this.dtdari.Checked = true;
            this.dtdari.FillColor = System.Drawing.Color.White;
            this.dtdari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtdari.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtdari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtdari.Location = new System.Drawing.Point(16, 44);
            this.dtdari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtdari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtdari.Name = "dtdari";
            this.dtdari.Size = new System.Drawing.Size(280, 36);
            this.dtdari.TabIndex = 1;
            this.dtdari.Value = new System.DateTime(2026, 8, 28, 0, 0, 0, 0);

            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSampai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSampai.Location = new System.Drawing.Point(316, 20);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.TabIndex = 2;
            this.lblSampai.Text = "Sampai Tanggal";

            this.dtsampai.BorderRadius = 8;
            this.dtsampai.Checked = true;
            this.dtsampai.FillColor = System.Drawing.Color.White;
            this.dtsampai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtsampai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dtsampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtsampai.Location = new System.Drawing.Point(316, 44);
            this.dtsampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtsampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(280, 36);
            this.dtsampai.TabIndex = 3;
            this.dtsampai.Value = new System.DateTime(2026, 8, 28, 0, 0, 0, 0);

            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKelas.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblKelas.Location = new System.Drawing.Point(616, 20);
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
            this.cmbkelas.Location = new System.Drawing.Point(616, 44);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(280, 36);
            this.cmbkelas.TabIndex = 5;

            // Row 2: tombol cetak
            this.btncetak.BorderRadius = 8;
            this.btncetak.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btncetak.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.HoverState.FillColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btncetak.Location = new System.Drawing.Point(16, 140);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(200, 44);
            this.btncetak.TabIndex = 6;
            this.btncetak.Text = "Cetak / Preview Laporan";
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);

            // PrintDocument & PrintPreviewDialog
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Flaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Absensi - Sistem Absensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Flaporan_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.cardFilter.ResumeLayout(false);
            this.cardFilter.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtdari;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtsampai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2Button btncetak;
        private Guna.UI2.WinForms.Guna2Button btnkembali;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.Label lblKelas;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
