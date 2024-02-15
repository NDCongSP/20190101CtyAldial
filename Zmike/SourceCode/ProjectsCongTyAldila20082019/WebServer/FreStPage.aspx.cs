using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ATSCADAWebApp
{
    public partial class FreStPage : System.Web.UI.Page
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
                btnApplyAddNumber.Enabled = false;
                btnApplyDeleteNumber.Enabled = false;
                btnApplyEditNumber.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    //doc bang Freq_standard
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Freq_Standard", "ID,Number", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        drplEditStand.DataSource = drplDeleteStand.DataSource = dt;
                        drplEditStand.DataTextField = "Number";
                        drplEditStand.DataValueField = "ID";
                        drplDeleteStand.DataTextField = "Number";
                        drplDeleteStand.DataValueField = "ID";
                        drplEditStand.DataBind();
                        drplDeleteStand.DataBind();
                        txtEditStd.Text = drplEditStand.SelectedItem.Text;
                    }

                    //doc bang buttstop
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectData("ButtStop");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        lblLL1.Text = dt.Rows[0][0].ToString() + " LL";
                        lblUL1.Text = dt.Rows[0][0].ToString() + " UL";
                        lblLL2.Text = dt.Rows[0][1].ToString() + " LL";
                        lblUL2.Text = dt.Rows[0][1].ToString() + " UL";
                        lblLL3.Text = dt.Rows[0][2].ToString() + " LL";
                        lblUL3.Text = dt.Rows[0][2].ToString() + " UL";
                        lblLL4.Text = dt.Rows[0][3].ToString() + " LL";
                        lblUL4.Text = dt.Rows[0][3].ToString() + " UL";
                        lblLL5.Text = dt.Rows[0][4].ToString() + " LL";
                        lblUL5.Text = dt.Rows[0][4].ToString() + " UL";
                        lblLL6.Text = dt.Rows[0][5].ToString() + " LL";
                        lblUL6.Text = dt.Rows[0][5].ToString() + " UL";
                        lblLL7.Text = dt.Rows[0][6].ToString() + " LL";
                        lblUL7.Text = dt.Rows[0][6].ToString() + " UL";
                        lblLL8.Text = dt.Rows[0][7].ToString() + " LL";
                        lblUL8.Text = dt.Rows[0][7].ToString() + " UL";
                        lblLL9.Text = dt.Rows[0][8].ToString() + " LL";
                        lblUL9.Text = dt.Rows[0][8].ToString() + " UL";
                        lblLL10.Text = dt.Rows[0][9].ToString() + " LL";
                        lblUL10.Text = dt.Rows[0][9].ToString() + " UL";
                    }
                    loaddulieuFreqstandard();
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }
            }
        }
        void loaddulieuFreqstandard()
        {
            try
            {
                if (dt != null)
                {
                    dt.Clear();
                }
                dt = BienChung.sqlServer.SelectDataWhere("Freq_standard", " where ID='" + drplEditStand.SelectedItem.Value + "'");
                if (dt != null && dt.Rows.Count != 0)
                {
                    txtUL1.Text = dt.Rows[0][2].ToString();
                    txtLL1.Text = dt.Rows[0][3].ToString();
                    txtUL2.Text = dt.Rows[0][4].ToString();
                    txtLL2.Text = dt.Rows[0][5].ToString();
                    txtUL3.Text = dt.Rows[0][6].ToString();
                    txtLL3.Text = dt.Rows[0][7].ToString();
                    txtUL4.Text = dt.Rows[0][8].ToString();
                    txtLL4.Text = dt.Rows[0][9].ToString();
                    txtUL5.Text = dt.Rows[0][10].ToString();
                    txtLL5.Text = dt.Rows[0][11].ToString();
                    txtUL6.Text = dt.Rows[0][12].ToString();
                    txtLL6.Text = dt.Rows[0][13].ToString();
                    txtUL7.Text = dt.Rows[0][14].ToString();
                    txtLL7.Text = dt.Rows[0][15].ToString();
                    txtUL8.Text = dt.Rows[0][16].ToString();
                    txtLL8.Text = dt.Rows[0][17].ToString();
                    txtUL9.Text = dt.Rows[0][18].ToString();
                    txtLL9.Text = dt.Rows[0][19].ToString();
                    txtUL10.Text = dt.Rows[0][20].ToString();
                    txtLL10.Text = dt.Rows[0][21].ToString();
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        protected void drplEditStand_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddulieuFreqstandard();
            txtEditStd.Text = drplEditStand.SelectedItem.Text;
        }
        void loaddroplistFreq(string lenh)
        {
            try
            {
                string FreqEditValueCu = drplEditStand.SelectedItem.Value;
                string FreqDeleteValueCu = drplDeleteStand.SelectedItem.Value;
                if (dtLoadDroplist != null)
                {
                    dtLoadDroplist.Clear();
                }
                dtLoadDroplist = BienChung.sqlServer.selectdatatheocot("Freq_Standard", "ID,Number", "");
                if (dtLoadDroplist != null && dtLoadDroplist.Rows.Count != 0)
                {
                    drplEditStand.DataSource = drplDeleteStand.DataSource = dtLoadDroplist;
                    drplEditStand.DataTextField = "Number";
                    drplEditStand.DataValueField = "ID";
                    drplDeleteStand.DataTextField = "Number";
                    drplDeleteStand.DataValueField = "ID";
                    drplEditStand.DataBind();
                    drplDeleteStand.DataBind();
                    if (lenh == "Add")
                    {
                        drplEditStand.SelectedValue = FreqEditValueCu;
                    }
                    else if (lenh == "Edit")
                    {
                        drplEditStand.SelectedValue = FreqEditValueCu;
                        loaddulieuFreqstandard();
                    }
                    else if (lenh == "Delete")
                    {
                        if (FreqDeleteValueCu != FreqEditValueCu)
                        {
                            drplEditStand.SelectedValue = FreqEditValueCu;
                        }
                        else
                        {
                            loaddulieuFreqstandard();
                        }
                    }
                    txtEditStd.Text = drplEditStand.SelectedItem.Text;
                }
            }
            catch (Exception ex)
            {
                lbltest.Text = ex.ToString();
            }
        }
        protected void btnApplyAddNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddNumber.Text.Trim() != "" && txtAddNumber.Text.Trim().Length >= 4)
                {
                    if (BienChung.sqlServer.SelectDataWhere("Freq_Standard", "where Number='" + txtAddNumber.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                    {
                        if (BienChung.sqlServer.themData("Freq_Standard", "values('" + txtAddNumber.Text.Trim().ToUpper() + "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)") == "GOOD")
                        {
                            //ad accsess
                            if (BienChung.AccessServer.SelectDataWhere("Freq_Standard", "where Number='" + txtAddNumber.Text.Trim().ToUpper() + "'") == null)
                            {
                                BienChung.sqlServer.deletedata("Freq_Standard", "where [Number]='" + txtAddNumber.Text.Trim() + "'");
                                string script = "alert(\"Update Accsess Failed!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                            else if (BienChung.AccessServer.SelectDataWhere("Freq_Standard", "where Number='" + txtAddNumber.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                            {
                                if (BienChung.AccessServer.themData("Freq_Standard", "([Number],[735_UL],[735_LL],[625_UL],[625_LL],[600_UL],[600_LL],[500_UL],[500_LL],[700_UL],[700_LL]) values('" + txtAddNumber.Text.Trim().ToUpper() + "',0,0,0,0,0,0,0,0,0,0)") == "GOOD")
                                {
                                    loaddroplistFreq("Add");
                                    string script = "alert(\"Add Frequence Standard successful!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    BienChung.sqlServer.deletedata("Freq_Standard", "where [Number]='" + txtAddNumber.Text.Trim() + "'");
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
                            string script = "alert(\"Add Frequence Standard failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Frequence Standard already exists!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"Add Frequence Standard Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Add Frequence Standard failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyEditNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEditStd.Text.Trim() != "" && txtEditStd.Text.Trim().Length >= 4)
                {
                    if (txtUL1.Text.Trim() != "" && txtUL2.Text.Trim() != "" && txtUL3.Text.Trim() != "" && txtUL4.Text.Trim() != "" && txtUL5.Text.Trim() != "" && txtUL6.Text.Trim() != "" && txtUL7.Text.Trim() != "" && txtUL8.Text.Trim() != "" && txtUL9.Text.Trim() != "" && txtUL10.Text.Trim() != ""
                        && txtLL1.Text.Trim() != "" && txtLL2.Text.Trim() != "" && txtLL3.Text.Trim() != "" && txtLL4.Text.Trim() != "" && txtLL5.Text.Trim() != "" && txtLL6.Text.Trim() != "" && txtLL7.Text.Trim() != "" && txtLL8.Text.Trim() != "" && txtLL9.Text.Trim() != "" && txtLL10.Text.Trim() != "")
                    {
                        if (Convert.ToDouble(txtUL1.Text) >= 100.1 && Convert.ToDouble(txtUL1.Text) <= 500 && Convert.ToDouble(txtUL2.Text) >= 100.1 && Convert.ToDouble(txtUL2.Text) <= 500
                            && Convert.ToDouble(txtUL3.Text) >= 100.1 && Convert.ToDouble(txtUL3.Text) <= 500 && Convert.ToDouble(txtUL4.Text) >= 100.1 && Convert.ToDouble(txtUL4.Text) <= 500
                            && Convert.ToDouble(txtUL5.Text) >= 100.1 && Convert.ToDouble(txtUL5.Text) <= 500 && Convert.ToDouble(txtUL6.Text) >= 100.1 && Convert.ToDouble(txtUL6.Text) <= 500
                            && Convert.ToDouble(txtUL7.Text) >= 100.1 && Convert.ToDouble(txtUL7.Text) <= 500 && Convert.ToDouble(txtUL8.Text) >= 100.1 && Convert.ToDouble(txtUL8.Text) <= 500
                            && Convert.ToDouble(txtUL9.Text) >= 100.1 && Convert.ToDouble(txtUL9.Text) <= 500 && Convert.ToDouble(txtUL10.Text) >= 100.1 && Convert.ToDouble(txtUL10.Text) <= 500
                            && Convert.ToDouble(txtLL1.Text) >= 100 && Convert.ToDouble(txtLL1.Text) <= 499.9 && Convert.ToDouble(txtLL2.Text) >= 100 && Convert.ToDouble(txtLL2.Text) <= 499.9
                            && Convert.ToDouble(txtLL3.Text) >= 100 && Convert.ToDouble(txtLL3.Text) <= 499.9 && Convert.ToDouble(txtLL4.Text) >= 100 && Convert.ToDouble(txtLL4.Text) <= 499.9
                            && Convert.ToDouble(txtLL5.Text) >= 100 && Convert.ToDouble(txtLL5.Text) <= 499.9 && Convert.ToDouble(txtLL6.Text) >= 100 && Convert.ToDouble(txtLL6.Text) <= 499.9
                            && Convert.ToDouble(txtLL7.Text) >= 100 && Convert.ToDouble(txtLL7.Text) <= 499.9 && Convert.ToDouble(txtLL8.Text) >= 100 && Convert.ToDouble(txtLL8.Text) <= 499.9
                            && Convert.ToDouble(txtLL9.Text) >= 100 && Convert.ToDouble(txtLL9.Text) <= 499.9 && Convert.ToDouble(txtLL10.Text) >= 100 && Convert.ToDouble(txtLL10.Text) <= 499.9
                            && Convert.ToDouble(Convert.ToDouble(txtUL1.Text) - Convert.ToDouble(txtLL1.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL2.Text) - Convert.ToDouble(txtLL2.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL3.Text) - Convert.ToDouble(txtLL3.Text)) >= 0.09999
                            && Convert.ToDouble(Convert.ToDouble(txtUL4.Text) - Convert.ToDouble(txtLL4.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL5.Text) - Convert.ToDouble(txtLL5.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL6.Text) - Convert.ToDouble(txtLL6.Text)) >= 0.09999
                            && Convert.ToDouble(Convert.ToDouble(txtUL7.Text) - Convert.ToDouble(txtLL7.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL8.Text) - Convert.ToDouble(txtLL8.Text)) >= 0.09999 && Convert.ToDouble(Convert.ToDouble(txtUL9.Text) - Convert.ToDouble(txtLL9.Text)) >= 0.09999
                            && Convert.ToDouble(Convert.ToDouble(txtUL10.Text) - Convert.ToDouble(txtLL10.Text)) >= 0.09999
                            )
                        {
                            if (txtEditStd.Text.Trim().ToUpper() != drplEditStand.SelectedItem.Text)
                            {
                                if (BienChung.sqlServer.SelectDataWhere("Freq_Standard", "where Number='" + txtEditStd.Text.Trim().ToUpper() + "'").Rows.Count == 0)
                                {
                                    if (BienChung.sqlServer.Update("Freq_Standard", "set Number='" + txtEditStd.Text.Trim().ToUpper() + "',UL1='" + Convert.ToDouble(txtUL1.Text.Trim()).ToString("0.000") + "',LL1='" + Convert.ToDouble(txtLL1.Text.Trim()).ToString("0.000") + "',UL2='" + Convert.ToDouble(txtUL2.Text.Trim()).ToString("0.000") + "',LL2='" + Convert.ToDouble(txtLL2.Text.Trim()).ToString("0.000") + "'," +
                                        "UL3='" + Convert.ToDouble(txtUL3.Text.Trim()).ToString("0.000") + "',LL3='" + Convert.ToDouble(txtLL3.Text.Trim()).ToString("0.000") + "',UL4='" + Convert.ToDouble(txtUL4.Text.Trim()).ToString("0.000") + "',LL4='" + Convert.ToDouble(txtLL4.Text.Trim()).ToString("0.000") + "'," +
                                        "UL5='" + Convert.ToDouble(txtUL5.Text.Trim()).ToString("0.000") + "',LL5='" + Convert.ToDouble(txtLL5.Text.Trim()).ToString("0.000") + "',UL6='" + Convert.ToDouble(txtUL6.Text.Trim()).ToString("0.000") + "',LL6='" + Convert.ToDouble(txtLL6.Text.Trim()).ToString("0.000") + "'," +
                                        "UL7='" + Convert.ToDouble(txtUL7.Text.Trim()).ToString("0.000") + "',LL7='" + Convert.ToDouble(txtLL7.Text.Trim()).ToString("0.000") + "',UL8='" + Convert.ToDouble(txtUL8.Text.Trim()).ToString("0.000") + "',LL8='" + Convert.ToDouble(txtLL8.Text.Trim()).ToString("0.000") + "'," +
                                        "UL9='" + Convert.ToDouble(txtUL9.Text.Trim()).ToString("0.000") + "',LL9='" + Convert.ToDouble(txtLL9.Text.Trim()).ToString("0.000") + "',UL10='" + Convert.ToDouble(txtUL10.Text.Trim()).ToString("0.000") + "',LL10='" + Convert.ToDouble(txtLL10.Text.Trim()).ToString("0.000") + "' " +
                                        "where ID='" + drplEditStand.SelectedItem.Value + "'") == "GOOD")
                                    {
                                        //access----------------------------------------------

                                        string id = BienChung.AccessServer.selectdatatheoid("Freq_Standard", "ID", "Number", drplEditStand.SelectedItem.Text);
                                        if (id != null)
                                        {
                                            if (BienChung.AccessServer.Update("Freq_Standard", "set [Number]='" + txtEditStd.Text.Trim().ToUpper() + "',[735_UL]=" + Convert.ToDouble(txtUL1.Text.Trim()).ToString("0.000") + ",[735_LL]=" + Convert.ToDouble(txtLL1.Text.Trim()).ToString("0.000") + ",[625_UL]=" + Convert.ToDouble(txtUL3.Text.Trim()).ToString("0.000") + "," +
                                                "[625_LL]=" + Convert.ToDouble(txtLL3.Text.Trim()).ToString("0.000") + ",[600_UL]=" + Convert.ToDouble(txtUL4.Text.Trim()).ToString("0.000") + ",[600_LL]=" + Convert.ToDouble(txtLL4.Text.Trim()).ToString("0.000") + ",[500_UL]=" + Convert.ToDouble(txtUL5.Text.Trim()).ToString("0.000") + "," +
                                                "[500_LL]=" + Convert.ToDouble(txtLL5.Text.Trim()).ToString("0.000") + ",[700_UL]=" + Convert.ToDouble(txtUL2.Text.Trim()).ToString("0.000") + ",[700_LL]=" + Convert.ToDouble(txtLL2.Text.Trim()).ToString("0.000") + " where ID = " + id + "") == "GOOD")
                                            {
                                                loaddroplistFreq("Edit");
                                                string script = "alert(\"Edit Frequence Standard successful!\");";
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
                                        string script = "alert(\"Edit Frequence Standard failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }


                                }
                                else
                                {
                                    string script = "alert(\"Frequence Standard already exists!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                            else
                            {
                                if (BienChung.sqlServer.Update("Freq_Standard", "set Number='" + txtEditStd.Text.Trim().ToUpper() + "',UL1='" + Convert.ToDouble(txtUL1.Text.Trim()).ToString("0.000") + "',LL1='" + Convert.ToDouble(txtLL1.Text.Trim()).ToString("0.000") + "',UL2='" + Convert.ToDouble(txtUL2.Text.Trim()).ToString("0.000") + "',LL2='" + Convert.ToDouble(txtLL2.Text.Trim()).ToString("0.000") + "'," +
                                        "UL3='" + Convert.ToDouble(txtUL3.Text.Trim()).ToString("0.000") + "',LL3='" + Convert.ToDouble(txtLL3.Text.Trim()).ToString("0.000") + "',UL4='" + Convert.ToDouble(txtUL4.Text.Trim()).ToString("0.000") + "',LL4='" + Convert.ToDouble(txtLL4.Text.Trim()).ToString("0.000") + "'," +
                                        "UL5='" + Convert.ToDouble(txtUL5.Text.Trim()).ToString("0.000") + "',LL5='" + Convert.ToDouble(txtLL5.Text.Trim()).ToString("0.000") + "',UL6='" + Convert.ToDouble(txtUL6.Text.Trim()).ToString("0.000") + "',LL6='" + Convert.ToDouble(txtLL6.Text.Trim()).ToString("0.000") + "'," +
                                        "UL7='" + Convert.ToDouble(txtUL7.Text.Trim()).ToString("0.000") + "',LL7='" + Convert.ToDouble(txtLL7.Text.Trim()).ToString("0.000") + "',UL8='" + Convert.ToDouble(txtUL8.Text.Trim()).ToString("0.000") + "',LL8='" + Convert.ToDouble(txtLL8.Text.Trim()).ToString("0.000") + "'," +
                                        "UL9='" + Convert.ToDouble(txtUL9.Text.Trim()).ToString("0.000") + "',LL9='" + Convert.ToDouble(txtLL9.Text.Trim()).ToString("0.000") + "',UL10='" + Convert.ToDouble(txtUL10.Text.Trim()).ToString("0.000") + "',LL10='" + Convert.ToDouble(txtLL10.Text.Trim()).ToString("0.000") + "' " +
                                        "where ID='" + drplEditStand.SelectedItem.Value + "'") == "GOOD")
                                {
                                    //access----------------------------------------------------

                                    string id = BienChung.AccessServer.selectdatatheoid("Freq_Standard", "ID", "Number", drplEditStand.SelectedItem.Text);
                                    if (id != null)
                                    {
                                        if (BienChung.AccessServer.Update("Freq_Standard", "set [Number]='" + txtEditStd.Text.Trim().ToUpper() + "',[735_UL]=" + Convert.ToDouble(txtUL1.Text.Trim()).ToString("0.000") + ",[735_LL]=" + Convert.ToDouble(txtLL1.Text.Trim()).ToString("0.000") + ",[625_UL]=" + Convert.ToDouble(txtUL3.Text.Trim()).ToString("0.000") + "," +
                                            "[625_LL]=" + Convert.ToDouble(txtLL3.Text.Trim()).ToString("0.000") + ",[600_UL]=" + Convert.ToDouble(txtUL4.Text.Trim()).ToString("0.000") + ",[600_LL]=" + Convert.ToDouble(txtLL4.Text.Trim()).ToString("0.000") + ",[500_UL]=" + Convert.ToDouble(txtUL5.Text.Trim()).ToString("0.000") + "," +
                                            "[500_LL]=" + Convert.ToDouble(txtLL5.Text.Trim()).ToString("0.000") + ",[700_UL]=" + Convert.ToDouble(txtUL2.Text.Trim()).ToString("0.000") + ",[700_LL]=" + Convert.ToDouble(txtLL2.Text.Trim()).ToString("0.000") + " where ID = " + id + "") == "GOOD")
                                        {
                                            loaddroplistFreq("Edit");
                                            string script = "alert(\"Edit Frequence Standard successful!\");";
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
                                    string script = "alert(\"Edit Frequence Standard failed!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                            }
                        }
                        else
                        {
                            #region SUA LẠI TEBOX
                            if (Convert.ToDouble(txtUL1.Text) < 100.1)
                                txtUL1.Text = "100.1";
                            else if (Convert.ToDouble(txtUL1.Text) > 500)
                                txtUL1.Text = "500";
                            if (Convert.ToDouble(txtUL2.Text) < 100.1)
                                txtUL2.Text = "100.1";
                            else if (Convert.ToDouble(txtUL2.Text) > 500)
                                txtUL2.Text = "500";
                            if (Convert.ToDouble(txtUL3.Text) < 100.1)
                                txtUL3.Text = "100.1";
                            else if (Convert.ToDouble(txtUL3.Text) > 500)
                                txtUL3.Text = "500";
                            if (Convert.ToDouble(txtUL4.Text) < 100.1)
                                txtUL4.Text = "100.1";
                            else if (Convert.ToDouble(txtUL4.Text) > 500)
                                txtUL4.Text = "500";
                            if (Convert.ToDouble(txtUL5.Text) < 100.1)
                                txtUL5.Text = "100.1";
                            else if (Convert.ToDouble(txtUL5.Text) > 500)
                                txtUL5.Text = "500";
                            if (Convert.ToDouble(txtUL6.Text) < 100.1)
                                txtUL6.Text = "100.1";
                            else if (Convert.ToDouble(txtUL6.Text) > 500)
                                txtUL6.Text = "500";
                            if (Convert.ToDouble(txtUL7.Text) < 100.1)
                                txtUL7.Text = "100.1";
                            else if (Convert.ToDouble(txtUL7.Text) > 500)
                                txtUL7.Text = "500";
                            if (Convert.ToDouble(txtUL8.Text) < 100.1)
                                txtUL8.Text = "100.1";
                            else if (Convert.ToDouble(txtUL8.Text) > 500)
                                txtUL8.Text = "500";
                            if (Convert.ToDouble(txtUL9.Text) < 100.1)
                                txtUL9.Text = "100.1";
                            else if (Convert.ToDouble(txtUL9.Text) > 500)
                                txtUL9.Text = "500";
                            if (Convert.ToDouble(txtUL10.Text) < 100.1)
                                txtUL10.Text = "100.1";
                            else if (Convert.ToDouble(txtUL10.Text) > 500)
                                txtUL10.Text = "500";
                            if (Convert.ToDouble(txtLL1.Text) < 100)
                                txtLL1.Text = "100";
                            else if (Convert.ToDouble(txtLL1.Text) > 499.9)
                                txtLL1.Text = "499.9";
                            if (Convert.ToDouble(txtLL2.Text) < 100)
                                txtLL2.Text = "100";
                            else if (Convert.ToDouble(txtLL2.Text) > 499.9)
                                txtLL2.Text = "499.9";
                            if (Convert.ToDouble(txtLL3.Text) < 100)
                                txtLL3.Text = "100";
                            else if (Convert.ToDouble(txtLL3.Text) > 499.9)
                                txtLL3.Text = "499.9";
                            if (Convert.ToDouble(txtLL4.Text) < 100)
                                txtLL4.Text = "100";
                            else if (Convert.ToDouble(txtLL4.Text) > 499.9)
                                txtLL4.Text = "499.9";
                            if (Convert.ToDouble(txtLL5.Text) < 100)
                                txtLL5.Text = "100";
                            else if (Convert.ToDouble(txtLL5.Text) > 499.9)
                                txtLL5.Text = "499.9";
                            if (Convert.ToDouble(txtLL6.Text) < 100)
                                txtLL6.Text = "100";
                            else if (Convert.ToDouble(txtLL6.Text) > 499.9)
                                txtLL6.Text = "499.9";
                            if (Convert.ToDouble(txtLL7.Text) < 100)
                                txtLL7.Text = "100";
                            else if (Convert.ToDouble(txtLL7.Text) > 499.9)
                                txtLL7.Text = "499.9";
                            if (Convert.ToDouble(txtLL8.Text) < 100)
                                txtLL8.Text = "100";
                            else if (Convert.ToDouble(txtLL8.Text) > 499.9)
                                txtLL8.Text = "499.9";
                            if (Convert.ToDouble(txtLL9.Text) < 100)
                                txtLL9.Text = "100";
                            else if (Convert.ToDouble(txtLL9.Text) > 499.9)
                                txtLL9.Text = "499.9";
                            if (Convert.ToDouble(txtLL10.Text) < 100)
                                txtLL10.Text = "100";
                            else if (Convert.ToDouble(txtLL10.Text) > 499.9)
                                txtLL10.Text = "499.9";

                            if ((Convert.ToDouble(txtUL1.Text) - Convert.ToDouble(txtLL1.Text)) < 0.1)
                            {
                                txtLL1.Text = (Convert.ToDouble(txtUL1.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL2.Text) - Convert.ToDouble(txtLL2.Text)) < 0.1)
                            {
                                txtLL2.Text = (Convert.ToDouble(txtUL2.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL3.Text) - Convert.ToDouble(txtLL3.Text)) < 0.1)
                            {
                                txtLL3.Text = (Convert.ToDouble(txtUL3.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL4.Text) - Convert.ToDouble(txtLL4.Text)) < 0.1)
                            {
                                txtLL4.Text = (Convert.ToDouble(txtUL4.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL5.Text) - Convert.ToDouble(txtLL5.Text)) < 0.1)
                            {
                                txtLL5.Text = (Convert.ToDouble(txtUL5.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL6.Text) - Convert.ToDouble(txtLL6.Text)) < 0.1)
                            {
                                txtLL6.Text = (Convert.ToDouble(txtUL6.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL7.Text) - Convert.ToDouble(txtLL7.Text)) < 0.1)
                            {
                                txtLL7.Text = (Convert.ToDouble(txtUL7.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL8.Text) - Convert.ToDouble(txtLL8.Text)) < 0.1)
                            {
                                txtLL8.Text = (Convert.ToDouble(txtUL8.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL9.Text) - Convert.ToDouble(txtLL9.Text)) < 0.1)
                            {
                                txtLL9.Text = (Convert.ToDouble(txtUL9.Text) - 0.1).ToString();
                            }
                            if ((Convert.ToDouble(txtUL10.Text) - Convert.ToDouble(txtLL10.Text)) < 0.1)
                            {
                                txtLL10.Text = (Convert.ToDouble(txtUL10.Text) - 0.1).ToString();
                            }
                            #endregion
                            string script = "alert(\"Edit Frequence Standard Failed!,Exceeded Min or Max value allowed\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        #region SUA LẠI TEBOX
                        if (txtUL1.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL1.Text) < 100.1)
                                txtUL1.Text = "100.1";
                            else if (Convert.ToDouble(txtUL1.Text) > 500)
                                txtUL1.Text = "500";
                        }
                        else { txtUL1.Text = "100.1"; }
                        if (txtUL2.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL2.Text) < 100.1)
                                txtUL2.Text = "100.1";
                            else if (Convert.ToDouble(txtUL2.Text) > 500)
                                txtUL2.Text = "500";
                        }
                        else { txtUL2.Text = "100.1"; }
                        if (txtUL3.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL3.Text) < 100.1)
                                txtUL3.Text = "100.1";
                            else if (Convert.ToDouble(txtUL3.Text) > 500)
                                txtUL3.Text = "500";
                        }
                        else { txtUL3.Text = "100.1"; }
                        if (txtUL4.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL4.Text) < 100.1)
                                txtUL4.Text = "100.1";
                            else if (Convert.ToDouble(txtUL4.Text) > 500)
                                txtUL4.Text = "500";
                        }
                        else { txtUL4.Text = "100.1"; }
                        if (txtUL5.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL5.Text) < 100.1)
                                txtUL5.Text = "100.1";
                            else if (Convert.ToDouble(txtUL5.Text) > 500)
                                txtUL5.Text = "500";
                        }
                        else { txtUL5.Text = "100.1"; }
                        if (txtUL6.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL6.Text) < 100.1)
                                txtUL6.Text = "100.1";
                            else if (Convert.ToDouble(txtUL6.Text) > 500)
                                txtUL6.Text = "500";
                        }
                        else { txtUL6.Text = "100.1"; }
                        if (txtUL7.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL7.Text) < 100.1)
                                txtUL7.Text = "100.1";
                            else if (Convert.ToDouble(txtUL7.Text) > 500)
                                txtUL7.Text = "500";
                        }
                        else { txtUL7.Text = "100.1"; }
                        if (txtUL8.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL8.Text) < 100.1)
                                txtUL8.Text = "100.1";
                            else if (Convert.ToDouble(txtUL8.Text) > 500)
                                txtUL8.Text = "500";
                        }
                        else { txtUL8.Text = "100.1"; }
                        if (txtUL9.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL9.Text) < 100.1)
                                txtUL9.Text = "100.1";
                            else if (Convert.ToDouble(txtUL9.Text) > 500)
                                txtUL9.Text = "500";
                        }
                        else { txtUL9.Text = "100.1"; }
                        if (txtUL10.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtUL10.Text) < 100.1)
                                txtUL10.Text = "100.1";
                            else if (Convert.ToDouble(txtUL10.Text) > 500)
                                txtUL10.Text = "500";
                        }
                        else { txtUL10.Text = "100.1"; }
                        if (txtLL1.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL1.Text) < 100)
                                txtLL1.Text = "100";
                            else if (Convert.ToDouble(txtLL1.Text) > 499.9)
                                txtLL1.Text = "499.9";
                        }
                        else { txtLL1.Text = "100"; }
                        if (txtLL2.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL2.Text) < 100)
                                txtLL2.Text = "100";
                            else if (Convert.ToDouble(txtLL2.Text) > 499.9)
                                txtLL2.Text = "499.9";
                        }
                        else { txtLL2.Text = "100"; }
                        if (txtLL3.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL3.Text) < 100)
                                txtLL3.Text = "100";
                            else if (Convert.ToDouble(txtLL3.Text) > 499.9)
                                txtLL3.Text = "499.9";
                        }
                        else { txtLL3.Text = "100"; }
                        if (txtLL4.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL4.Text) < 100)
                                txtLL4.Text = "100";
                            else if (Convert.ToDouble(txtLL4.Text) > 499.9)
                                txtLL4.Text = "499.9";
                        }
                        else { txtLL4.Text = "100"; }
                        if (txtLL5.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL5.Text) < 100)
                                txtLL5.Text = "100";
                            else if (Convert.ToDouble(txtLL5.Text) > 499.9)
                                txtLL5.Text = "499.9";
                        }
                        else { txtLL5.Text = "100"; }
                        if (txtLL6.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL6.Text) < 100)
                                txtLL6.Text = "100";
                            else if (Convert.ToDouble(txtLL6.Text) > 499.9)
                                txtLL6.Text = "499.9";
                        }
                        else { txtLL6.Text = "100"; }
                        if (txtLL7.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL7.Text) < 100)
                                txtLL7.Text = "100";
                            else if (Convert.ToDouble(txtLL7.Text) > 499.9)
                                txtLL7.Text = "499.9";
                        }
                        else { txtLL7.Text = "100"; }
                        if (txtLL8.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL8.Text) < 100)
                                txtLL8.Text = "100";
                            else if (Convert.ToDouble(txtLL8.Text) > 499.9)
                                txtLL8.Text = "499.9";
                        }
                        else { txtLL8.Text = "100"; }
                        if (txtLL9.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL9.Text) < 100)
                                txtLL9.Text = "100";
                            else if (Convert.ToDouble(txtLL9.Text) > 499.9)
                                txtLL9.Text = "499.9";
                        }
                        else { txtLL9.Text = "100"; }
                        if (txtLL10.Text.Trim() != "")
                        {
                            if (Convert.ToDouble(txtLL10.Text) < 100)
                                txtLL10.Text = "100";
                            else if (Convert.ToDouble(txtLL10.Text) > 499.9)
                                txtLL10.Text = "499.9";
                        }
                        else { txtLL10.Text = "100"; }
                        if ((Convert.ToDouble(txtUL1.Text) - Convert.ToDouble(txtLL1.Text)) < 0.1)
                        {
                            txtLL1.Text = (Convert.ToDouble(txtUL1.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL2.Text) - Convert.ToDouble(txtLL2.Text)) < 0.1)
                        {
                            txtLL2.Text = (Convert.ToDouble(txtUL2.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL3.Text) - Convert.ToDouble(txtLL3.Text)) < 0.1)
                        {
                            txtLL3.Text = (Convert.ToDouble(txtUL3.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL4.Text) - Convert.ToDouble(txtLL4.Text)) < 0.1)
                        {
                            txtLL4.Text = (Convert.ToDouble(txtUL4.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL5.Text) - Convert.ToDouble(txtLL5.Text)) < 0.1)
                        {
                            txtLL5.Text = (Convert.ToDouble(txtUL5.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL6.Text) - Convert.ToDouble(txtLL6.Text)) < 0.1)
                        {
                            txtLL6.Text = (Convert.ToDouble(txtUL6.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL7.Text) - Convert.ToDouble(txtLL7.Text)) < 0.1)
                        {
                            txtLL7.Text = (Convert.ToDouble(txtUL7.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL8.Text) - Convert.ToDouble(txtLL8.Text)) < 0.1)
                        {
                            txtLL8.Text = (Convert.ToDouble(txtUL8.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL9.Text) - Convert.ToDouble(txtLL9.Text)) < 0.1)
                        {
                            txtLL9.Text = (Convert.ToDouble(txtUL9.Text) - 0.1).ToString();
                        }
                        if ((Convert.ToDouble(txtUL10.Text) - Convert.ToDouble(txtLL10.Text)) < 0.1)
                        {
                            txtLL10.Text = (Convert.ToDouble(txtUL10.Text) - 0.1).ToString();
                        }
                        #endregion
                        string script = "alert(\"Edit Frequence Standard Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"Edit Frequence Standard Failed!,Characters of Number must be greater than or equal to 4\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Edit Frequence Standard failed!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnApplyDeleteNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (drplDeleteStand.Text.Trim() != "")
                {
                    if (BienChung.sqlServer.SelectDataWhere("Freq_Standard", "where Number='" + drplDeleteStand.SelectedItem.Text + "'").Rows.Count > 0)
                    {
                        if (BienChung.sqlServer.deletedata("Freq_Standard", "where ID='" + drplDeleteStand.SelectedItem.Value + "'") == "GOOD")
                        {
                            //access----------------------------------------------------

                            if (BienChung.AccessServer.deletedata("Freq_Standard", "where [Number]='" + drplDeleteStand.SelectedItem.Text + "'") == "GOOD")
                            {
                                loaddroplistFreq("Delete");
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
                        string script = "alert(\"Frequence Standard does not exist!\");";
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