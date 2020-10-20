namespace DoorPrize
{
    partial class Registration
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
            this.LabelRegistration = new System.Windows.Forms.Label();
            this.TextName = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.LinkFullVersion = new System.Windows.Forms.LinkLabel();
            this.LabelNotif = new System.Windows.Forms.Label();
            this.LabelNumberAttendance = new System.Windows.Forms.Label();
            this.LabelTotalAttendance = new System.Windows.Forms.Label();
            this.TimerNumberAttendance = new System.Windows.Forms.Timer(this.components);
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TextName2 = new Telerik.WinControls.UI.RadAutoCompleteBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRegistration
            // 
            this.LabelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.LabelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistration.ForeColor = System.Drawing.Color.Maroon;
            this.LabelRegistration.Location = new System.Drawing.Point(268, 34);
            this.LabelRegistration.Name = "LabelRegistration";
            this.LabelRegistration.Size = new System.Drawing.Size(410, 148);
            this.LabelRegistration.TabIndex = 4;
            this.LabelRegistration.Text = "Regis";
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.LightYellow;
            this.TextName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(496, 288);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(503, 36);
            this.TextName.TabIndex = 5;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            this.TextName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextName_KeyPress);
            // 
            // LinkFullVersion
            // 
            this.LinkFullVersion.AutoSize = true;
            this.LinkFullVersion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LinkFullVersion.Location = new System.Drawing.Point(904, 549);
            this.LinkFullVersion.Name = "LinkFullVersion";
            this.LinkFullVersion.Size = new System.Drawing.Size(112, 28);
            this.LinkFullVersion.TabIndex = 9;
            this.LinkFullVersion.TabStop = true;
            this.LinkFullVersion.Text = "Full Version";
            this.LinkFullVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFullVersion_LinkClicked);
            // 
            // LabelNotif
            // 
            this.LabelNotif.BackColor = System.Drawing.Color.Transparent;
            this.LabelNotif.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelNotif.Location = new System.Drawing.Point(394, 430);
            this.LabelNotif.Name = "LabelNotif";
            this.LabelNotif.Size = new System.Drawing.Size(521, 86);
            this.LabelNotif.TabIndex = 10;
            this.LabelNotif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelNumberAttendance
            // 
            this.LabelNumberAttendance.AutoSize = true;
            this.LabelNumberAttendance.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberAttendance.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelNumberAttendance.Location = new System.Drawing.Point(490, 558);
            this.LabelNumberAttendance.Name = "LabelNumberAttendance";
            this.LabelNumberAttendance.Size = new System.Drawing.Size(249, 24);
            this.LabelNumberAttendance.TabIndex = 21;
            this.LabelNumberAttendance.Text = "Number Of Attendance";
            // 
            // LabelTotalAttendance
            // 
            this.LabelTotalAttendance.AutoSize = true;
            this.LabelTotalAttendance.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalAttendance.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelTotalAttendance.Location = new System.Drawing.Point(745, 558);
            this.LabelTotalAttendance.Name = "LabelTotalAttendance";
            this.LabelTotalAttendance.Size = new System.Drawing.Size(54, 24);
            this.LabelTotalAttendance.TabIndex = 22;
            this.LabelTotalAttendance.Text = "0000";
            // 
            // TimerNumberAttendance
            // 
            this.TimerNumberAttendance.Interval = 500;
            this.TimerNumberAttendance.Tick += new System.EventHandler(this.TimerNumberAttendance_Tick);
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(630, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 148);
            this.label1.TabIndex = 23;
            this.label1.Text = "tration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 40);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 40);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email  :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(595, 396);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 31);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TextName2
            // 
            this.TextName2.BackColor = System.Drawing.Color.LightYellow;
            this.TextName2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName2.Location = new System.Drawing.Point(496, 335);
            this.TextName2.Name = "TextName2";
            this.TextName2.Size = new System.Drawing.Size(503, 36);
            this.TextName2.TabIndex = 27;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DoorPrize.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1229, 558);
            this.Controls.Add(this.TextName2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTotalAttendance);
            this.Controls.Add(this.LabelNumberAttendance);
            this.Controls.Add(this.LabelNotif);
            this.Controls.Add(this.LinkFullVersion);
            this.Controls.Add(this.LabelRegistration);
            this.Controls.Add(this.TextName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Registration";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registration_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Registration_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TextName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRegistration;
        private Telerik.WinControls.UI.RadAutoCompleteBox TextName;
        private System.Windows.Forms.LinkLabel LinkFullVersion;
        private System.Windows.Forms.Label LabelNotif;
        private System.Windows.Forms.Label LabelNumberAttendance;
        private System.Windows.Forms.Label LabelTotalAttendance;
        private System.Windows.Forms.Timer TimerNumberAttendance;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private Telerik.WinControls.UI.RadAutoCompleteBox TextName2;
    }
}
