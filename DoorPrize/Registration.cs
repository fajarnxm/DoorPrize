using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DoorPrize.framework;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace DoorPrize
{
    public partial class Registration : Telerik.WinControls.UI.RadForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //TextName.Items.CollectionChanged += Items_CollectionChanged;
            //
            //TextName.AutoCompleteDataSource = GetAutoComplete();
            //TextName.AutoCompleteDisplayMember = "EmployeeName";
            //TextName.AutoCompleteValueMember = "EmployeeKey";

            using (IDataAccess da = new SQLDataAccess())
            {
                LabelTotalAttendance.Text = da.ExecuteQuery("EXEC spGetNumberOfAttendance", null).Rows[0][0].ToString();
                TimerNumberAttendance.Start();
            }          
        }

        //void Items_CollectionChanged(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.ItemChanged)
        //    {
        //        string str1 = e.NewItems[0].ToString();

        //        int secondIndex = str1.IndexOf('=', str1.IndexOf('=') + 1);
        //        str1 = str1.Substring(secondIndex + 1);

        //        RadTokenizedTextItemCollection items = sender as RadTokenizedTextItemCollection;

        //        DataRow[] foundRows = GetAutoComplete().Select("EmployeeKey='" + str1 + "'");

        //        LabelDepartment.Text = foundRows[0].ItemArray[2].ToString();
        //    }
        //}

        private DataTable GetAutoComplete()
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                using (DataTable dt = da.ExecuteQuery("EXEC spGetDataEmployeeAutoComplete", null))
                {
                    return dt;
                }
            }
        }

        //private void ButtonSubmit_Click(object sender, EventArgs e)
        //{
        //    using(IDataAccess da = new SQLDataAccess())
        //    {
        //        using (IDbTransaction tran = da.BeginTran())
        //        {
        //            try
        //            {
        //                for (int i = 0; i < TextName.Items.Count; i++)
        //                {
        //                    da.ExecuteNonQuery("EXEC SpUpdateFlagAbsensi '" + TextName.Items[i].Value + "'", null, tran);
        //                }

        //                tran.Commit();

        //                MessageBox.Show("Absence Successfully Inputed");             
        //                //TextName.AutoCompleteDataSource = GetAutoComplete();
        //                TextName.Clear();
        //                LabelDepartment.Text = null;
        //            }

        //            catch (Exception err)
        //            {
        //                tran.Rollback();
        //            }
        //        }
        //    }
        //}

        private void TextName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(TextName.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                using (IDataAccess da = new SQLDataAccess())

           
                {
                    using (DataTable dt = da.ExecuteQuery("EXEC spGetCardNumberData '" + TextName.Text + "'", null))
                    {
                        if (dt.Rows.Count == 0)
                        {
                            LabelNotif.Text = "Registration Failed!";
                            TextName.Clear();
                            //LabelDepartment.Text = null;
                            return;
                        }

                        TextName.Text = dt.Rows[0]["EmployeeName"].ToString();
                        //LabelDepartment.Text = dt.Rows[0]["DeptName"].ToString();
                        //using (IDbTransaction tran = da.BeginTran())
                        //{
                        try
                        {

                            int test = -1;


                            Dictionary<string, object> vars = new Dictionary<string, object>();
                            vars.Add("@EMPLID", dt.Rows[0]["EmployeeKey"].ToString());


                            test = da.ExecuteNonQueryR("SpUpdateFlagAbsensi", vars);

                            //tran.Commit();
                            ///MessageBox.Show("Registration For "+dt.Rows[0]["EmployeeName"].ToString()+ ", Department:" + dt.Rows[0]["DeptName"].ToString() +" Has Success!");
                            //TextName.AutoCompleteDataSource = GetAutoComplete();
                            //LabelNotif.ForeColor = Color.Green;

                            if (test == 1)
                                LabelNotif.Text = "Registration For " + dt.Rows[0]["EmployeeName"].ToString() + ", Department:" + dt.Rows[0]["DeptName"].ToString() + " Has Success!";
                            else
                                LabelNotif.Text = dt.Rows[0]["EmployeeName"].ToString() + ", Department:" + dt.Rows[0]["DeptName"].ToString() + " ALREADY REGISTERED FOR THIS SESSION!";
                            TextName.Clear();
                            //LabelDepartment.Text = null; 

                            LabelTotalAttendance.Text = da.ExecuteQuery("EXEC spGetNumberOfAttendance", null).Rows[0][0].ToString();
                        }
                        catch (Exception err)
                        {
                            //tran.Rollback();
                            MessageBox.Show(err.Message);
                        }
                        //}
                    }

                    //TextName.Text = a;
                }
            }
        }

        private void LinkFullVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeMaster em = new EmployeeMaster();
            em.Show();
        }

        private void Registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TimerNumberAttendance_Tick(object sender, EventArgs e)
        {
            using (IDataAccess da = new SQLDataAccess())
            {
                LabelTotalAttendance.Text = da.ExecuteQuery("EXEC spGetNumberOfAttendance", null).Rows[0][0].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextName2_TextChanged(object sender, EventArgs e)
        {

        }

        //    private void radTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //        using (IDataAccess da = new SQLDataAccess())
        //        {
        //            //string a;
        //            if (e.KeyChar == (char)Keys.Return)
        //            {
        //                //MessageBox.Show(radTextBox1.Text);
        //                using (DataTable dt = da.ExecuteQuery("EXEC spGetCardNumberData '" + radTextBox1.Text + "'", null))
        //                {
        //                radTextBox1.Text = dt.Rows[0]["EmployeeName"].ToString();
        //                LabelDepartment.Text = dt.Rows[0]["DeptName"].ToString();
        //                //MessageBox.Show(radTextBox1.Text);
        //                }

        //                //TextName.Text = a;
        //            }


        //        }
        //    }


    }
}