using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ATSCADAWebApp
{
    public partial class FlexStPage : System.Web.UI.Page
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
                btnApplyAddNumFlex.Enabled = false;
                btnApplyDeleteNumFlex.Enabled = false;
                btnApplyEditNumFlex.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    //doc bang Flex_standard
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Flex_Standard", "ID,Number", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        drplNumEditFlex.DataSource = drplNumDeleteFlex.DataSource = dt;
                        drplNumEditFlex.DataTextField = "Number";
                        drplNumEditFlex.DataValueField = "ID";
                        drplNumDeleteFlex.DataTextField = "Number";
                        drplNumDeleteFlex.DataValueField = "ID";
                        drplNumEditFlex.DataBind();
                        drplNumDeleteFlex.DataBind();
                        txtNumEditFlex.Text = drplNumEditFlex.SelectedItem.Text;
                    }
                    loaddulieuFlexstandard();
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }
        }

        protected void drplNumEditFlex_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddulieuFlexstandard();
            txtNumEditFlex.Text = drplNumEditFlex.SelectedItem.Text;
        }
        void loaddulieuFlexstandard()
        {
            try
            {
                if (dt != null)
                {
                    dt.Clear();
                }
                dt = BienChung.sqlServer.SelectDataWhere("Flex_standard", " where ID='" + drplNumEditFlex.SelectedItem.Value + "'");
                if (dt != null && dt.Rows.Count != 0)
                {
                    txtFlexValue.Text = dt.Rows[0][2].ToString();
                    txtHoleNumber.Text = dt.Rows[0][3].ToString();
                    txtClampToWt.Text = dt.Rows[0][4].ToString();
                    txtClampToSen.Text = dt.Rows[0][5].ToString();
                    txtClampToTip.Text = dt.Rows[0][6].ToString();

                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        void loaddroplistFlex(string lenh)
        {
            try
            {
                string FlexEditValueCu = drplNumEditFlex.SelectedItem.Value;
                string FlexDeleteValueCu = drplNumDeleteFlex.SelectedItem.Value;
                if (dtLoadDroplist != null)
                {
                    dtLoadDroplist.Clear();
                }
                dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Flex_Standard", "ID,Number", "");
                if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                {
                    drplNumEditFlex.DataSource = drplNumDeleteFlex.DataSource = dtLoadDroplist;
                    drplNumEditFlex.DataTextField = "Number";
                    drplNumEditFlex.DataValueField = "ID";
                    drplNumDeleteFlex.DataTextField = "Number";
                    drplNumDeleteFlex.DataValueField = "ID";
                    drplNumEditFlex.DataBind();
                    drplNumDeleteFlex.DataBind();
                    if (lenh == "Add")
                    {
                        drplNumEditFlex.SelectedValue = FlexEditValueCu;
                    }
                    else if (lenh == "Edit")
                    {
                        drplNumEditFlex.SelectedValue = FlexEditValueCu;
                        loaddulieuFlexstandard();
                    }
                    else if (lenh == "Delete")
                    {
                        if (FlexDeleteValueCu != FlexEditValueCu)
                        {
                            drplNumEditFlex.SelectedValue = FlexEditValueCu;
                        }
                        else
                        {
                            loaddulieuFlexstandard();
                        }
                    }
                    txtNumEditFlex.Text = drplNumEditFlex.SelectedItem.Text;
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        protected void btnApplyAddNumFlex_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumAddFlex.Text.Trim() != "" && txtNumAddFlex.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("Flex_Standard", "where Number='" + txtNumAddFlex.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.themData("Flex_Standard", "values('" + txtNumAddFlex.Text.Trim().ToUpper() + "',NULL,NULL,NULL,NULL,NULL)") == "GOOD")
                        {
                            //ad accsess---------------------------------------------
                            if (BienChung.AccessServer.SelectDataWhere("Flex_Standard", "where Number='" + txtNumAddFlex.Text.Trim().ToUpper() + "'") == null)
                            {
                                BienChung.sqlServer.deletedata("Flex_Standard", "where [Number]='" + txtNumAddFlex.Text.Trim() + "'");
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else if (BienChung.AccessServer.SelectDataWhere("Flex_Standard", "where Number='" + txtNumAddFlex.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                            {
                                if (BienChung.AccessServer.themData("Flex_Standard", "([Number]) values('" + txtNumAddFlex.Text.Trim().ToUpper() + "')") == "GOOD")
                                {
                                    loaddroplistFlex("Add");
                                    string script = "alert(\"Add Flex Standard successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    BienChung.sqlServer.deletedata("Flex_Standard", "where [Number]='" + txtNumAddFlex.Text.Trim() + "'");
                                    string script = "alert(\"Update Accsess Failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                //---------------------------------------------------------
                            }
                            else
                            {
                                string script = "alert(\"Add Part successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Add Flex Standard failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Flex Standard already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"Add Flex Standard Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Add Flex Standard failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void btnApplyDeleteNumFlex_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplNumDeleteFlex.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("Flex_Standard", "where Number='" + drplNumDeleteFlex.SelectedItem.Text + "'").Rows.Count > 0)
                    {
                        if (BienChung.sqlServer.deletedata("Flex_Standard", "where ID='" + drplNumDeleteFlex.SelectedItem.Value + "'") == "GOOD")
                        {
                            //access----------------------------------------------------

                            if (BienChung.AccessServer.deletedata("Flex_Standard", "where [Number]='" + drplNumDeleteFlex.SelectedItem.Text + "'") == "GOOD")
                            {
                                loaddroplistFlex("Delete");
                                string script = "alert(\"Delete successful!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else
                            {
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            //--------------------------------------------------------------

                        }
                        else
                        {
                            string script = "alert(\"Delete failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Flex Standard does not exist!\");";
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
        protected void btnApplyEditNumFlex_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumEditFlex.Text.Trim() != "" && txtNumEditFlex.Text.Trim().Length >= 4)
                {
                    if (txtClampToWt.Text.Trim() != "" && txtClampToSen.Text.Trim() != "" && txtClampToTip.Text.Trim() != "" && txtFlexValue.Text.Trim() != "" && txtHoleNumber.Text.Trim() != "")

                    {
                        if (Convert.ToDouble(txtClampToWt.Text) >= 0 && Convert.ToDouble(txtClampToWt.Text) <= 9999999999 && Convert.ToDouble(txtClampToSen.Text) >= 0 && Convert.ToDouble(txtClampToSen.Text) <= 9999999999
                             && Convert.ToDouble(txtClampToTip.Text) >= 0 && Convert.ToDouble(txtClampToTip.Text) <= 9999999999 && Convert.ToDouble(txtFlexValue.Text) >= 2 && Convert.ToDouble(txtFlexValue.Text) <= 200
                             && Convert.ToDouble(txtHoleNumber.Text) >= 0 && Convert.ToDouble(txtHoleNumber.Text) <= 50
                             )
                        {
                            if (txtNumEditFlex.Text.Trim().ToUpper() != drplNumEditFlex.SelectedItem.Text)
                            {
                                if (BienChung.sqlServer.SelectDataWhere("Flex_Standard", "where Number='" + txtNumEditFlex.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                                {
                                    if (BienChung.sqlServer.Update("Flex_Standard", "set Number='" + txtNumEditFlex.Text.Trim().ToUpper() + "',Flex_Val='" + Convert.ToDouble(txtFlexValue.Text.Trim()).ToString("0.000") + "',Hole_Number='" + Convert.ToInt16(Convert.ToDouble(txtHoleNumber.Text.Trim())).ToString() + "'," +
                                        "Clamp_To_Wt='" + Convert.ToDouble(txtClampToWt.Text.Trim()).ToString("0.000") + "',Clamp_To_Sensor='" + Convert.ToDouble(txtClampToSen.Text.Trim()).ToString("0.000") + "',Clamp_To_Tip='" + Convert.ToDouble(txtClampToTip.Text.Trim()).ToString("0.000") + "' " +
                                        "where ID='" + drplNumEditFlex.SelectedItem.Value + "'") == "GOOD")
                                    {
                                        //access----------------------------------------------

                                        string id = BienChung.AccessServer.selectdatatheoid("Flex_Standard", "ID", "Number", drplNumEditFlex.SelectedItem.Text);
                                        if (id != null)
                                        {
                                            if (BienChung.AccessServer.Update("Flex_Standard", "set [Number]='" + txtNumEditFlex.Text.Trim().ToUpper() + "',[Flex_Val]=" + Convert.ToDouble(txtFlexValue.Text.Trim()).ToString("0.000") + ",[Hole_Number]=" + Convert.ToInt16(Convert.ToDouble(txtHoleNumber.Text.Trim())).ToString() + ",[Clamp_To_Wt]=" + Convert.ToDouble(txtClampToWt.Text.Trim()).ToString("0.000") + "," +
                                                "[Clamp_To_Sensor]=" + Convert.ToDouble(txtClampToSen.Text.Trim()).ToString("0.000") + ",[Clamp_To_Tip]=" + Convert.ToDouble(txtClampToTip.Text.Trim()).ToString("0.000") + " where ID = " + id + "") == "GOOD")
                                            {
                                                loaddroplistFlex("Edit");
                                                string script = "alert(\"Edit Flex Standard successful!\");";
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


                                        //---------------------------------------------------------


                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Flex Standard failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                }
                                else
                                {
                                    string script = "alert(\"Flex Standard already exists!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                if (BienChung.sqlServer.Update("Flex_Standard", "set Number='" + txtNumEditFlex.Text.Trim().ToUpper() + "',Flex_Val='" + Convert.ToDouble(txtFlexValue.Text.Trim()).ToString("0.000") + "',Hole_Number='" + Convert.ToInt16(Convert.ToDouble(txtHoleNumber.Text.Trim())).ToString() + "'," +
                                        "Clamp_To_Wt='" + Convert.ToDouble(txtClampToWt.Text.Trim()).ToString("0.000") + "',Clamp_To_Sensor='" + Convert.ToDouble(txtClampToSen.Text.Trim()).ToString("0.000") + "',Clamp_To_Tip='" + Convert.ToDouble(txtClampToTip.Text.Trim()).ToString("0.000") + "' " +
                                        "where ID='" + drplNumEditFlex.SelectedItem.Value + "'") == "GOOD")
                                {
                                    //access----------------------------------------------

                                    string id = BienChung.AccessServer.selectdatatheoid("Flex_Standard", "ID", "Number", drplNumEditFlex.SelectedItem.Text);
                                    if (id != null)
                                    {
                                        if (BienChung.AccessServer.Update("Flex_Standard", "set [Number]='" + txtNumEditFlex.Text.Trim().ToUpper() + "',[Flex_Val]=" + Convert.ToDouble(txtFlexValue.Text.Trim()).ToString("0.000") + ",[Hole_Number]=" + Convert.ToInt16(Convert.ToDouble(txtHoleNumber.Text.Trim())).ToString() + ",[Clamp_To_Wt]=" + Convert.ToDouble(txtClampToWt.Text.Trim()).ToString("0.000") + "," +
                                            "[Clamp_To_Sensor]=" + Convert.ToDouble(txtClampToSen.Text.Trim()).ToString("0.000") + ",[Clamp_To_Tip]=" + Convert.ToDouble(txtClampToTip.Text.Trim()).ToString("0.000") + " where ID = " + id + "") == "GOOD")
                                        {
                                            loaddroplistFlex("Edit");
                                            string script = "alert(\"Edit Flex Standard successful!\");";
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
                                    //---------------------------------------------------------
                                }
                                else
                                {
                                    string script = "alert(\"Edit Flex Standard failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                        }
                        else
                        {
                            #region SUA LẠI TEBOX 
                            if (Convert.ToDouble(txtClampToWt.Text) < 0)
                                txtClampToWt.Text = "0";
                            else if (Convert.ToDouble(txtClampToWt.Text) > 9999999999)
                                txtClampToWt.Text = "9999999999";
                            if (Convert.ToDouble(txtClampToSen.Text) < 0)
                                txtClampToSen.Text = "0";
                            else if (Convert.ToDouble(txtClampToSen.Text) > 9999999999)
                                txtClampToSen.Text = "9999999999";
                            if (Convert.ToDouble(txtClampToTip.Text) < 0)
                                txtClampToTip.Text = "0";
                            else if (Convert.ToDouble(txtClampToTip.Text) > 9999999999)
                                txtClampToTip.Text = "9999999999";
                            if (Convert.ToDouble(txtFlexValue.Text) < 2)
                                txtFlexValue.Text = "2";
                            else if (Convert.ToDouble(txtFlexValue.Text) > 200)
                                txtFlexValue.Text = "200";
                            if (Convert.ToDouble(txtHoleNumber.Text) < 0)
                                txtHoleNumber.Text = "0";
                            else if (Convert.ToDouble(txtHoleNumber.Text) > 50)
                                txtHoleNumber.Text = "50";

                            #endregion
                            string script = "alert(\"Edit Flex Standard Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        #region SUA LẠI TEBOX
                        if (txtClampToWt.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtClampToWt.Text) < 0)
                                txtClampToWt.Text = "0";
                            else if (Convert.ToDouble(txtClampToWt.Text) > 9999999999)
                                txtClampToWt.Text = "9999999999";
                        }
                        else { txtClampToWt.Text = "0"; }
                        if (txtClampToSen.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtClampToSen.Text) < 0)
                                txtClampToSen.Text = "0";
                            else if (Convert.ToDouble(txtClampToSen.Text) > 9999999999)
                                txtClampToSen.Text = "9999999999";
                        }
                        else { txtClampToSen.Text = "0"; }
                        if (txtClampToTip.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtClampToTip.Text) < 0)
                                txtClampToTip.Text = "0";
                            else if (Convert.ToDouble(txtClampToTip.Text) > 9999999999)
                                txtClampToTip.Text = "9999999999";
                        }
                        else { txtClampToTip.Text = "0"; }
                        if (txtFlexValue.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtFlexValue.Text) < 2)
                                txtFlexValue.Text = "2";
                            else if (Convert.ToDouble(txtFlexValue.Text) > 200)
                                txtFlexValue.Text = "200";
                        }
                        else { txtFlexValue.Text = "2"; }
                        if (txtHoleNumber.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtHoleNumber.Text) < 0)
                                txtHoleNumber.Text = "0";
                            else if (Convert.ToDouble(txtHoleNumber.Text) > 50)
                                txtHoleNumber.Text = "50";
                        }
                        else { txtHoleNumber.Text = "0"; }

                        #endregion
                        string script = "alert(\"Edit Flex Standard Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"Edit Flex Standard Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Edit Flex Standard failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}