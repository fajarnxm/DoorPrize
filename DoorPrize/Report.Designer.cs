namespace DoorPrize
{
    partial class Report
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
            this.TabReportExclude = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabReportWinner = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabReports = new Telerik.WinControls.UI.RadPageView();
            this.TabReportAbsence = new Telerik.WinControls.UI.RadPageViewPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TabReports)).BeginInit();
            this.TabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TabReportExclude
            // 
            this.TabReportExclude.BackgroundImage = global::DoorPrize.Properties.Resources.background;
            this.TabReportExclude.ItemSize = new System.Drawing.SizeF(91F, 28F);
            this.TabReportExclude.Location = new System.Drawing.Point(10, 37);
            this.TabReportExclude.Name = "TabReportExclude";
            this.TabReportExclude.Size = new System.Drawing.Size(1241, 596);
            this.TabReportExclude.Text = "Report Exclude";
            // 
            // TabReportWinner
            // 
            this.TabReportWinner.BackgroundImage = global::DoorPrize.Properties.Resources.background;
            this.TabReportWinner.ItemSize = new System.Drawing.SizeF(89F, 28F);
            this.TabReportWinner.Location = new System.Drawing.Point(10, 37);
            this.TabReportWinner.Name = "TabReportWinner";
            this.TabReportWinner.Size = new System.Drawing.Size(1241, 596);
            this.TabReportWinner.Text = "Report Winner";
            // 
            // TabReports
            // 
            this.TabReports.Controls.Add(this.TabReportWinner);
            this.TabReports.Controls.Add(this.TabReportExclude);
            this.TabReports.Controls.Add(this.TabReportAbsence);
            this.TabReports.Location = new System.Drawing.Point(47, 36);
            this.TabReports.Name = "TabReports";
            this.TabReports.SelectedPage = this.TabReportAbsence;
            this.TabReports.Size = new System.Drawing.Size(1262, 644);
            this.TabReports.TabIndex = 0;
            this.TabReports.Text = "Report Exclude";
            this.TabReports.SelectedPageChanged += new System.EventHandler(this.TabReports_SelectedPageChanged);
            this.TabReports.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabReports_KeyPress);
            // 
            // TabReportAbsence
            // 
            this.TabReportAbsence.BackgroundImage = global::DoorPrize.Properties.Resources.background;
            this.TabReportAbsence.ItemSize = new System.Drawing.SizeF(95F, 28F);
            this.TabReportAbsence.Location = new System.Drawing.Point(10, 37);
            this.TabReportAbsence.Name = "TabReportAbsence";
            this.TabReportAbsence.Size = new System.Drawing.Size(1241, 596);
            this.TabReportAbsence.Text = "Report Absence";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(396, 246);
            this.reportViewer3.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoorPrize.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1378, 692);
            this.Controls.Add(this.TabReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Report";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Report_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TabReports)).EndInit();
            this.TabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageViewPage TabReportExclude;
        private Telerik.WinControls.UI.RadPageViewPage TabReportWinner;
        private Telerik.WinControls.UI.RadPageView TabReports;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Telerik.WinControls.UI.RadPageViewPage TabReportAbsence;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;


    }
}
