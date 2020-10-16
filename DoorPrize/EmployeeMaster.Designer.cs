namespace DoorPrize
{
    partial class EmployeeMaster
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
            this.LabelEmployeeMaster = new System.Windows.Forms.Label();
            this.GridEmployeeMaster = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeMaster.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelEmployeeMaster
            // 
            this.LabelEmployeeMaster.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmployeeMaster.Font = new System.Drawing.Font("Stencil", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelEmployeeMaster.ForeColor = System.Drawing.Color.White;
            this.LabelEmployeeMaster.Location = new System.Drawing.Point(226, 9);
            this.LabelEmployeeMaster.Name = "LabelEmployeeMaster";
            this.LabelEmployeeMaster.Size = new System.Drawing.Size(961, 101);
            this.LabelEmployeeMaster.TabIndex = 5;
            this.LabelEmployeeMaster.Text = "Employee Master";
            // 
            // GridEmployeeMaster
            // 
            this.GridEmployeeMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.GridEmployeeMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridEmployeeMaster.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridEmployeeMaster.ForeColor = System.Drawing.Color.Black;
            this.GridEmployeeMaster.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridEmployeeMaster.Location = new System.Drawing.Point(246, 200);
            // 
            // 
            // 
            this.GridEmployeeMaster.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridEmployeeMaster.MasterTemplate.EnableFiltering = true;
            this.GridEmployeeMaster.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridEmployeeMaster.Name = "GridEmployeeMaster";
            this.GridEmployeeMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridEmployeeMaster.Size = new System.Drawing.Size(919, 359);
            this.GridEmployeeMaster.TabIndex = 6;
            this.GridEmployeeMaster.Text = "radGridView1";
            this.GridEmployeeMaster.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.GridEmployeeMaster_UserAddedRow);
            this.GridEmployeeMaster.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridEmployeeMaster_CellValueChanged);
            // 
            // EmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoorPrize.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1278, 571);
            this.Controls.Add(this.GridEmployeeMaster);
            this.Controls.Add(this.LabelEmployeeMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "EmployeeMaster";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EmployeeMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeMaster_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeMaster_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeMaster.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelEmployeeMaster;
        private Telerik.WinControls.UI.RadGridView GridEmployeeMaster;
    }
}
