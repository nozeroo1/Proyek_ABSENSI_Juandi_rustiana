
namespace ABSENSI_Juandi_rustiana
{
    partial class Frekapabsensi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.btntampil = new Guna.UI2.WinForms.Guna2Button();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            this.dtsampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtdari = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvrekap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnkembali = new Guna.UI2.WinForms.Guna2Button();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrekap)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel1.Controls.Add(this.btnreset);
            this.guna2Panel1.Controls.Add(this.btntampil);
            this.guna2Panel1.Controls.Add(this.cmbkelas);
            this.guna2Panel1.Controls.Add(this.dtsampai);
            this.guna2Panel1.Controls.Add(this.dtdari);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(904, 163);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnreset
            // 
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(723, 111);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(100, 30);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btntampil
            // 
            this.btntampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntampil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntampil.ForeColor = System.Drawing.Color.White;
            this.btntampil.Location = new System.Drawing.Point(556, 111);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(147, 30);
            this.btntampil.TabIndex = 7;
            this.btntampil.Text = "Tampilkan";
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // cmbkelas
            // 
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(154, 96);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(200, 21);
            this.cmbkelas.TabIndex = 6;
            // 
            // dtsampai
            // 
            this.dtsampai.Checked = true;
            this.dtsampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtsampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtsampai.Location = new System.Drawing.Point(154, 65);
            this.dtsampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtsampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(200, 20);
            this.dtsampai.TabIndex = 5;
            this.dtsampai.Value = new System.DateTime(2026, 8, 28, 13, 56, 58, 320);
            // 
            // dtdari
            // 
            this.dtdari.Checked = true;
            this.dtdari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtdari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtdari.Location = new System.Drawing.Point(154, 36);
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
            this.label4.Location = new System.Drawing.Point(27, 98);
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
            this.label3.Location = new System.Drawing.Point(27, 65);
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
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekap Absensi";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Panel2.Controls.Add(this.dgvrekap);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 198);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(904, 300);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // dgvrekap
            // 
            this.dgvrekap.AllowUserToAddRows = false;
            this.dgvrekap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvrekap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrekap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvrekap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrekap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.NIS,
            this.Nama,
            this.Kelas,
            this.Hadir,
            this.Izin,
            this.Sakit,
            this.Alpa});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrekap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvrekap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrekap.Location = new System.Drawing.Point(31, 18);
            this.dgvrekap.Name = "dgvrekap";
            this.dgvrekap.RowHeadersVisible = false;
            this.dgvrekap.Size = new System.Drawing.Size(842, 262);
            this.dgvrekap.TabIndex = 0;
            this.dgvrekap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrekap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrekap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrekap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrekap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrekap_CellContentClick);
            // 
            // btnkembali
            // 
            this.btnkembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnkembali.ForeColor = System.Drawing.Color.White;
            this.btnkembali.Location = new System.Drawing.Point(402, 501);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(100, 30);
            this.btnkembali.TabIndex = 9;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // NIS
            // 
            this.NIS.DataPropertyName = "NIS";
            this.NIS.HeaderText = "Nis";
            this.NIS.Name = "NIS";
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Kelas
            // 
            this.Kelas.DataPropertyName = "Kelas";
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.Name = "Kelas";
            // 
            // Hadir
            // 
            this.Hadir.DataPropertyName = "Hadir";
            this.Hadir.HeaderText = "Hadir";
            this.Hadir.Name = "Hadir";
            // 
            // Izin
            // 
            this.Izin.DataPropertyName = "Izin";
            this.Izin.HeaderText = "Izin";
            this.Izin.Name = "Izin";
            // 
            // Sakit
            // 
            this.Sakit.DataPropertyName = "Sakit";
            this.Sakit.HeaderText = "Sakit";
            this.Sakit.Name = "Sakit";
            // 
            // Alpa
            // 
            this.Alpa.DataPropertyName = "Alpa";
            this.Alpa.HeaderText = "Alpa";
            this.Alpa.Name = "Alpa";
            // 
            // Frekapabsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 543);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Frekapabsensi";
            this.Text = "Frekapabsensi";
            this.Load += new System.EventHandler(this.Frekapabsensi_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrekap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Button btntampil;
        private System.Windows.Forms.ComboBox cmbkelas;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtsampai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtdari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvrekap;
        private Guna.UI2.WinForms.Guna2Button btnkembali;
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