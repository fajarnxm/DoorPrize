using DoorPrize.framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace DoorPrize
{
    public partial class Setting : Telerik.WinControls.UI.RadForm
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            GridSetting.DataSource = GetDataSetting();
            SetHeader();         
        }

        private void SetHeader()
        {
            //using (IDataAccess da = new SQLDataAccess())
            //{
            //    using (DataTable dt = da.ExecuteQuery("EXEC spGetSettingHeader", null))
            //    {
            //        CheckBoxAttendance.Checked = Convert.ToBoolean(dt.Rows[0][0].ToString());
            //        CheckBoxDoorPrize.Checked = Convert.ToBoolean(dt.Rows[0][1].ToString());
            //    }
            //}
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

        private void GridSetting_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (GridSetting.CurrentRow.Cells[0].Value != null && GridSetting.MasterView.CurrentRow.Cells[1].Value != null && GridSetting.MasterView.CurrentRow.Cells[2].Value != null && GridSetting.MasterView.CurrentRow.Cells[3].Value != null)
                {
                    string SessionNumber = GridSetting.CurrentRow.Cells[0].Value.ToString();
                    string participantNumber = GridSetting.CurrentRow.Cells[1].Value.ToString();
                    string DoorPrize = GridSetting.CurrentRow.Cells[2].Value.ToString();
                    string Image = GridSetting.CurrentRow.Cells[3].Value.ToString();
                    bool FlagAttendance;
                    bool FlagDoorPrize;

                    if (GridSetting.MasterView.CurrentRow.Cells[4].Value != null)
                    {
                        FlagAttendance = Convert.ToBoolean(GridSetting.MasterView.CurrentRow.Cells[4].Value);
                    }

                    else
                    {
                        FlagAttendance = false;
                    }

                    if (GridSetting.MasterView.CurrentRow.Cells[5].Value != null)
                    {
                        FlagDoorPrize = Convert.ToBoolean(GridSetting.MasterView.CurrentRow.Cells[5].Value);
                    }

                    else
                    {
                        FlagDoorPrize = false;
                    }

                    using (IDataAccess da = new SQLDataAccess())
                    {
                        da.ExecuteNonQuery("EXEC spInsertUpdateSetting '" + SessionNumber + "', '" + participantNumber + "', '" + DoorPrize + "', '" + Image + "', '" + FlagAttendance + "', '" + FlagDoorPrize + "'", null);
                        GridSetting.DataSource = GetDataSetting();
                    }
                }
            }
        }

        private void GridSetting_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            if (GridSetting.CurrentRow.Cells[0].Value != null && GridSetting.MasterView.CurrentRow.Cells[1].Value != null && GridSetting.MasterView.CurrentRow.Cells[2].Value != null && GridSetting.MasterView.CurrentRow.Cells[3].Value != null)
            {
                string SessionNumber = GridSetting.CurrentRow.Cells[0].Value.ToString();
                string participantNumber = GridSetting.CurrentRow.Cells[1].Value.ToString();
                string DoorPrize = GridSetting.CurrentRow.Cells[2].Value.ToString();
                string Image = GridSetting.CurrentRow.Cells[3].Value.ToString();
                bool FlagAttendance;
                bool FlagDoorPrize;

                if (GridSetting.MasterView.CurrentRow.Cells[4].Value != null)
                {
                    FlagAttendance = Convert.ToBoolean(GridSetting.MasterView.CurrentRow.Cells[4].Value);
                }

                else
                {
                    FlagAttendance = false;
                }

                if (GridSetting.MasterView.CurrentRow.Cells[5].Value != null)
                {
                    FlagDoorPrize = Convert.ToBoolean(GridSetting.MasterView.CurrentRow.Cells[5].Value);
                }

                else
                {
                    FlagDoorPrize = false;
                }

                using(IDataAccess da = new SQLDataAccess())
                {
                    da.ExecuteNonQuery("EXEC spInsertUpdateSetting '" + SessionNumber + "', '"+ participantNumber +"', '"+ DoorPrize +"', '"+ Image +"', '"+ FlagAttendance +"', '"+ FlagDoorPrize +"'", null);
                    GridSetting.DataSource = GetDataSetting();
                }
            }
        }

        private void Setting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
