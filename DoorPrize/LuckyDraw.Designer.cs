namespace DoorPrize
{
    partial class LuckyDraw
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyDraw));
            this.GridResult1 = new Telerik.WinControls.UI.RadGridView();
            this.TimerShuffle = new System.Windows.Forms.Timer(this.components);
            this.TimerGetNumber = new System.Windows.Forms.Timer(this.components);
            this.GridResult2 = new Telerik.WinControls.UI.RadGridView();
            this.GridResult3 = new Telerik.WinControls.UI.RadGridView();
            this.LabelPickSession = new System.Windows.Forms.Label();
            this.TextShuffle = new Telerik.WinControls.UI.RadLabel();
            this.ButtonShuffle = new Telerik.WinControls.UI.RadButton();
            this.ButtonStop = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.GridResult4 = new Telerik.WinControls.UI.RadGridView();
            this.LabelSession = new System.Windows.Forms.Label();
            this.ButtonRightArrow = new Telerik.WinControls.UI.RadButton();
            this.ButtonleftArrow = new Telerik.WinControls.UI.RadButton();
            this.LabelOF = new System.Windows.Forms.Label();
            this.LabelTotalSession = new System.Windows.Forms.Label();
            this.ImageDoorPrize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult3.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult4.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonleftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDoorPrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridResult1
            // 
            this.GridResult1.AutoSizeRows = true;
            this.GridResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.GridResult1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridResult1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridResult1.ForeColor = System.Drawing.Color.Black;
            this.GridResult1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridResult1.Location = new System.Drawing.Point(433, 446);
            // 
            // 
            // 
            this.GridResult1.MasterTemplate.AllowAddNewRow = false;
            this.GridResult1.MasterTemplate.AllowColumnReorder = false;
            this.GridResult1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridResult1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridResult1.Name = "GridResult1";
            this.GridResult1.ReadOnly = true;
            this.GridResult1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridResult1.ShowGroupPanel = false;
            this.GridResult1.Size = new System.Drawing.Size(460, 290);
            this.GridResult1.TabIndex = 6;
            this.GridResult1.Text = "radGridView1";
            this.GridResult1.ThemeName = "VisualStudio2012Dark";
            // 
            // TimerShuffle
            // 
            this.TimerShuffle.Interval = 50;
            this.TimerShuffle.Tick += new System.EventHandler(this.TimerShuffle_Tick);
            // 
            // TimerGetNumber
            // 
            this.TimerGetNumber.Interval = 2000;
            this.TimerGetNumber.Tick += new System.EventHandler(this.TimerGetNumber_Tick);
            // 
            // GridResult2
            // 
            this.GridResult2.AccessibleDescription = "";
            this.GridResult2.AutoSizeRows = true;
            this.GridResult2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridResult2.Location = new System.Drawing.Point(1188, 454);
            // 
            // 
            // 
            this.GridResult2.MasterTemplate.AllowAddNewRow = false;
            this.GridResult2.MasterTemplate.AllowColumnChooser = false;
            this.GridResult2.MasterTemplate.AllowColumnReorder = false;
            this.GridResult2.MasterTemplate.AllowColumnResize = false;
            this.GridResult2.MasterTemplate.AllowDragToGroup = false;
            this.GridResult2.MasterTemplate.AllowRowResize = false;
            this.GridResult2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridResult2.MasterTemplate.EnableGrouping = false;
            this.GridResult2.MasterTemplate.EnableSorting = false;
            this.GridResult2.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GridResult2.Name = "GridResult2";
            this.GridResult2.ReadOnly = true;
            this.GridResult2.Size = new System.Drawing.Size(130, 66);
            this.GridResult2.TabIndex = 7;
            this.GridResult2.Text = "radGridView1";
            this.GridResult2.ThemeName = "VisualStudio2012Dark";
            // 
            // GridResult3
            // 
            this.GridResult3.AutoSizeRows = true;
            this.GridResult3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.GridResult3.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridResult3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridResult3.ForeColor = System.Drawing.Color.Black;
            this.GridResult3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridResult3.Location = new System.Drawing.Point(1188, 526);
            // 
            // 
            // 
            this.GridResult3.MasterTemplate.AllowAddNewRow = false;
            this.GridResult3.MasterTemplate.AllowColumnChooser = false;
            this.GridResult3.MasterTemplate.AllowColumnReorder = false;
            this.GridResult3.MasterTemplate.AllowColumnResize = false;
            this.GridResult3.MasterTemplate.AllowDragToGroup = false;
            this.GridResult3.MasterTemplate.AllowRowResize = false;
            this.GridResult3.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridResult3.MasterTemplate.EnableGrouping = false;
            this.GridResult3.MasterTemplate.EnableSorting = false;
            this.GridResult3.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.GridResult3.Name = "GridResult3";
            this.GridResult3.ReadOnly = true;
            this.GridResult3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridResult3.Size = new System.Drawing.Size(135, 80);
            this.GridResult3.TabIndex = 7;
            this.GridResult3.Text = "radGridView1";
            this.GridResult3.ThemeName = "VisualStudio2012Dark";
            // 
            // LabelPickSession
            // 
            this.LabelPickSession.AutoSize = true;
            this.LabelPickSession.BackColor = System.Drawing.Color.Transparent;
            this.LabelPickSession.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPickSession.ForeColor = System.Drawing.Color.White;
            this.LabelPickSession.Location = new System.Drawing.Point(1173, 19);
            this.LabelPickSession.Name = "LabelPickSession";
            this.LabelPickSession.Size = new System.Drawing.Size(119, 18);
            this.LabelPickSession.TabIndex = 10;
            this.LabelPickSession.Text = "PICK SESSION";
            // 
            // TextShuffle
            // 
            this.TextShuffle.AutoSize = false;
            this.TextShuffle.BackColor = System.Drawing.Color.Transparent;
            this.TextShuffle.BorderVisible = true;
            this.TextShuffle.Font = new System.Drawing.Font("Stencil", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShuffle.ForeColor = System.Drawing.Color.Goldenrod;
            this.TextShuffle.Location = new System.Drawing.Point(149, 153);
            this.TextShuffle.Name = "TextShuffle";
            this.TextShuffle.Size = new System.Drawing.Size(204, 92);
            this.TextShuffle.TabIndex = 12;
            this.TextShuffle.Click += new System.EventHandler(this.TextShuffle_Click);
            // 
            // ButtonShuffle
            // 
            this.ButtonShuffle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonShuffle.Image = global::DoorPrize.Properties.Resources.Suffle_Btn_Active;
            this.ButtonShuffle.Location = new System.Drawing.Point(385, 122);
            this.ButtonShuffle.Name = "ButtonShuffle";
            // 
            // 
            // 
            this.ButtonShuffle.RootElement.FocusBorderColor = System.Drawing.Color.Transparent;
            this.ButtonShuffle.RootElement.FocusBorderWidth = 0;
            this.ButtonShuffle.Size = new System.Drawing.Size(133, 131);
            this.ButtonShuffle.TabIndex = 15;
            this.ButtonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStop.Enabled = false;
            this.ButtonStop.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonStop.Image = global::DoorPrize.Properties.Resources.Stop_Btn_Disable;
            this.ButtonStop.Location = new System.Drawing.Point(849, 122);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(135, 131);
            this.ButtonStop.TabIndex = 16;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // GridResult4
            // 
            this.GridResult4.AutoSizeRows = true;
            this.GridResult4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.GridResult4.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridResult4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridResult4.ForeColor = System.Drawing.Color.Black;
            this.GridResult4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridResult4.Location = new System.Drawing.Point(1188, 612);
            // 
            // 
            // 
            this.GridResult4.MasterTemplate.AllowAddNewRow = false;
            this.GridResult4.MasterTemplate.AllowColumnChooser = false;
            this.GridResult4.MasterTemplate.AllowColumnReorder = false;
            this.GridResult4.MasterTemplate.AllowColumnResize = false;
            this.GridResult4.MasterTemplate.AllowDragToGroup = false;
            this.GridResult4.MasterTemplate.AllowRowResize = false;
            this.GridResult4.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridResult4.MasterTemplate.EnableGrouping = false;
            this.GridResult4.MasterTemplate.EnableSorting = false;
            this.GridResult4.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.GridResult4.Name = "GridResult4";
            this.GridResult4.ReadOnly = true;
            this.GridResult4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridResult4.Size = new System.Drawing.Size(166, 124);
            this.GridResult4.TabIndex = 8;
            this.GridResult4.Text = "radGridView1";
            this.GridResult4.ThemeName = "VisualStudio2012Dark";
            // 
            // LabelSession
            // 
            this.LabelSession.AutoSize = true;
            this.LabelSession.BackColor = System.Drawing.Color.Transparent;
            this.LabelSession.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSession.ForeColor = System.Drawing.Color.White;
            this.LabelSession.Location = new System.Drawing.Point(1294, 19);
            this.LabelSession.Name = "LabelSession";
            this.LabelSession.Size = new System.Drawing.Size(19, 18);
            this.LabelSession.TabIndex = 19;
            this.LabelSession.Text = "X";
            // 
            // ButtonRightArrow
            // 
            this.ButtonRightArrow.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRightArrow.Image = global::DoorPrize.Properties.Resources.right_black_arrow;
            this.ButtonRightArrow.Location = new System.Drawing.Point(804, 153);
            this.ButtonRightArrow.Name = "ButtonRightArrow";
            this.ButtonRightArrow.Size = new System.Drawing.Size(25, 56);
            this.ButtonRightArrow.TabIndex = 20;
            this.ButtonRightArrow.Click += new System.EventHandler(this.ButtonRightArrow_Click);
            // 
            // ButtonleftArrow
            // 
            this.ButtonleftArrow.BackColor = System.Drawing.Color.Transparent;
            this.ButtonleftArrow.Image = global::DoorPrize.Properties.Resources.left_black_arrow;
            this.ButtonleftArrow.Location = new System.Drawing.Point(541, 153);
            this.ButtonleftArrow.Name = "ButtonleftArrow";
            // 
            // 
            // 
            this.ButtonleftArrow.RootElement.AutoSize = true;
            this.ButtonleftArrow.RootElement.FocusBorderColor = System.Drawing.Color.Transparent;
            this.ButtonleftArrow.RootElement.FocusBorderWidth = 0;
            this.ButtonleftArrow.Size = new System.Drawing.Size(26, 56);
            this.ButtonleftArrow.TabIndex = 21;
            this.ButtonleftArrow.Click += new System.EventHandler(this.ButtonleftArrow_Click);
            // 
            // LabelOF
            // 
            this.LabelOF.AutoSize = true;
            this.LabelOF.BackColor = System.Drawing.Color.Transparent;
            this.LabelOF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOF.ForeColor = System.Drawing.Color.White;
            this.LabelOF.Location = new System.Drawing.Point(1309, 19);
            this.LabelOF.Name = "LabelOF";
            this.LabelOF.Size = new System.Drawing.Size(30, 18);
            this.LabelOF.TabIndex = 22;
            this.LabelOF.Text = "OF";
            // 
            // LabelTotalSession
            // 
            this.LabelTotalSession.AutoSize = true;
            this.LabelTotalSession.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalSession.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSession.ForeColor = System.Drawing.Color.White;
            this.LabelTotalSession.Location = new System.Drawing.Point(1335, 19);
            this.LabelTotalSession.Name = "LabelTotalSession";
            this.LabelTotalSession.Size = new System.Drawing.Size(19, 18);
            this.LabelTotalSession.TabIndex = 23;
            this.LabelTotalSession.Text = "X";
            // 
            // ImageDoorPrize
            // 
            this.ImageDoorPrize.BackColor = System.Drawing.Color.Transparent;
            this.ImageDoorPrize.Location = new System.Drawing.Point(216, 284);
            this.ImageDoorPrize.Name = "ImageDoorPrize";
            this.ImageDoorPrize.Size = new System.Drawing.Size(883, 137);
            this.ImageDoorPrize.TabIndex = 9;
            this.ImageDoorPrize.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoorPrize.Properties.Resources.titleBHPluckyDrawxx;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1367, 122);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // loadingImage
            // 
            this.loadingImage.BackColor = System.Drawing.Color.Transparent;
            this.loadingImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("loadingImage.InitialImage")));
            this.loadingImage.Location = new System.Drawing.Point(615, 122);
            this.loadingImage.Name = "loadingImage";
            this.loadingImage.Size = new System.Drawing.Size(150, 150);
            this.loadingImage.TabIndex = 25;
            this.loadingImage.TabStop = false;
            // 
            // LuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoorPrize.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1361, 738);
            this.Controls.Add(this.loadingImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTotalSession);
            this.Controls.Add(this.LabelOF);
            this.Controls.Add(this.ButtonleftArrow);
            this.Controls.Add(this.ButtonRightArrow);
            this.Controls.Add(this.LabelSession);
            this.Controls.Add(this.GridResult4);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonShuffle);
            this.Controls.Add(this.TextShuffle);
            this.Controls.Add(this.LabelPickSession);
            this.Controls.Add(this.ImageDoorPrize);
            this.Controls.Add(this.GridResult2);
            this.Controls.Add(this.GridResult3);
            this.Controls.Add(this.GridResult1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LuckyDraw";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LuckyDraw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LuckyDraw_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LuckyDraw_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult3.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult4.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonleftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDoorPrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView GridResult1;
        private System.Windows.Forms.Timer TimerShuffle;
        private System.Windows.Forms.Timer TimerGetNumber;
        private Telerik.WinControls.UI.RadGridView GridResult2;
        private Telerik.WinControls.UI.RadGridView GridResult3;
        private System.Windows.Forms.Label LabelPickSession;
        private Telerik.WinControls.UI.RadLabel TextShuffle;
        private Telerik.WinControls.UI.RadButton ButtonShuffle;
        private Telerik.WinControls.UI.RadButton ButtonStop;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadGridView GridResult4;
        private System.Windows.Forms.Label LabelSession;
        private Telerik.WinControls.UI.RadButton ButtonRightArrow;
        private Telerik.WinControls.UI.RadButton ButtonleftArrow;
        private System.Windows.Forms.Label LabelOF;
        private System.Windows.Forms.Label LabelTotalSession;
        private System.Windows.Forms.PictureBox ImageDoorPrize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loadingImage;
    }
}
