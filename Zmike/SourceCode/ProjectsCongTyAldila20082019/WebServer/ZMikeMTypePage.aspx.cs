using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATSCADAWebApp
{
    public partial class ZMikeMTypePage : System.Web.UI.Page
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
        DataTable dt1 = new DataTable();
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
                btnApplyAddMT.Enabled = false;
                btnApplyDeleteMT.Enabled = false;
                btnApplyEditMT.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    //doc bang ZMmeasType
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("ZMmeasType", "ID,Name", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {

                        drplEditMeasType.DataSource = drplDeleteMeasType.DataSource = dt;
                        drplEditMeasType.DataTextField = "Name";
                        drplEditMeasType.DataValueField = "ID";
                        drplDeleteMeasType.DataTextField = "Name";
                        drplDeleteMeasType.DataValueField = "ID";
                        drplEditMeasType.DataBind();
                        drplDeleteMeasType.DataBind();
                        txtEditMeasType.Text = drplEditMeasType.SelectedItem.Text;
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }

        }

        void loaddroplistMeasType(string lenh)
        {
            try
            {
               
                string MeasTypeEditValueCu = drplEditMeasType.SelectedItem.Value;
                string MeasTypeDeleteValueCu = drplDeleteMeasType.SelectedItem.Value;
                if (dtLoadDroplist != null)
                {
                    dtLoadDroplist.Clear();
                }
                dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("ZMmeasType", "ID,Name", "");
                if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                {
                    drplEditMeasType.DataSource = drplDeleteMeasType.DataSource = dtLoadDroplist;
                    drplEditMeasType.DataTextField = "Name";
                    drplEditMeasType.DataValueField = "ID";
                    drplDeleteMeasType.DataTextField = "Name";
                    drplDeleteMeasType.DataValueField = "ID";
                    drplEditMeasType.DataBind();
                    drplDeleteMeasType.DataBind();

                    if (lenh == "Add")
                    {

                    }
                    else if (lenh == "Edit")
                    {
                        drplEditMeasType.SelectedValue = MeasTypeEditValueCu;
                    }
                    else if (lenh == "Delete")
                    {

                    }
                    txtEditMeasType.Text = drplEditMeasType.SelectedItem.Text;
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        protected void drplEditMeasType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditMeasType.Text = drplEditMeasType.SelectedItem.Text;
        }
        protected void btnApplyAddMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddMeasType.Text.Trim() != "" && txtAddMeasType.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("ZMmeasType", "where Name='" + txtAddMeasType.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.themData("ZMmeasType", "values((SELECT MAX(ID) FROM dbo.ZMmeasType)+1,'" + txtAddMeasType.Text.Trim().ToUpper() + "')") == "GOOD")
                        {
                            //ad accsess
                            if (BienChung.AccessServer.SelectDataWhere("ZMmeasType", "where [Name]='" + txtAddMeasType.Text.Trim().ToUpper() + "'") == null)
                            {
                                BienChung.sqlServer.deletedata("ZMmeasType", "where [Name]='" + txtAddMeasType.Text.Trim() + "'");
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else if (BienChung.AccessServer.SelectDataWhere("ZMmeasType", "where Name='" + txtAddMeasType.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                            {
                                if (BienChung.AccessServer.themData("ZMmeasType", "([Name]) values('" + txtAddMeasType.Text.Trim().ToUpper() + "')") == "GOOD")
                                {
                                    loaddroplistMeasType("Add");
                                    string script = "alert(\"Add Meas Type successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    BienChung.sqlServer.deletedata("ZMmeasType", "where [Name]='" + txtAddMeasType.Text.Trim() + "'");
                                    string script = "alert(\"Update Accsess Failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                //--------------
                            }
                            else
                            {
                                string script = "alert(\"Add Part successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Add Meas Type failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Meas Type already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
        protected void btnApplyEditMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEditMeasType.Text.Trim().ToUpper() != "" && txtEditMeasType.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("ZMmeasType", "where Name='" + txtEditMeasType.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.Update("ZMmeasType", "set Name='" + txtEditMeasType.Text.Trim().ToUpper() + "' where ID='" + drplEditMeasType.SelectedItem.Value + "'") == "GOOD")
                        {
                            // access ---------------------

                            string id = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplEditMeasType.SelectedItem.Text);
                            if (id != null)
                            {
                                if (BienChung.AccessServer.Update("ZMmeasType", "set [Name]='" + txtEditMeasType.Text.Trim().ToUpper() + "' where ID=" + id + "") == "GOOD")
                                {
                                    loaddroplistMeasType("Edit");
                                    string script = "alert(\"Edit Meas Type successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    string script = "alert(\"Update Accsess Failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert(\"Edit Meas Type failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Meas Type already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"Edit Meas Type Failed!,Characters of Meas Type must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Edit Meas Type failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void btnApplyDeleteMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplDeleteMeasType.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("ZMmeasType", "where Name='" + drplDeleteMeasType.SelectedItem.Text + "'").Rows.Count > 0)
                    {
                        if (BienChung.sqlServer.deletedata("ZMmeasType", "where ID='" + drplDeleteMeasType.SelectedItem.Value + "'") == "GOOD")
                        {
                            // access -------------

                            if (BienChung.AccessServer.deletedata("ZMmeasType", "where [Name]='" + drplDeleteMeasType.SelectedItem.Text + "'") == "GOOD")
                            {
                                loaddroplistMeasType("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            //----------------------------------

                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Meas Type does not exist!\");";
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
    }
}