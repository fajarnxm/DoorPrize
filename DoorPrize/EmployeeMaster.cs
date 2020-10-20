using DoorPrize.framework;
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
    public partial class EmployeeMaster : Telerik.WinControls.UI.RadForm
    {
        public EmployeeMaster()
        {
            InitializeComponent();
        }

        private void EmployeeMaster_Load(object sender, EventArgs e)
        {
            GridEmployeeMaster.DataSource = getDataEmployee();
        }

        private DataTable getDataEmployee()
        {
            using(IDataAccess da = new SQLDataAccess())
            {
                using (DataTable dt = da.ExecuteQuery("EXEC spGetDataParticipant", null))
                {
                    return dt;
                }            
            }
        }

        private void GridEmployeeMaster_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            if (GridEmployeeMaster.MasterView.CurrentRow.Cells[0].Value != null && GridEmployeeMaster.MasterView.CurrentRow.Cells[1].Value != null && GridEmployeeMaster.MasterView.CurrentRow.Cells[2].Value != null)
            {
                string EMPLID = GridEmployeeMaster.MasterView.CurrentRow.Cells[0].Value.ToString();
                string name = GridEmployeeMaster.MasterView.CurrentRow.Cells[1].Value.ToString();
                string DeptName = GridEmployeeMaster.MasterView.CurrentRow.Cells[2].Value.ToString();
                bool FlagAtt;
                //bool Flagdoorprize;

                if(GridEmployeeMaster.MasterView.CurrentRow.Cells[3].Value != null)
                {
                    FlagAtt = Convert.ToBoolean(GridEmployeeMaster.MasterView.CurrentRow.Cells[3].Value);
                }

                else
                {
                    FlagAtt = false;
                }
                
                //if (GridEmployeeMaster.MasterView.CurrentRow.Cells[4].Value != null)
                //{
                //    Flagdoorprize = Convert.ToBoolean(GridEmployeeMaster.MasterView.CurrentRow.Cells[4].Value);
                //}

                //else
                //{
                //    Flagdoorprize = false;
                //}

                using(IDataAccess da = new SQLDataAccess())
                {
                    da.ExecuteNonQuery("EXEC spInsertUpdateMsParticipant '" + EMPLID + "', '" + name + "', '" + DeptName + "', '" + FlagAtt + "'", null);        
                }

                GridEmployeeMaster.DataSource = getDataEmployee();
            }
        }

        private void GridEmployeeMaster_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (GridEmployeeMaster.MasterView.CurrentRow.Cells[0].Value != null && GridEmployeeMaster.MasterView.CurrentRow.Cells[1].Value != null && GridEmployeeMaster.MasterView.CurrentRow.Cells[2].Value != null &&
                  GridEmployeeMaster.MasterView.CurrentRow.Cells[3].Value != null)
                {
                    string EMPLID = GridEmployeeMaster.MasterView.CurrentRow.Cells[0].Value.ToString();
                    string name = GridEmployeeMaster.MasterView.CurrentRow.Cells[1].Value.ToString();
                    string DeptName = GridEmployeeMaster.MasterView.CurrentRow.Cells[2].Value.ToString();
                    bool FlagAtt = Convert.ToBoolean(GridEmployeeMaster.MasterView.CurrentRow.Cells[3].Value);
                    //bool Flagdoorprize = Convert.ToBoolean(GridEmployeeMaster.MasterView.CurrentRow.Cells[4].Value);

                    using(IDataAccess da = new SQLDataAccess())
                    {
                        da.ExecuteNonQuery("EXEC spInsertUpdateMsParticipant '" + EMPLID + "', '" + name + "', '" + DeptName + "', '" + FlagAtt + "'", null);
                    }

                    GridEmployeeMaster.DataSource = getDataEmployee();
                }
            }
        }

        private void EmployeeMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void GridEmployeeMaster_Click(object sender, EventArgs e)
        {

        }
    }
}
