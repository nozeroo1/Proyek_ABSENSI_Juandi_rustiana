
namespace ABSENSI_Juandi_rustiana
{
    partial class Flaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flaporan));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnkembali = new Guna.UI2.WinForms.Guna2Button();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            this.dtsampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btncetak = new Guna.UI2.WinForms.Guna2Button();
            this.dtdari = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel1.Controls.Add(this.btnkembali);
            this.guna2Panel1.Controls.Add(this.cmbkelas);
            this.guna2Panel1.Controls.Add(this.dtsampai);
            this.guna2Panel1.Controls.Add(this.btncetak);
            this.guna2Panel1.Controls.Add(this.dtdari);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(493, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(504, 286);
            this.guna2Panel1.TabIndex = 10;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnkembali
            // 
            this.btnkembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnkembali.ForeColor = System.Drawing.Color.White;
            this.btnkembali.Location = new System.Drawing.Point(211, 202);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(100, 30);
            this.btnkembali.TabIndex = 8;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // cmbkelas
            // 
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(153, 110);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(200, 21);
            this.cmbkelas.TabIndex = 6;
            // 
            // dtsampai
            // 
            this.dtsampai.Checked = true;
            this.dtsampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtsampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtsampai.Location = new System.Drawing.Point(153, 79);
            this.dtsampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtsampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(200, 20);
            this.dtsampai.TabIndex = 5;
            this.dtsampai.Value = new System.DateTime(2026, 8, 28, 13, 56, 58, 320);
            // 
            // btncetak
            // 
            this.btncetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncetak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.Location = new System.Drawing.Point(31, 202);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(147, 30);
            this.btncetak.TabIndex = 7;
            this.btncetak.Text = "Cetak";
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // dtdari
            // 
            this.dtdari.Checked = true;
            this.dtdari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtdari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtdari.Location = new System.Drawing.Point(153, 50);
            this.dtdari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtdari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtdari.Name = "dtdari";
            this.dtdari.Size = new System.Drawing.Size(200, 20);
            this.dtdari.TabIndex = 4;
            this.dtdari.Value = new System.DateTime(2026, 8, 28, 13, 56, 58, 320);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sampai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Flaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 644);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Flaporan";
            this.Text = "Flaporan";
            this.Load += new System.EventHandler(this.Flaporan_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnkembali;
        private Guna.UI2.WinForms.Guna2Button btncetak;
        private System.Windows.Forms.ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtsampai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtdari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}