namespace DoorPrize
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ButtonRegistration = new Telerik.WinControls.UI.RadButton();
            this.ButtonReport = new Telerik.WinControls.UI.RadButton();
            this.ButtonLuckyDraw = new Telerik.WinControls.UI.RadButton();
            this.ButtonSetting = new Telerik.WinControls.UI.RadButton();
            this.PictureStriveWinning = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLuckyDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureStriveWinning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.AccessibleDescription = "";
            this.ButtonRegistration.BackgroundImage = global::DoorPrize.Properties.Resources.regTitlex;
            this.ButtonRegistration.Image = global::DoorPrize.Properties.Resources.regTitlex;
            this.ButtonRegistration.Location = new System.Drawing.Point(81, 229);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(483, 211);
            this.ButtonRegistration.TabIndex = 0;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonReport.BackgroundImage")));
            this.ButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReport.Image")));
            this.ButtonReport.Location = new System.Drawing.Point(81, 470);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(483, 208);
            this.ButtonReport.TabIndex = 1;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // ButtonLuckyDraw
            // 
            this.ButtonLuckyDraw.Image = global::DoorPrize.Properties.Resources.luckyDrawBtnx;
            this.ButtonLuckyDraw.Location = new System.Drawing.Point(594, 229);
            this.ButtonLuckyDraw.Name = "ButtonLuckyDraw";
            this.ButtonLuckyDraw.Size = new System.Drawing.Size(665, 449);
            this.ButtonLuckyDraw.TabIndex = 4;
            this.ButtonLuckyDraw.Click += new System.EventHandler(this.ButtonLuckyDraw_Click);
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSetting.BackgroundImage")));
            this.ButtonSetting.Location = new System.Drawing.Point(1293, 641);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(41, 37);
            this.ButtonSetting.TabIndex = 5;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // PictureStriveWinning
            // 
            this.PictureStriveWinning.BackColor = System.Drawing.Color.Transparent;
            this.PictureStriveWinning.BackgroundImage = global::DoorPrize.Properties.Resources.logo_kickoff_meeting__;
            this.PictureStriveWinning.InitialImage = null;
            this.PictureStriveWinning.Location = new System.Drawing.Point(77, 3);
            this.PictureStriveWinning.Name = "PictureStriveWinning";
            this.PictureStriveWinning.Size = new System.Drawing.Size(271, 204);
            this.PictureStriveWinning.TabIndex = 6;
            this.PictureStriveWinning.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoorPrize.Properties.Resources.titleBHPluckyDraw;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(411, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 191);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(1034, 697);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 21);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoorPrize.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1367, 748);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureStriveWinning);
            this.Controls.Add(this.ButtonSetting);
            this.Controls.Add(this.ButtonLuckyDraw);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.ButtonRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenu_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLuckyDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureStriveWinning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton ButtonRegistration;
        private Telerik.WinControls.UI.RadButton ButtonReport;
        private Telerik.WinControls.UI.RadButton ButtonLuckyDraw;
        private Telerik.WinControls.UI.RadButton ButtonSetting;
        private System.Windows.Forms.PictureBox PictureStriveWinning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
