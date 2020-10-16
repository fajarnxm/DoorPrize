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
    public partial class MainMenu : Telerik.WinControls.UI.RadForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void ButtonLuckyDraw_Click(object sender, EventArgs e)
        {
            LuckyDraw ld = new LuckyDraw();
            ld.Show();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            Setting st = new Setting();
            st.Show();
        }

        private void MainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
