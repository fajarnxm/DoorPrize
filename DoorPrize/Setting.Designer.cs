namespace DoorPrize
{
    partial class Setting
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.LabelSetting = new System.Windows.Forms.Label();
            this.LabelSessionRules = new System.Windows.Forms.Label();
            this.GridSetting = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSetting.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSetting
            // 
            this.LabelSetting.BackColor = System.Drawing.Color.Transparent;
            this.LabelSetting.Font = new System.Drawing.Font("Stencil", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelSetting.ForeColor = System.Drawing.Color.White;
            this.LabelSetting.Location = new System.Drawing.Point(416, -2);
            this.LabelSetting.Name = "LabelSetting";
            this.LabelSetting.Size = new System.Drawing.Size(455, 101);
            this.LabelSetting.TabIndex = 6;
            this.LabelSetting.Text = "Setting";
            // 
            // LabelSessionRules
            // 
            this.LabelSessionRules.AutoSize = true;
            this.LabelSessionRules.BackColor = System.Drawing.Color.Transparent;
            this.LabelSessionRules.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSessionRules.ForeColor = System.Drawing.Color.White;
            this.LabelSessionRules.Location = new System.Drawing.Point(182, 110);
            this.LabelSessionRules.Name = "LabelSessionRules";
            this.LabelSessionRules.Size = new System.Drawing.Size(254, 39);
            this.LabelSessionRules.TabIndex = 10;
            this.LabelSessionRules.Text = "Session Rules";
            // 
            // GridSetting
            // 
            this.GridSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.GridSetting.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridSetting.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridSetting.ForeColor = System.Drawing.Color.Black;
            this.GridSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridSetting.Location = new System.Drawing.Point(179, 170);
            // 
            // 
            // 
            this.GridSetting.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridSetting.MasterTemplate.EnableFiltering = true;
            this.GridSetting.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridSetting.Name = "GridSetting";
            this.GridSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridSetting.Size = new System.Drawing.Size(915, 396);
            this.GridSetting.TabIndex = 11;
            this.GridSetting.Text = "radGridView1";
            this.GridSetting.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.GridSetting_UserAddedRow);
            this.GridSetting.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridSetting_CellValueChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 608);
            this.Controls.Add(this.GridSetting);
            this.Controls.Add(this.LabelSessionRules);
            this.Controls.Add(this.LabelSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Setting";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Setting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Setting_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Setting_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GridSetting.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSetting;
        private System.Windows.Forms.Label LabelSessionRules;
        private Telerik.WinControls.UI.RadGridView GridSetting;
    }
}
