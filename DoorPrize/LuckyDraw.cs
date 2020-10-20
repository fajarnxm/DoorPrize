using DoorPrize.framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace DoorPrize
{
    public partial class LuckyDraw : Telerik.WinControls.UI.RadForm
    {
        public DataTable ShuffleNumber = new DataTable();
        public DataTable WinnerNumber = new DataTable();
        //int ShuffleNumberFlag = 0;
        int Participant = 0;
        string defaultNumber = "0";
        string TotalSession = "0";
        string FileName = "";

        public LuckyDraw()
        {
            InitializeComponent();

            //remove border
            ButtonShuffle.ButtonElement.ShowBorder = false;
            ButtonStop.ButtonElement.ShowBorder = false;
            ButtonleftArrow.ButtonElement.ShowBorder = false;
            ButtonRightArrow.ButtonElement.ShowBorder = false;
            TextShuffle.LabelElement.BorderVisible = false;   

            //alternate
            //this.GridResult1.EnableAlternatingRowColor = true;
            //this.GridResult1.TableElement.AlternatingRowColor = Color.AntiqueWhite;    
        }

        private void LuckyDraw_Load(object sender, EventArgs e)
        {
            GridResult2.Hide();
            GridResult3.Hide();
            GridResult4.Hide();
            //GridResult1.DataSource = WinnerNumber;
            //ShuffleNumber.Columns.Add("Number");
            //WinnerNumber.Columns.Add("Number");

            //using (IDataAccess da = new SQLDataAccess())
            //{
            //using (WinnerNumber = da.ExecuteQuery("EXEC spGetSessionDetail", null))
            //{
            //var rows = WinnerNumber.AsEnumerable().Skip(0).Take(10);
            ClearWinner();
            SetDefaultNumber();
            //DropDownSession.DataSource = GetDataSetting();
            //DropDownSession.DisplayMember = "SessionNumber";
            //DropDownSession.ValueMember = "SessionNumber";
            LabelSession.Text = defaultNumber;
            LabelTotalSession.Text = TotalSession;

            SetDefaultFileName(LabelSession.Text);

            if (GetDataSetting().Rows.Count > 0)
            {
                DataRow[] foundRows = GetDataSetting().Select("SessionNumber='" + Convert.ToInt32(LabelSession.Text) + "'");
                Participant = Convert.ToInt32(foundRows[0][1].ToString());
            }

            string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "DoorPrizeImages" + "\\" + FileName;
            ImageDoorPrize.ImageLocation = fName;
          

            GridResult1.DataSource = WinnerNumber;
                    //WinnerNumber.Columns[0].ReadOnly = false;
                    //WinnerNumber.Columns[0].MaxLength = 500;
                //}
            //}
        }
        
        private void ClearWinner()
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                da.ExecuteNonQuery("EXEC spClearTempWinner", null);
            }
        }

        private void SetDefaultFileName(string SessionNumber)
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                using (DataTable dt = da.ExecuteQuery("EXEC spGetFileNameSetting '" + SessionNumber + "'", null))
                {
                    if (dt.Rows.Count > 0)
                    {
                        FileName = dt.Rows[0][0].ToString();
                    }
                }
            }
        }

        private void SetDefaultNumber()
        {
        using (IDataAccess da = new SQLDataAccess())
            {
                using (DataTable dt = da.ExecuteQuery("EXEC spGetSetting", null))
                {
                    if (dt.Rows.Count > 0)
                    {
                        TotalSession = dt.Rows[0][6].ToString();
                        defaultNumber = dt.Rows[0][0].ToString();
                        FileName = dt.Rows[0][3].ToString();
                    }

                    else
                    {
                        var imagesShuffleDisabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Disable);
                        ButtonShuffle.Image = imagesShuffleDisabled;
                        ButtonShuffle.Enabled = false;

                        ButtonRightArrow.Enabled = false;
                        ButtonleftArrow.Enabled = false;
                    }
                }
            }    
        }

        private DataTable GetDataSetting()
        {
            using(IDataAccess da = new SQLDataAccess())
            {
                using(DataTable dt = da.ExecuteQuery("EXEC spGetSetting", null))
                {
                    return dt;
                }
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            //ButtonShuffle.Text = "Shuffle";
            TimerGetNumber.Start();
            ButtonStop.Enabled = false;
            var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
            ButtonStop.Image = imagesStopDisabled;
            //TextShuffle.Text = "STOP";
            //string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "DoorPrizeImages" + "\\LoadingGif.gif";
            //loadingImage.ImageLocation = "";
        }      

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                SetDefaultNumber();

                string temp = "";
                temp = LabelSession.Text;

                //if (DropDownSession.SelectedIndex <= 0)
                //{
                //    temp = defaultNumber;
                //}

                //else
                //{
                //    temp = DropDownSession.SelectedValue.ToString();
                //}

                using (DataTable dt = da.ExecuteQuery("EXEC spCheckActiveSession '" + temp + "'", null))
                {
                    if (dt.Rows[0][0].ToString().ToUpper() == "TRUE" || dt.Rows[0][0].ToString() == "1")
                    {
                        if (ShuffleNumber.Columns.Contains("NIK"))
                        {
                            ShuffleNumber.Columns.Remove("NIK");
                            ShuffleNumber.Columns.Remove("Name");
                            WinnerNumber.Columns.Remove("NIK");
                            WinnerNumber.Columns.Remove("Name");
                        }

                        ShuffleNumber.Columns.Add("NIK");
                        ShuffleNumber.Columns.Add("Name");
                        WinnerNumber.Columns.Add("NIK");
                        WinnerNumber.Columns.Add("Name");

                        GridResult1.DataSource = WinnerNumber;
                        GridResult1.MasterTemplate.Columns[0].IsVisible = false;
                        //GridResult1.MasterTemplate.Columns[0].Width = 50;
                        //GridResult1.MasterTemplate.Columns[1].Width = 250;

                        //ButtonShuffle.Text = "Stop";
                        ButtonStop.Enabled = true;
                        var imagesStopActive = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Active);
                        var imagesShuffleDisabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Disable);
                        ButtonStop.Image = imagesStopActive;
                        ButtonShuffle.Image = imagesShuffleDisabled;
                        ButtonShuffle.Enabled = false;

                        ButtonRightArrow.Enabled = false;
                        ButtonleftArrow.Enabled = false;

                        TimerShuffle.Start();

                        //string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        //string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "DoorPrizeImages" + "\\Loading.gif";
                        //loadingImage.ImageLocation = fName;
                    }
                    else
                    {
                        MessageBox.Show("This Session Already Closed!!!");
                    }
                }
            }
        }

        private void TimerShuffle_Tick(object sender, EventArgs e)
        {
            using(IDataAccess da = new SQLDataAccess())
            {
                string temp = "";
                temp = LabelSession.Text;

                //string temp = DropDownSession.SelectedValue.ToString();

                //if (DropDownSession.SelectedIndex == 0)
                //{
                //    temp = defaultNumber;
                //}

                using (DataTable dt = da.ExecuteQuery("EXEC spGenerateRandomNumber '" + temp + "'", null))
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = ShuffleNumber.NewRow();
                        dr[0] = dt.Rows[0][0].ToString();
                        dr[1] = dt.Rows[0][1].ToString();

                        ShuffleNumber.Rows.Add(dr);
                    }

                    //ShuffleNumber.Rows.Add(dt.Rows[0][1].ToString());
                    if (ShuffleNumber.Rows.Count > 0)
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(0, ShuffleNumber.Rows.Count - 1);
                        TextShuffle.Text = ShuffleNumber.Rows[randomNumber][1].ToString();
                    }
                }
            }
        }

        private void TimerGetNumber_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            if (ShuffleNumber.Rows.Count >= 0)
            {
                if(WinnerNumber.Rows.Count == Participant || ShuffleNumber.Rows.Count <= 0)
                {
                    TimerGetNumber.Stop();
                    TimerShuffle.Stop();
                    //set winner name
                    TextShuffle.Text = WinnerNumber.Rows[0][1].ToString();
                    string temp = "";
                    temp = LabelSession.Text;
                    //if (DropDownSession.SelectedIndex <= 0)
                    //{
                    //    temp = defaultNumber;
                    //}

                    //else
                    //{
                    //    temp = DropDownSession.SelectedValue.ToString();
                    //}

                    using (IDataAccess da = new SQLDataAccess())
                    {
                        for (int i = 0; i < WinnerNumber.Rows.Count; i++)
                        {
                            da.ExecuteNonQuery("EXEC spInsertWinner '" + temp + "', '" + WinnerNumber.Rows[i][0].ToString() + "', '" + WinnerNumber.Rows[i][1].ToString() + "'", null);
                        }

                        da.ExecuteNonQuery("spUpdateActiveFlagSetting '" + temp + "'", null);

                        //DropDownSession.DataSource = GetDataSetting();
                        //DropDownSession.DisplayMember = "SessionNumber";
                        //DropDownSession.ValueMember = "SessionNumber";

                        ButtonStop.Enabled = false;
                        var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
                        //var imagesShuffleEnabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Active);
                        ButtonStop.Image = imagesStopDisabled;
                        //ButtonShuffle.Image = imagesShuffleEnabled;
                        //ButtonShuffle.Enabled = true; 

                        ButtonRightArrow.Enabled = true;
                        ButtonleftArrow.Enabled = true;

                        ClearWinner();
                    }
                    //MessageBox.Show("Congratulations For The Winner");                 
                }

                int randomNumber = random.Next(0, ShuffleNumber.Rows.Count - 1);

                DataRow dr = WinnerNumber.NewRow();
                dr[0] = ShuffleNumber.Rows[randomNumber][0].ToString();
                dr[1] = ShuffleNumber.Rows[randomNumber][1].ToString();

                WinnerNumber.Rows.Add(dr);
                ShuffleNumber.Rows[randomNumber].Delete();
                //WinnerNumber.Rows.Add(ShuffleNumber.Rows[randomNumber][0].ToString());

                //WinnerNumber.Rows[ShuffleNumberFlag]["Winner"] = ShuffleNumber.Rows[randomNumber][0].ToString();
                //var a = WinnerNumber.AsEnumerable().Se
                if (WinnerNumber.Rows.Count <= Participant)
                {
                    GridResult1.DataSource = WinnerNumber.AsEnumerable().Skip(0).Take(10).CopyToDataTable();
                   
                    if (WinnerNumber.Rows.Count > 10 && WinnerNumber.Rows.Count <= 20)
                    {
                        GridResult2.DataSource = WinnerNumber.AsEnumerable().Skip(10).Take(20).CopyToDataTable();
                        GridResult2.MasterTemplate.Columns[0].IsVisible = false;
                        //GridResult1.MasterTemplate.Columns[0].Width = 50;
                        //GridResult1.MasterTemplate.Columns[1].Width = 250;
                    }

                    if (WinnerNumber.Rows.Count > 20 && WinnerNumber.Rows.Count <= 30)
                    {
                        GridResult3.DataSource = WinnerNumber.AsEnumerable().Skip(20).Take(30).CopyToDataTable();
                        GridResult3.MasterTemplate.Columns[0].IsVisible = false;
                        //GridResult1.MasterTemplate.Columns[0].Width = 50;
                        //GridResult1.MasterTemplate.Columns[1].Width = 250;
                    }

                    if (WinnerNumber.Rows.Count > 30 && WinnerNumber.Rows.Count <= 40)
                    {
                        GridResult4.DataSource = WinnerNumber.AsEnumerable().Skip(30).Take(40).CopyToDataTable();
                        GridResult4.MasterTemplate.Columns[0].IsVisible = false;
                        //GridResult1.MasterTemplate.Columns[0].Width = 50;
                        //GridResult1.MasterTemplate.Columns[1].Width = 250;
                    }
                }
            }
        }

        private void ButtonleftArrow_Click(object sender, EventArgs e)
        {
            SetDefaultNumber();

            string temp = "";
            
            LabelSession.Text = (Convert.ToInt32(LabelSession.Text) - 1).ToString();

            if (Convert.ToInt32(LabelSession.Text) - 1 <= 0)
            {
                LabelSession.Text = "1";
            }

            temp = LabelSession.Text;

            //if (DropDownSession.SelectedIndex <= 0)
            //{
            //    temp = defaultNumber;
            //}

            //else 
            //{
            //    temp = DropDownSession.SelectedValue.ToString();
            //}

            using (IDataAccess da = new SQLDataAccess())
            {
                using (DataTable dt = da.ExecuteQuery("EXEC spCheckActiveSession '" + temp + "'", null))
                {
                    if (dt.Rows[0][0].ToString() == "1" || dt.Rows[0][0].ToString().ToUpper() == "TRUE")
                    {
                        ButtonShuffle.Enabled = true;
                        var imagesShuffleEnabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Active);
                        ButtonShuffle.Image = imagesShuffleEnabled;

                        ButtonStop.Enabled = false;
                        var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
                        ButtonStop.Image = imagesStopDisabled;

                        DataRow[] foundRows = GetDataSetting().Select("SessionNumber='" + Convert.ToInt32(temp) + "'");
                        Participant = Convert.ToInt32(foundRows[0][1].ToString());

                        SetDefaultFileName(temp);
                    }

                    else
                    {
                        ButtonStop.Enabled = false;
                        var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
                        ButtonStop.Image = imagesStopDisabled;

                        ButtonShuffle.Enabled = false;
                        var imagesShuffleDisabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Disable);
                        ButtonShuffle.Image = imagesShuffleDisabled;
                    }
                }
            }

            try
            {
                string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "DoorPrizeImages" + "\\" + FileName;
                ImageDoorPrize.ImageLocation = fName;
              

                WinnerNumber.Clear();
                ShuffleNumber.Clear();

                GridResult1.DataSource = null;
                GridResult2.DataSource = null;
                GridResult3.DataSource = null;
                GridResult4.DataSource = null;

                //DropDownSession.DataSource = GetDataSetting();
                //DropDownSession.DisplayMember = "SessionNumber";
                //DropDownSession.ValueMember = "SessionNumber";
            }

            catch (Exception exxx)
            {

            }
        }

        private void ButtonRightArrow_Click(object sender, EventArgs e)
        {
            SetDefaultNumber();

            string temp = "";

            LabelSession.Text = (Convert.ToInt32(LabelSession.Text) + 1).ToString();

            if (Convert.ToInt32(LabelSession.Text) + 1 > Convert.ToInt32(LabelTotalSession.Text))
            {
                LabelSession.Text = LabelTotalSession.Text;
            }

            temp = LabelSession.Text;
            //if (DropDownSession.SelectedIndex <= 0)
            //{
            //    temp = defaultNumber;
            //}

            //else 
            //{
            //    temp = DropDownSession.SelectedValue.ToString();
            //}

            using(IDataAccess da = new SQLDataAccess())
            {
                using(DataTable dt = da.ExecuteQuery("EXEC spCheckActiveSession '"+ temp +"'", null))
                {
                    if(dt.Rows[0][0].ToString() == "1" || dt.Rows[0][0].ToString().ToUpper() == "TRUE")
                    {
                        ButtonShuffle.Enabled = true;
                        var imagesShuffleEnabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Active);
                        ButtonShuffle.Image = imagesShuffleEnabled;

                        ButtonStop.Enabled = false;
                        var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
                        ButtonStop.Image = imagesStopDisabled;

                        DataRow[] foundRows = GetDataSetting().Select("SessionNumber='" + Convert.ToInt32(temp) + "'");
                        Participant = Convert.ToInt32(foundRows[0][1].ToString());

                        SetDefaultFileName(temp);
                    }

                    else
                    {
                        ButtonStop.Enabled = false;
                        var imagesStopDisabled = new Bitmap(DoorPrize.Properties.Resources.Stop_Btn_Disable);
                        ButtonStop.Image = imagesStopDisabled;

                        ButtonShuffle.Enabled = false;
                        var imagesShuffleDisabled = new Bitmap(DoorPrize.Properties.Resources.Suffle_Btn_Disable);
                        ButtonShuffle.Image = imagesShuffleDisabled;
                    }
                }
            }

            try
            {
                string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "DoorPrizeImages" + "\\" + FileName;
                ImageDoorPrize.ImageLocation = fName;
               

                WinnerNumber.Clear();
                ShuffleNumber.Clear();

                GridResult1.DataSource = null;
                GridResult2.DataSource = null;
                GridResult3.DataSource = null;
                GridResult4.DataSource = null;

                //DropDownSession.DataSource = GetDataSetting();
                //DropDownSession.DisplayMember = "SessionNumber";
                //DropDownSession.ValueMember = "SessionNumber";
            }

            catch(Exception exxx)
            {

            }
        }

        private void LuckyDraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TextShuffle_Click(object sender, EventArgs e)
        {

        }
    }
}
