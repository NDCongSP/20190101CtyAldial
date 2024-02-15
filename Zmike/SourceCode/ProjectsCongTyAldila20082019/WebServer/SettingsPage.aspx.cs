using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ATSCADAWebApp
{
    public partial class SettingsPage : System.Web.UI.Page
    {
        #region Main Static Objects - THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED OR MODIFIED
        /// <summary>
        /// THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED
        /// </summary>
        static iDriverWeb Driver = new iDriverWeb();
        static List<Control> allControls = new List<Control>();
        static SetDriver SD = new SetDriver();
        #endregion

        DataTable dt = new DataTable();
        DataTable dtLoadDroplist = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Basic Operations - THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED  OR MODIFIED
            /// <summary>
            /// THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED
            /// </summary>
            //Attach Realtime driver for all iControls            
            allControls.Clear();
            SD.SetDriverForiWebTools(Page.Controls, allControls, Driver);
            #endregion

            #region Authentication Settings - THESE LINES ARE FROM ATPROCORP, SHOULD BE MODIFIED
            //If this page is only for Admin Users
            if ((string)Session["Login"] != "True")
            {
                Response.Redirect("~/LoginPage.aspx");
            }
            if (BienChung.role == "Operator")
            {
               
                    btnApplyAddMch.Enabled = false;
                    btnApplyAddUser.Enabled = false;
                    btnApplyDeleteUser.Enabled = false;
                    btnApplyDelMch.Enabled = false;
                    btnApplyEditMch.Enabled = false;
                    btnApplyEditUser.Enabled = false;
                    btnApplyEditWeight.Enabled = false;
                    btnApplyLocation.Enabled = false;
                    btnApplyWeight.Enabled = false;
                    btnDelWeight.Enabled = false;
               
            }
            else if(BienChung.role == "User")
            {
                btnApplyEditUser.Enabled = false;
                btnApplyAddUser.Enabled = false;
                btnApplyDeleteUser.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    dt = BienChung.sqlServer.SelectData("useraccount");
                    if (dt.Rows.Count != 0 && dt != null)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DrplDeleteUser.Items.Add(dt.Rows[i][0].ToString());
                            DrplEditUser.Items.Add(dt.Rows[i][0].ToString());
                        }

                    }
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectData("ButtStop");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        txtLocation1.Text = dt.Rows[0][0].ToString();
                        txtLocation2.Text = dt.Rows[0][1].ToString();
                        txtLocation3.Text = dt.Rows[0][2].ToString();
                        txtLocation4.Text = dt.Rows[0][3].ToString();
                        txtLocation5.Text = dt.Rows[0][4].ToString();
                        txtLocation6.Text = dt.Rows[0][5].ToString();
                        txtLocation7.Text = dt.Rows[0][6].ToString();
                        txtLocation8.Text = dt.Rows[0][7].ToString();
                        txtLocation9.Text = dt.Rows[0][8].ToString();
                        txtLocation10.Text = dt.Rows[0][9].ToString();
                    }
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Weight", "ID,Value", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        drplWeight.DataSource = drplDeleteWeight.DataSource = dt;
                        drplWeight.DataTextField = "Value";
                        drplWeight.DataValueField = "ID";
                        drplDeleteWeight.DataTextField = "Value";
                        drplDeleteWeight.DataValueField = "ID";
                        drplWeight.DataBind();
                        drplDeleteWeight.DataBind();
                    }
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    if (drplDelMchType.SelectedIndex == 0)
                    {
                        dt = BienChung.sqlServer.selectdatatheocot("ZMike", "ID,Name,Task", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 1)
                    {
                        dt = BienChung.sqlServer.selectdatatheocot("Frequency", "ID,Name", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 2)
                    {
                        dt = BienChung.sqlServer.selectdatatheocot("Flex", "ID,Name", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 3)
                    {
                        dt = BienChung.sqlServer.selectdatatheocot("SWeight", "ID,Name", "");
                    }
                    if (dt != null && dt.Rows.Count != 0)
                    {

                        drplEditMchName.DataSource = drplDelMchName.DataSource = dt;
                        drplEditMchName.DataTextField = "Name";
                        drplEditMchName.DataValueField = "ID";
                        drplEditMchName.DataBind();
                        drplDelMchName.DataTextField = "Name";
                        drplDelMchName.DataValueField = "ID";
                        drplDelMchName.DataBind();
                        txtEditMchName.Text = drplEditMchName.SelectedItem.Text;
                        txtEditTask.Text = dt.Rows[drplEditMchName.SelectedIndex][2].ToString();
                    }
                    else
                    {
                        txtEditMchName.Text = "";
                        txtEditTask.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }

        }
        void loadwieghtt()
        {
            if(dtLoadDroplist!=null)
            {
                dtLoadDroplist.Clear();
            }
            dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Weight", "ID,Value", "");
            if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
            {
                drplWeight.DataSource = drplDeleteWeight.DataSource = dtLoadDroplist;
                drplWeight.DataTextField = "Value";
                drplWeight.DataValueField = "ID";
                drplDeleteWeight.DataTextField = "Value";
                drplDeleteWeight.DataValueField = "ID";
                drplWeight.DataBind();
                drplDeleteWeight.DataBind();
            }
        }
        protected void btnApplyAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddUser.Text.Trim() != "" && txtAddPass.Text.Trim() != "" && txtAddCfPass.Text.Trim() != "" && DrplAddRole.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("useraccount", "where [User]='" + txtAddUser.Text.Trim() + "'").Rows.Count == 0)
                    {
                        if (txtAddPass.Text.Trim() == txtAddCfPass.Text.Trim())
                        {
                            if (BienChung.sqlServer.themData("useraccount", "values('" + txtAddUser.Text.Trim() + "','" + txtAddPass.Text.Trim() + "','" + DrplAddRole.Text.Trim() + "')") == "GOOD")
                            {
                                DrplDeleteUser.Items.Add(txtAddUser.Text.Trim());
                                DrplEditUser.Items.Add(txtAddUser.Text.Trim());
                                txtAddUser.Text = "";
                                string script = "alert(\"Add user successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Add user failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {

                            string script = "alert(\"Old pass and new pass do not match!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"User already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"No connection to the server!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (DrplEditUser.Text.Trim() != "" && txtEditOldPass.Text.Trim() != "" && txtEditNewPass.Text.Trim() != "" && txtEditCfPass.Text.Trim() != "" && DrplEditRole.Text.Trim() != "")
                {
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("useraccount", "where [User]='" + DrplEditUser.Text.Trim() + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        if (txtEditOldPass.Text.Trim() == dt.Rows[0][1].ToString().Trim())
                        {
                            if (txtEditNewPass.Text.Trim() == txtEditCfPass.Text.Trim())
                            {
                                if (BienChung.sqlServer.Update("useraccount", "set Pass='" + txtEditNewPass.Text.Trim() + "',Role='" + DrplEditRole.Text.Trim() + "' where [User]='" + DrplEditUser.Text.Trim() + "'") == "GOOD")
                                {
                                    string script = "alert(\"Update successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Update failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Old pass and new pass do not match!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Update failed!,Old Pass is incorrect!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Update failed!, No connection to the server!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"Update failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (DrplDeleteUser.Text.Trim() != "" )
                {
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("useraccount", "where [User]='" + DrplDeleteUser.Text.Trim() + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        if (dt.Rows[0][2].ToString().Trim() == "Admin")
                        {
                            if (txtDeleteOldPass.Text.Trim() == dt.Rows[0][1].ToString().Trim())
                            {
                                if (BienChung.sqlServer.deletedata("useraccount", "where [User]='" + DrplDeleteUser.Text.Trim() + "'") == "GOOD")
                                {
                                    DrplDeleteUser.Items.Remove(dt.Rows[0][0].ToString().Trim());
                                    DrplEditUser.Items.Remove(dt.Rows[0][0].ToString().Trim());
                                    string script = "alert(\"Delete successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Delete failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!,Old Pass is incorrect!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (BienChung.sqlServer.deletedata("useraccount", "where [User]='" + DrplDeleteUser.Text.Trim() + "'") == "GOOD")
                            {
                                DrplDeleteUser.Items.Remove(dt.Rows[0][0].ToString().Trim());
                                DrplEditUser.Items.Remove(dt.Rows[0][0].ToString().Trim());
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                    else
                    {
                        string script = "alert(\"Delete failed!, No connection to the server!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"Delete failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyLocation_Click(object sender, EventArgs e)
        {
            if (txtLocation1.Text.Trim().Split('.').Length <= 2 && txtLocation2.Text.Trim().Split('.').Length <= 2
                 && txtLocation3.Text.Trim().Split('.').Length <= 2 && txtLocation4.Text.Trim().Split('.').Length <= 2
                 && txtLocation5.Text.Trim().Split('.').Length <= 2 && txtLocation6.Text.Trim().Split('.').Length <= 2
                 && txtLocation7.Text.Trim().Split('.').Length <= 2 && txtLocation8.Text.Trim().Split('.').Length <= 2
                 && txtLocation9.Text.Trim().Split('.').Length <= 2 && txtLocation10.Text.Trim().Split('.').Length <= 2
                 && txtLocation1.Text.Trim() != "" && txtLocation2.Text.Trim() != ""
                 && txtLocation3.Text.Trim() != "" && txtLocation4.Text.Trim() != ""
                 && txtLocation5.Text.Trim() != "" && txtLocation6.Text.Trim() != ""
                 && txtLocation7.Text.Trim() != "" && txtLocation8.Text.Trim() != ""
                 && txtLocation9.Text.Trim() != "" && txtLocation10.Text.Trim() != ""

                 )
            {
                try
                {
                    if (BienChung.sqlServer.Update(
                         "ButtStop", "set L1='" + Convert.ToDouble(txtLocation1.Text.Trim()).ToString("0.00") + "', L2='" + Convert.ToDouble(txtLocation2.Text.Trim()).ToString("0.00") + "', L3='" + Convert.ToDouble(txtLocation3.Text.Trim()).ToString("0.00") + "', " +
                         "L4='" + Convert.ToDouble(txtLocation4.Text.Trim()).ToString("0.00") + "', L5='" + Convert.ToDouble(txtLocation5.Text.Trim()).ToString("0.00") + "', L6='" + Convert.ToDouble(txtLocation6.Text.Trim()).ToString("0.00") + "', L7='" + Convert.ToDouble(txtLocation7.Text.Trim()).ToString("0.00") + "'," +
                         " L8='" + Convert.ToDouble(txtLocation8.Text.Trim()).ToString("0.00") + "', L9='" + Convert.ToDouble(txtLocation9.Text.Trim()).ToString("0.00") + "',L10='" + Convert.ToDouble(txtLocation10.Text.Trim()).ToString("0.00") + "'") == "GOOD")
                    {

                        string script = "alert(\"Update successful!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    else
                    {
                        string script = "alert(\"Update failed!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                catch
                {
                    string script = "alert(\"Wrong format!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            else
            {
                string script = "alert(\"Wrong format!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyAddMch_Click(object sender, EventArgs e)
        {
            try
            {

                if (drplAddMchType.Text.Trim() != "" && txtAddMchName.Text.Trim() != "" && txtAddTask.Text.Trim() != "")
                {
                    if (drplAddMchType.SelectedIndex == 0)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("ZMike", "where Name='" + txtAddMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.SelectDataWhere("ZMike", "where Task='" + txtAddTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.themData("ZMike", "values('" + txtAddMchName.Text.Trim() + "','" + txtAddTask.Text.Trim() + "')") == "GOOD")
                                {


                                    string script = "alert(\"Add successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Add failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Machine Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Machine Name already exists!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplAddMchType.SelectedIndex == 1)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Frequency", "where Name='" + txtAddMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.SelectDataWhere("Frequency", "where Task='" + txtAddTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.themData("Frequency", "values('" + txtAddMchName.Text.Trim() + "','" + txtAddTask.Text.Trim() + "')") == "GOOD")
                                {


                                    string script = "alert(\"Add successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Add failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Machine Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Machine Name already exists!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplAddMchType.SelectedIndex == 2)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Flex", "where Name='" + txtAddMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.SelectDataWhere("Flex", "where Task='" + txtAddTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.themData("Flex", "values('" + txtAddMchName.Text.Trim() + "','" + txtAddTask.Text.Trim() + "')") == "GOOD")
                                {


                                    string script = "alert(\"Add successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Add failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Machine Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Machine Name already exists!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplAddMchType.SelectedIndex == 3)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("SWeight", "where Name='" + txtAddMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.SelectDataWhere("SWeight", "where Task='" + txtAddTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.themData("SWeight", "values('" + txtAddMchName.Text.Trim() + "','" + txtAddTask.Text.Trim() + "')") == "GOOD")
                                {


                                    string script = "alert(\"Add successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Add failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Machine Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Machine Name already exists!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Add Meas Type Failed!,Characters of Meas Type must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            catch
            {
                string script = "alert(\"Add Meas Type failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyEditMch_Click(object sender, EventArgs e)
        {

            try
            {
                if (drplEditMchName.Text.Trim() != "" && txtEditMchName.Text.Trim() != "" && txtEditTask.Text.Trim() != "")
                {
                    if (drplEditMchType.SelectedIndex == 0)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("ZMike", "where Name='" + txtEditMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.Update("ZMike", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Edit");
                                string script = "alert(\"Edit successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Edit failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (BienChung.sqlServer.SelectDataWhere("ZMike", "where Task='" + txtEditTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.Update("ZMike", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                                {

                                    loaddroplistMchName("Edit");
                                    string script = "alert(\"Edit successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Edit failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }

                            }
                            else
                            {
                                string script = "alert(\"Machine Name And Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                    else if (drplEditMchType.SelectedIndex == 1)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Frequency", "where Name='" + txtEditMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.Update("Frequency", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Edit");
                                string script = "alert(\"Edit successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Edit failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (BienChung.sqlServer.SelectDataWhere("Frequency", "where Task='" + txtEditTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.Update("Frequency", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                                {

                                    loaddroplistMchName("Edit");
                                    string script = "alert(\"Edit successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Edit failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }

                            }
                            else
                            {
                                string script = "alert(\"Machine Name And Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }

                    }
                    else if (drplEditMchType.SelectedIndex == 2)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Flex", "where Name='" + txtEditMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.Update("Flex", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Edit");
                                string script = "alert(\"Edit successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Edit failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (BienChung.sqlServer.SelectDataWhere("Flex", "where Task='" + txtEditTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.Update("Flex", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                                {

                                    loaddroplistMchName("Edit");
                                    string script = "alert(\"Edit successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Edit failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }

                            }
                            else
                            {
                                string script = "alert(\"Machine Name And Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                    else if (drplEditMchType.SelectedIndex == 3)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("SWeight", "where Name='" + txtEditMchName.Text.Trim() + "'").Rows.Count == 0)
                        {
                            if (BienChung.sqlServer.Update("SWeight", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Edit");
                                string script = "alert(\"Edit successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Edit failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (BienChung.sqlServer.SelectDataWhere("SWeight", "where Task='" + txtEditTask.Text.Trim() + "'").Rows.Count == 0)
                            {
                                if (BienChung.sqlServer.Update("SWeight", "set Name='" + txtEditMchName.Text.Trim() + "',Task='" + txtEditTask.Text.Trim() + "' where ID='" + drplEditMchName.SelectedItem.Value + "'") == "GOOD")
                                {

                                    loaddroplistMchName("Edit");
                                    string script = "alert(\"Edit successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Edit failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }

                            }
                            else
                            {
                                string script = "alert(\"Machine Name And Task already exists!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Edit Failed!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Edit failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyDelMch_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplDelMchName.Text.Trim() != "")
                {
                    if (drplDelMchType.SelectedIndex == 0)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("ZMike", "where Name='" + drplDelMchName.SelectedItem.Text + "'").Rows.Count > 0)
                        {
                            if (BienChung.sqlServer.deletedata("ZMike", "where ID='" + drplDelMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplDelMchType.SelectedIndex == 1)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Frequency", "where Name='" + drplDelMchName.SelectedItem.Text + "'").Rows.Count > 0)
                        {
                            if (BienChung.sqlServer.deletedata("Frequency", "where ID='" + drplDelMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplDelMchType.SelectedIndex == 2)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("Flex", "where Name='" + drplDelMchName.SelectedItem.Text + "'").Rows.Count > 0)
                        {
                            if (BienChung.sqlServer.deletedata("Flex", "where ID='" + drplDelMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else if (drplDelMchType.SelectedIndex == 3)
                    {
                        if (BienChung.sqlServer.SelectDataWhere("SWeight", "where Name='" + drplDelMchName.SelectedItem.Text + "'").Rows.Count > 0)
                        {
                            if (BienChung.sqlServer.deletedata("SWeight", "where ID='" + drplDelMchName.SelectedItem.Value + "'") == "GOOD")
                            {

                                loaddroplistMchName("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Delete failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }

            }
            catch
            {
                string script = "alert(\"Delete failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }
        void loaddroplistMchName(string lenh)
        {
            try
            {
                if (lenh == "Edit")
                {
                    if (dtLoadDroplist != null)
                    {
                        dtLoadDroplist.Clear();
                    }
                    if (drplEditMchType.SelectedIndex == 0)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("ZMike", "ID,Name,Task", "");
                    }
                    else if (drplEditMchType.SelectedIndex == 1)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Frequency", "ID,Name,Task", "");
                    }
                    else if (drplEditMchType.SelectedIndex == 2)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Flex", "ID,Name,Task", "");
                    }
                    else if (drplEditMchType.SelectedIndex == 3)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("SWeight", "ID,Name,Task", "");
                    }

                    if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                    {

                        drplEditMchName.DataSource = dtLoadDroplist;
                        drplEditMchName.DataTextField = "Name";
                        drplEditMchName.DataValueField = "ID";
                        drplEditMchName.DataBind();
                        txtEditMchName.Text = drplEditMchName.SelectedItem.Text;
                        txtEditTask.Text = dtLoadDroplist.Rows[drplEditMchName.SelectedIndex][2].ToString();

                    }
                    else
                    {
                        drplEditMchName.Items.Clear();
                        txtEditMchName.Text = "";
                        txtEditTask.Text = "";
                    }
                }
                else
                {

                    if (dtLoadDroplist != null)
                    {
                        dtLoadDroplist.Clear();
                    }
                    if (drplDelMchType.SelectedIndex == 0)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("ZMike", "ID,Name,Task", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 1)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Frequency", "ID,Name,Task", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 2)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Flex", "ID,Name,Task", "");
                    }
                    else if (drplDelMchType.SelectedIndex == 3)
                    {
                        dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("SWeight", "ID,Name,Task", "");
                    }

                    if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                    {
                        drplDelMchName.DataSource = dtLoadDroplist;
                        drplDelMchName.DataTextField = "Name";
                        drplDelMchName.DataValueField = "ID";
                        drplDelMchName.DataBind();
                    }
                    else
                    {
                        drplDelMchName.Items.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        protected void drplAddMchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loaddroplistMchName(string lenh)
        }

        protected void drplEditMchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddroplistMchName("Edit");
        }

        protected void drplDelMchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddroplistMchName("Delete");
        }

        protected void drplEditMchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEditMchName.Text = drplEditMchName.SelectedItem.Text;

                if (drplEditMchType.SelectedIndex == 0)
                {
                    txtEditTask.Text = BienChung.sqlServer.selectdatatheoid("ZMike", "Task", "ID", drplEditMchName.SelectedItem.Value);
                }
                else if (drplEditMchType.SelectedIndex == 1)
                {
                    txtEditTask.Text = BienChung.sqlServer.selectdatatheoid("Frequency", "Task", "ID", drplEditMchName.SelectedItem.Value);
                }
                else if (drplEditMchType.SelectedIndex == 2)
                {
                    txtEditTask.Text = BienChung.sqlServer.selectdatatheoid("Flex", "Task", "ID", drplEditMchName.SelectedItem.Value);
                }
                else if (drplEditMchType.SelectedIndex == 3)
                {
                    txtEditTask.Text = BienChung.sqlServer.selectdatatheoid("SWeight", "Task", "ID", drplEditMchName.SelectedItem.Value);
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }

        protected void btnApplyWeight_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWeight.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("Weight", " where Value='" + txtWeight.Text.Trim() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.themData("Weight", " values('" + txtWeight.Text.Trim() + "')") == "GOOD")
                        {
                            loadwieghtt();
                            txtWeight.Text = "";
                            string script = "alert(\"Add Weight successful!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Add Weight failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Weight already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"No connection to the server!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyEditWeight_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplWeight.SelectedItem.Text.Trim() != "" && txtEditWeight.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("Weight", " where Value='" + txtEditWeight.Text.Trim() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.Update("Weight", " set Value='" + txtEditWeight.Text.Trim() + "' where Value='" + drplWeight.SelectedItem.Text.Trim() + "'") == "GOOD")
                        {
                            loadwieghtt();
                            string script = "alert(\"Update successful!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Update failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Weight already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"Update failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnDelWeight_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplDeleteWeight.SelectedItem.Text.Trim() != "")
                {
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("Weight", " where Value='" + drplDeleteWeight.SelectedItem.Text.Trim() + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        if (BienChung.sqlServer.deletedata("Weight", " where Value='" + drplDeleteWeight.SelectedItem.Text.Trim() + "'") == "GOOD")
                        {
                            loadwieghtt();
                            string script = "alert(\"Delete successful!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Delete failed!, No connection to the server!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            catch
            {
                string script = "alert(\"Delete failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void drplWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditWeight.Text = drplWeight.SelectedItem.Text;
        }
    }
}