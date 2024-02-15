using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ATSCADAWebApp
{
    public partial class SwingWPage : System.Web.UI.Page
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
               
                btnApplySwingWeight.Enabled = false;
                btnMeasType.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
                    //load part
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("Part", " where ID='" + BienChung.idPart + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                       
                        #region chon Meas Type
                        if (rbtnInchGrams.Text == dt.Rows[0][8].ToString())
                        {
                            rbtnInchGrams.Checked = true;
                        }
                        else
                        {
                            rbtnInchGrams.Checked = false;
                        }
                        if (rbtnInchOuces.Text == dt.Rows[0][8].ToString())
                        {
                            rbtnInchOuces.Checked = true;
                        }
                        else
                        {
                            rbtnInchOuces.Checked = false;
                        }
                        if (rbtnGramSwW.Text == dt.Rows[0][8].ToString())
                        {
                            rbtnGramSwW.Checked = true;
                        }
                        else
                        {
                            rbtnGramSwW.Checked = false;
                        }
                        if (rbtnGramSwWghtPoint.Text == dt.Rows[0][8].ToString())
                        {
                            rbtnGramSwWghtPoint.Checked = true;
                        }
                        else
                        {
                            rbtnGramSwWghtPoint.Checked = false;
                        }
                        if (rbtnCenterOfGra.Text == dt.Rows[0][8].ToString())
                        {
                            rbtnCenterOfGra.Checked = true;
                        }
                        else
                        {
                            rbtnCenterOfGra.Checked = false;
                        }
                        if (rbtnInchGrams.Checked == true)
                        {
                            btnMeasType.Text = rbtnInchGrams.Text;
                        }
                        else if (rbtnInchOuces.Checked == true)
                        {
                            btnMeasType.Text = rbtnInchOuces.Text;
                        }
                        else if (rbtnGramSwW.Checked == true)
                        {
                            btnMeasType.Text = rbtnGramSwW.Text;
                        }
                        else if (rbtnGramSwWghtPoint.Checked == true)
                        {
                            btnMeasType.Text = rbtnGramSwWghtPoint.Text;
                        }
                        else if (rbtnCenterOfGra.Checked == true)
                        {
                            btnMeasType.Text = rbtnCenterOfGra.Text;
                        }
                        else
                        {
                            btnMeasType.Text = "";
                        }
                        #endregion
                        txtLowLimit.Text = dt.Rows[0][4].ToString();
                        txtUpLimit.Text = dt.Rows[0][5].ToString();
                        txtWeightLow.Text = dt.Rows[0][6].ToString();
                        txtWeightUp.Text = dt.Rows[0][7].ToString();
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }

            }
        }
        protected void rbtnInchGrams_CheckedChanged(object sender, EventArgs e)
        {
            btnMeasType.Text = rbtnInchGrams.Text;
        }

        protected void rbtnInchOuces_CheckedChanged(object sender, EventArgs e)
        {
            btnMeasType.Text = rbtnInchOuces.Text;
        }

        protected void rbtnGramSwW_CheckedChanged(object sender, EventArgs e)
        {
            btnMeasType.Text = rbtnGramSwW.Text;
        }

        protected void rbtnGramSwWghtPoint_CheckedChanged(object sender, EventArgs e)
        {
            btnMeasType.Text = rbtnGramSwWghtPoint.Text;
        }

        protected void rbtnCenterOfGra_CheckedChanged(object sender, EventArgs e)
        {
            btnMeasType.Text = rbtnCenterOfGra.Text;
        }
        protected void btnApplySwingWeight_Click(object sender, EventArgs e)
        {
            if (rbtnInchGrams.Checked == true || rbtnInchOuces.Checked == true || rbtnGramSwW.Checked == true || rbtnGramSwWghtPoint.Checked == true || rbtnCenterOfGra.Checked == true)

            {
                if (rbtnInchGrams.Checked == true)
                {
                    if (txtUpLimit.Text != "" && txtLowLimit.Text != "" && txtWeightUp.Text != "" && txtWeightLow.Text != "")
                    {
                        if (Convert.ToDouble(txtUpLimit.Text) >= 0.001 && Convert.ToDouble(txtUpLimit.Text) <= 1000 && Convert.ToDouble(txtLowLimit.Text) >= 0 && Convert.ToDouble(txtLowLimit.Text) <= 999.999
                        && (Convert.ToDouble(Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) >= 0.000999)
                       && Convert.ToDouble(txtWeightUp.Text) >= 20.001 && Convert.ToDouble(txtWeightUp.Text) <= 250 && Convert.ToDouble(txtWeightLow.Text) >= 20 && Convert.ToDouble(txtWeightLow.Text) <= 249.999
                        && (Convert.ToDouble(Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) >= 0.000999))
                        {

                            if (BienChung.sqlServer.Update("Part", "set SW_LL='" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + "',SW_UL='" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + "',SW_Wt_LL='" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + "',SW_Wt_UL='" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + "',SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                            {
                                // access -----------------------------------------

                                string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number",BienChung.textPart);
                                if (id != null)
                                {
                                    if (BienChung.AccessServer.Update("Part", "set SW_LL=" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + ",SW_UL=" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + ",SW_Wt_LL=" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + ",SW_Wt_UL=" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + ",SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID=" + id + "") == "GOOD")
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

                                //--------------------------------------------------------

                            }
                            else
                            {
                                string script = "alert(\"Apply failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 0)
                                txtLowLimit.Text = "0";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 999.999)
                                txtLowLimit.Text = "999.999";

                            if (Convert.ToDouble(txtUpLimit.Text) < 0.001)
                                txtUpLimit.Text = "0.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 1000)
                                txtUpLimit.Text = "1000";

                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";

                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                            if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                            {
                                txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                            }
                            if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                            {
                                txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                            }
                            string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        if (txtLowLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 0)
                                txtLowLimit.Text = "0";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 999.999)
                                txtLowLimit.Text = "999.999";
                        }
                        else { txtLowLimit.Text = "0"; }
                        if (txtUpLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUpLimit.Text) < 0.001)
                                txtUpLimit.Text = "0.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 1000)
                                txtUpLimit.Text = "1000";
                        }
                        else { txtUpLimit.Text = "0.001"; }
                        if (txtWeightLow.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";
                        }
                        else { txtWeightLow.Text = "20"; }
                        if (txtWeightUp.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                        }
                        else { txtWeightUp.Text = "20.001"; }
                        if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                        {
                            txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                        }
                        if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                        {
                            txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                        }
                        string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else if (rbtnInchOuces.Checked == true || rbtnGramSwW.Checked == true)
                {
                    if (txtUpLimit.Text != "" && txtLowLimit.Text != "" && txtWeightUp.Text != "" && txtWeightLow.Text != "")
                    {
                        if (Convert.ToDouble(txtUpLimit.Text) >= 0.001 && Convert.ToDouble(txtUpLimit.Text) <= 100 && Convert.ToDouble(txtLowLimit.Text) >= 0 && Convert.ToDouble(txtLowLimit.Text) <= 99.999
                        && (Convert.ToDouble(Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) >= 0.000999)
                       && Convert.ToDouble(txtWeightUp.Text) >= 20.001 && Convert.ToDouble(txtWeightUp.Text) <= 250 && Convert.ToDouble(txtWeightLow.Text) >= 20 && Convert.ToDouble(txtWeightLow.Text) <= 249.999
                        && (Convert.ToDouble(Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) >= 0.000999))
                        {

                            if (BienChung.sqlServer.Update("Part", "set SW_LL='" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + "',SW_UL='" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + "',SW_Wt_LL='" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + "',SW_Wt_UL='" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + "',SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                            {
                                // access -----------------------------------------

                                string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number",BienChung.textPart);
                                if (id != null)
                                {
                                    if (BienChung.AccessServer.Update("Part", "set SW_LL=" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + ",SW_UL=" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + ",SW_Wt_LL=" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + ",SW_Wt_UL=" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + ",SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID=" + id + "") == "GOOD")
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
                                //--------------------------------------------------------
                            }
                            else
                            {
                                string script = "alert(\"Apply failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 0)
                                txtLowLimit.Text = "0";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 99.999)
                                txtLowLimit.Text = "99.999";

                            if (Convert.ToDouble(txtUpLimit.Text) < 0.001)
                                txtUpLimit.Text = "0.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 100)
                                txtUpLimit.Text = "100";

                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";

                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                            if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                            {
                                txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                            }
                            if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                            {
                                txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                            }
                            string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        if (txtLowLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 0)
                                txtLowLimit.Text = "0";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 99.999)
                                txtLowLimit.Text = "99.999";
                        }
                        else { txtLowLimit.Text = "0"; }
                        if (txtUpLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUpLimit.Text) < 0.001)
                                txtUpLimit.Text = "0.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 100)
                                txtUpLimit.Text = "100";
                        }
                        else { txtUpLimit.Text = "0.001"; }
                        if (txtWeightLow.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";
                        }
                        else { txtWeightLow.Text = "20"; }
                        if (txtWeightUp.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                        }
                        else { txtWeightUp.Text = "20.001"; }
                        if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                        {
                            txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                        }
                        if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                        {
                            txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                        }
                        string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else if (rbtnGramSwWghtPoint.Checked == true)
                {
                    if (txtUpLimit.Text != "" && txtLowLimit.Text != "" && txtWeightUp.Text != "" && txtWeightLow.Text != "")
                    {
                        if (Convert.ToDouble(txtUpLimit.Text) >= 2.001 && Convert.ToDouble(txtUpLimit.Text) <= 20 && Convert.ToDouble(txtLowLimit.Text) >= 2 && Convert.ToDouble(txtLowLimit.Text) <= 19.999
                        && (Convert.ToDouble(Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) >= 0.000999)
                       && Convert.ToDouble(txtWeightUp.Text) >= 20.001 && Convert.ToDouble(txtWeightUp.Text) <= 250 && Convert.ToDouble(txtWeightLow.Text) >= 20 && Convert.ToDouble(txtWeightLow.Text) <= 249.999
                        && (Convert.ToDouble(Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) >= 0.000999))
                        {

                            if (BienChung.sqlServer.Update("Part", "set SW_LL='" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + "',SW_UL='" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + "',SW_Wt_LL='" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + "',SW_Wt_UL='" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + "',SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                            {
                                // access -----------------------------------------

                                string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                if (id != null)
                                {
                                    if (BienChung.AccessServer.Update("Part", "set SW_LL=" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + ",SW_UL=" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + ",SW_Wt_LL=" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + ",SW_Wt_UL=" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + ",SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID=" + id + "") == "GOOD")
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

                                //--------------------------------------------------------

                            }
                            else
                            {
                                string script = "alert(\"Apply failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 2)
                                txtLowLimit.Text = "2";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 19.999)
                                txtLowLimit.Text = "19.999";

                            if (Convert.ToDouble(txtUpLimit.Text) < 2.001)
                                txtUpLimit.Text = "2.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 20)
                                txtUpLimit.Text = "20";

                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";

                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                            if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                            {
                                txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                            }
                            if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                            {
                                txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                            }
                            string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        if (txtLowLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 2)
                                txtLowLimit.Text = "2";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 19.999)
                                txtLowLimit.Text = "19.999";
                        }
                        else { txtLowLimit.Text = "2"; }
                        if (txtUpLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUpLimit.Text) < 2.001)
                                txtUpLimit.Text = "2.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 20)
                                txtUpLimit.Text = "20";
                        }
                        else { txtUpLimit.Text = "2.001"; }
                        if (txtWeightLow.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";
                        }
                        else { txtWeightLow.Text = "20"; }
                        if (txtWeightUp.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                        }
                        else { txtWeightUp.Text = "20.001"; }
                        if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                        {
                            txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                        }
                        if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                        {
                            txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                        }
                        string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else if (rbtnCenterOfGra.Checked == true)
                {
                    if (txtUpLimit.Text != "" && txtLowLimit.Text != "" && txtWeightUp.Text != "" && txtWeightLow.Text != "")
                    {
                        if (Convert.ToDouble(txtUpLimit.Text) >= 10.001 && Convert.ToDouble(txtUpLimit.Text) <= 30 && Convert.ToDouble(txtLowLimit.Text) >= 10 && Convert.ToDouble(txtLowLimit.Text) <= 29.999
                        && (Convert.ToDouble(Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) >= 0.000999)
                       && Convert.ToDouble(txtWeightUp.Text) >= 20.001 && Convert.ToDouble(txtWeightUp.Text) <= 250 && Convert.ToDouble(txtWeightLow.Text) >= 20 && Convert.ToDouble(txtWeightLow.Text) <= 249.999
                        && (Convert.ToDouble(Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) >= 0.000999))
                        {

                            if (BienChung.sqlServer.Update("Part", "set SW_LL='" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + "',SW_UL='" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + "',SW_Wt_LL='" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + "',SW_Wt_UL='" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + "',SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                            {
                                // access -----------------------------------------

                                string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                if (id != null)
                                {
                                    if (BienChung.AccessServer.Update("Part", "set SW_LL=" + Convert.ToDouble(txtLowLimit.Text.Trim()).ToString("0.000") + ",SW_UL=" + Convert.ToDouble(txtUpLimit.Text.Trim()).ToString("0.000") + ",SW_Wt_LL=" + Convert.ToDouble(txtWeightLow.Text.Trim()).ToString("0.000") + ",SW_Wt_UL=" + Convert.ToDouble(txtWeightUp.Text.Trim()).ToString("0.000") + ",SW_Meas_Type='" + btnMeasType.Text.Trim() + "' where ID=" + id + "") == "GOOD")
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
                                //--------------------------------------------------------
                            }
                            else
                            {
                                string script = "alert(\"Apply failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 10)
                                txtLowLimit.Text = "10";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 29.999)
                                txtLowLimit.Text = "29.999";

                            if (Convert.ToDouble(txtUpLimit.Text) < 10.001)
                                txtUpLimit.Text = "10.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 30)
                                txtUpLimit.Text = "30";

                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";

                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                            if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                            {
                                txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                            }
                            if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                            {
                                txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                            }
                            string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        if (txtLowLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLowLimit.Text) < 10)
                                txtLowLimit.Text = "10";
                            else if (Convert.ToDouble(txtLowLimit.Text) > 29.999)
                                txtLowLimit.Text = "29.999";
                        }
                        else { txtLowLimit.Text = "10"; }
                        if (txtUpLimit.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUpLimit.Text) < 10.001)
                                txtUpLimit.Text = "10.001";
                            else if (Convert.ToDouble(txtUpLimit.Text) > 30)
                                txtUpLimit.Text = "30";
                        }
                        else { txtUpLimit.Text = "10.001"; }
                        if (txtWeightLow.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightLow.Text) < 20)
                                txtWeightLow.Text = "20";
                            else if (Convert.ToDouble(txtWeightLow.Text) > 249.999)
                                txtWeightLow.Text = "249.999";
                        }
                        else { txtWeightLow.Text = "20"; }
                        if (txtWeightUp.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtWeightUp.Text) < 20.001)
                                txtWeightUp.Text = "20.001";
                            else if (Convert.ToDouble(txtWeightUp.Text) > 250)
                                txtWeightUp.Text = "250";
                        }
                        else { txtWeightUp.Text = "20.001"; }
                        if ((Convert.ToDouble(txtUpLimit.Text) - Convert.ToDouble(txtLowLimit.Text)) < 0.001)
                        {
                            txtLowLimit.Text = (Convert.ToDouble(txtUpLimit.Text) - 0.001).ToString();
                        }
                        if ((Convert.ToDouble(txtWeightUp.Text) - Convert.ToDouble(txtWeightLow.Text)) < 0.001)
                        {
                            txtWeightLow.Text = (Convert.ToDouble(txtWeightUp.Text) - 0.001).ToString();
                        }
                        string script = "alert(\"Edit Swing Weight Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
            else
            {
                string script = "alert(\"Apply failed!, Wrong data!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}