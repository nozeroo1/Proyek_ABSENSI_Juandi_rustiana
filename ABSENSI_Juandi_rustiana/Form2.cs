using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ABSENSI_Juandi_rustiana
{
    public partial class Form2 : Form
    {
        private string reportfilename;
        public Form2() : this("datauser_report.rpt")
        {

        }

        public Form2(string filename)
        {
            InitializeComponent();
            this.reportfilename = filename;
            this.Load += Form2_Load;
        }
        public Form2(ReportDocument rpt)
        {
            InitializeComponent();
            SetReport(rpt);
        }
        public void SetReport(ReportDocument rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(reportfilename))
            {
                TampilReport(reportfilename);
            }
        }
        public void TampilReport(string namafile)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, namafile);

                if (!File.Exists(reportPath))
                {
                    string alternatifPath = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        @"..\..\ " + namafile
                    );

                    if (File.Exists(alternatifPath))
                    {
                        reportPath = Path.GetFullPath(alternatifPath);
                    }
                }

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File Laporan tidak ditemukan");
                    return;
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(reportPath);

                ConnectionInfo crConn = new ConnectionInfo();
                crConn.ServerName = "localhost";
                crConn.DatabaseName = "db_trans1";
                crConn.UserID = "root";
                crConn.Password = "";

                foreach (Table crTabel in rpt.Database.Tables)
                {
                    TableLogOnInfo crlogon = crTabel.LogOnInfo;
                    crlogon.ConnectionInfo = crConn;
                    crTabel.ApplyLogOnInfo(crlogon);
                }

                SetReport(rpt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal Menampilkan Laporan : " + e.Message);
            }
        }

            private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
