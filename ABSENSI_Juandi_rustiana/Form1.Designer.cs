
namespace ABSENSI_Juandi_rustiana
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNLOG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pas = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BTNLOG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pas);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(41, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 255);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNLOG
            // 
            this.BTNLOG.BackColor = System.Drawing.Color.Black;
            this.BTNLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLOG.ForeColor = System.Drawing.Color.Transparent;
            this.BTNLOG.Location = new System.Drawing.Point(207, 178);
            this.BTNLOG.Name = "BTNLOG";
            this.BTNLOG.Size = new System.Drawing.Size(255, 33);
            this.BTNLOG.TabIndex = 5;
            this.BTNLOG.Text = "Sign in";
            this.BTNLOG.UseVisualStyleBackColor = false;
            this.BTNLOG.Click += new System.EventHandler(this.BTNLOG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // pas
            // 
            this.pas.AutoSize = true;
            this.pas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pas.ForeColor = System.Drawing.Color.Transparent;
            this.pas.Location = new System.Drawing.Point(204, 120);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(62, 17);
            this.pas.TabIndex = 3;
            this.pas.Text = "password";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(204, 72);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(65, 17);
            this.user.TabIndex = 2;
            this.user.Text = "username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNLOG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pas;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

