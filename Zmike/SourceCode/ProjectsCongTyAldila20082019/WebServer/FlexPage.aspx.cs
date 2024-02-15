using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ATSCADAWebApp
{
    public partial class FlexPage : System.Web.UI.Page
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

                bntApplyEditFlex.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("Part", " where ID='" + BienChung.idPart + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {

                        txtFlexLow.Text = dt.Rows[0][2].ToString();
                        txtFlexUP.Text = dt.Rows[0][3].ToString();
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }

        }

        protected void bntApplyEditFlex_Click(object sender, EventArgs e)
        {
            if (txtFlexUP.Text.Trim() != "" && txtFlexLow.Text.Trim() != "")
            {
                if (Convert.ToDouble(txtFlexUP.Text) >= 2 && Convert.ToDouble(txtFlexUP.Text) <= 200 && Convert.ToDouble(txtFlexLow.Text) >= 1 && Convert.ToDouble(txtFlexLow.Text) <= 199.8
                     && Convert.ToDouble(Convert.ToDouble(txtFlexUP.Text) - Convert.ToDouble(txtFlexLow.Text)) >= 0.1999)
                {
                    if (BienChung.sqlServer.Update("Part", "set Flex_LL='" + Convert.ToDouble(txtFlexLow.Text.Trim()).ToString("0.000") + "',Flex_UL='" + Convert.ToDouble(txtFlexUP.Text.Trim()).ToString("0.000") + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                    {
                        //access-------------------------------------------------------

                        string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                        if (id != null)
                        {
                            if (BienChung.AccessServer.Update("Part", "set Flex_LL=" + Convert.ToDouble(txtFlexLow.Text.Trim()).ToString("0.000") + ",Flex_UL=" + Convert.ToDouble(txtFlexUP.Text.Trim()).ToString("0.000") + " where ID=" + id + "") == "GOOD")
                            {
                                string script = "alert(\"Apply successful!\");";
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


                        //--------------------------------------------------------------

                    }
                    else
                    {
                        string script = "alert(\"Apply failed!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    if (Convert.ToDouble(txtFlexUP.Text) < 2)
                        txtFlexUP.Text = "2";
                    else if (Convert.ToDouble(txtFlexUP.Text) > 200)
                        txtFlexUP.Text = "200";
                    if (Convert.ToDouble(txtFlexLow.Text) < 1)
                        txtFlexLow.Text = "1";
                    else if (Convert.ToDouble(txtFlexLow.Text) > 199.8)
                        txtFlexLow.Text = "199.8";

                    if ((Convert.ToDouble(txtFlexUP.Text) - Convert.ToDouble(txtFlexLow.Text)) < 0.2)
                    {
                        txtFlexLow.Text = (Convert.ToDouble(txtFlexUP.Text) - 0.2).ToString();
                    }
                    string script = "alert(\"Edit Flex Failed!,Exceeded Min or Max value allowed\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            else
            {
                if (txtFlexUP.Text.Trim() != "")
                {
                    if (Convert.ToDouble(txtFlexUP.Text) < 2)
                        txtFlexUP.Text = "2";
                    else if (Convert.ToDouble(txtFlexUP.Text) > 200)
                        txtFlexUP.Text = "200";
                }
                else { txtFlexUP.Text = "2"; }
                if (txtFlexLow.Text.Trim() != "")
                {
                    if (Convert.ToDouble(txtFlexLow.Text) < 1)
                        txtFlexLow.Text = "1";
                    else if (Convert.ToDouble(txtFlexLow.Text) > 199.8)
                        txtFlexLow.Text = "199.8";
                }
                else { txtFlexLow.Text = "1"; }
                if ((Convert.ToDouble(txtFlexUP.Text) - Convert.ToDouble(txtFlexLow.Text)) < 0.2)
                {
                    txtFlexLow.Text = (Convert.ToDouble(txtFlexUP.Text) - 0.2).ToString();
                }
                string script = "alert(\"Edit Flex Failed!,Exceeded Min or Max value allowed\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }


        }
    }
}