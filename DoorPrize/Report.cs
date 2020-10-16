using DoorPrize.framework;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace DoorPrize
{
    public partial class Report : Telerik.WinControls.UI.RadForm
    {
        public Report()
        {    
            InitializeComponent();
            this.TabReports.Pages[0].Controls.Add(this.reportViewer1);
            this.TabReports.Pages[1].Controls.Add(this.reportViewer2);
            this.TabReports.Pages[2].Controls.Add(this.reportViewer3);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportWinner();
            ReportExclude();
            ReportAbsence();
        }

        private void ReportAbsence()
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                reportViewer3.Width = 1241;
                reportViewer3.Height = 596;

                string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "AbsenceReport.rdlc";

                reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", da.ExecuteQuery("EXEC spReportAbsence", null)));
                reportViewer3.LocalReport.ReportPath = fName;
                reportViewer3.Refresh();
                reportViewer3.RefreshReport();
                //reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
            }
        }

        private void ReportExclude()
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                reportViewer2.Width = 1241;
                reportViewer2.Height = 596;

                string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "ExcludeReport.rdlc";

                reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", da.ExecuteQuery("EXEC spReportExclude", null)));
                reportViewer2.LocalReport.ReportPath = fName;
                reportViewer2.Refresh();
                reportViewer2.RefreshReport();
                //reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
            }
        }

        private void ReportWinner()
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                reportViewer1.Width = 1241;
                reportViewer1.Height = 596;
                
                string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "WinnerReport.rdlc";

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", da.ExecuteQuery("EXEC spReportWinner", null)));
                reportViewer1.LocalReport.ReportPath = fName;
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
                //reportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
            }
        }

        private void Report_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TabReports_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TabReports_SelectedPageChanged(object sender, EventArgs e)
        {

        }
    }
}
