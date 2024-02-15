using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ATSCADAWebApp
{
    public partial class PartPage : System.Web.UI.Page
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
            if ((string)Session["Login"] != "True")
            {
                Response.Redirect("~/LoginPage.aspx");
            }
            if (BienChung.role == "Operator")
            {
                btnApplyAddPart.Enabled = false;
                btnApplyDeletePart.Enabled = false;
                btnApplyEditPart.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Part", "ID,Number", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {

                        drplDeletePart.DataSource = drplEditPart.DataSource = drplPart.DataSource = dt;
                        drplPart.DataTextField = "Number";
                        drplPart.DataValueField = "ID";
                        drplEditPart.DataTextField = "Number";
                        drplEditPart.DataValueField = "ID";
                        drplDeletePart.DataTextField = "Number";
                        drplDeletePart.DataValueField = "ID";
                        drplPart.DataBind();
                        drplEditPart.DataBind();
                        drplDeletePart.DataBind();
                        if (BienChung.textPart == "" && BienChung.idPart == "")
                        {
                            BienChung.textPart = drplPart.SelectedItem.ToString().Trim();
                            BienChung.idPart = drplPart.SelectedValue.Trim();
                        }
                        else
                        {
                            drplPart.SelectedValue = BienChung.idPart;
                        }

                        lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
                        txtEditPart.Text = drplEditPart.SelectedItem.Text;
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }
        }
        #region tab part
     
        void loaddroplistPart()
        {
            try
            {
                if (dtLoadDroplist != null)
                {
                    dtLoadDroplist.Clear();
                }
                dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Part", "ID,Number", "");
                if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                {
                    drplDeletePart.DataSource = drplEditPart.DataSource = drplPart.DataSource = dtLoadDroplist;
                    drplPart.DataTextField = "Number";
                    drplPart.DataValueField = "ID";
                    drplEditPart.DataTextField = "Number";
                    drplEditPart.DataValueField = "ID";
                    drplDeletePart.DataTextField = "Number";
                    drplDeletePart.DataValueField = "ID";
                    drplPart.DataBind();
                    drplEditPart.DataBind();
                    drplDeletePart.DataBind();
                    txtEditPart.Text = drplEditPart.SelectedItem.Text;
                    lblPartSelecte.Text = "Part Selected : " + drplPart.SelectedItem.Text;
                    BienChung.idPart = drplPart.SelectedItem.ToString().Trim();
                    BienChung.idPart = drplPart.SelectedValue.Trim();
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }

        }
        protected void drplPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            BienChung.textPart = drplPart.SelectedItem.ToString().Trim();
            BienChung.idPart = drplPart.SelectedValue.Trim();
            lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
            
        }
        protected void btnApplyAddPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddPart.Text.Trim() != "" && txtAddPart.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("Part", "where Number='" + txtAddPart.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.themData("Part", "values('" + txtAddPart.Text.Trim().ToUpper() + "',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)") == "GOOD")
                        {

                            //ad accsess
                            if (BienChung.AccessServer.SelectDataWhere("Part", "where Number='" + txtAddPart.Text.Trim().ToUpper() + "'") == null)
                            {
                                BienChung.sqlServer.deletedata("Part", "where [Number]='" + txtAddPart.Text.Trim() + "'");
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else if (BienChung.AccessServer.SelectDataWhere("Part", "where Number='" + txtAddPart.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                            {
                                if (BienChung.AccessServer.themData("Part", "([Number]) values('" + txtAddPart.Text.Trim().ToUpper() + "')") == "GOOD")
                                {
                                    string script = "alert(\"Add Part successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    BienChung.sqlServer.deletedata("Part", "where [Number]='" + txtAddPart.Text.Trim() + "'");
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
                            string script = "alert(\"Add Part failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Part already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    loaddroplistPart();
                }
                else
                {
                    string script = "alert(\"Add Part Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Add Part failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void btnApplyDeletePart_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplDeletePart.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("Part", "where Number='" + drplDeletePart.SelectedItem.Text + "'").Rows.Count > 0)
                    {
                        if (BienChung.sqlServer.deletedata("Part", "where ID='" + drplDeletePart.SelectedItem.Value + "'") == "GOOD")
                        {
                            // access -------------
                            if (BienChung.AccessServer.deletedata("Part", "where [Number]='" + drplDeletePart.SelectedItem.Text + "'") == "GOOD")
                            {
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
                        string script = "alert(\"Part does not exist!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    loaddroplistPart();
                }

            }
            catch
            {
                string script = "alert(\"Delete failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }
        protected void drplEditPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditPart.Text = drplEditPart.SelectedItem.Text;
        }
        protected void btnApplyEditPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEditPart.Text.Trim().ToUpper() != "" && txtEditPart.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("Part", "where Number='" + txtEditPart.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.Update("Part", "set Number='" + txtEditPart.Text.Trim().ToUpper() + "' where ID='" + drplEditPart.SelectedItem.Value + "'") == "GOOD")
                        {
                            // access ---------------------
                            string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", drplEditPart.SelectedItem.Text);
                            if (id != null)
                            {
                                if (BienChung.AccessServer.Update("Part", "set [Number]='" + txtEditPart.Text.Trim().ToUpper() + "' where ID=" + id + "") == "GOOD")
                                {
                                    string script = "alert(\"Edit Part successful!\");";
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
                            //----------------------------------------------------
                        }
                        else
                        {
                            string script = "alert(\"Edit Part failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Part already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                    loaddroplistPart();
                }
                else
                {
                    string script = "alert(\"Edit Part Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Edit Part failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        #endregion
       

       

       
    }
}