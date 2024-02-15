using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ATSCADAWebApp
{
    public partial class FrePage : System.Web.UI.Page
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
                btnApplyFreq.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
                    //load droplist frea
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Freq_Standard", "ID,Number", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        dt.Rows.Add(new object[] { "-1", "" });
                        drplStandard.DataSource = dt;
                        drplStandard.DataTextField = "Number";
                        drplStandard.DataValueField = "ID";
                        drplStandard.DataBind();
                    }
                    //doc bang Weight
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("Weight", "ID,Value", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        dt.Rows.Add(new object[] { "-1", "" });
                        drplWeight.DataSource = dt;
                        drplWeight.DataSource = dt;
                        drplWeight.DataTextField = "Value";
                        drplWeight.DataValueField = "ID";
                        drplWeight.DataBind();
                    }
                    //doc bang buttstop
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectData("ButtStop");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        rbtnLocation1.Text = dt.Rows[0][0].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][0].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation2.Text = dt.Rows[0][1].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][1].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation3.Text = dt.Rows[0][2].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][2].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation4.Text = dt.Rows[0][3].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][3].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation5.Text = dt.Rows[0][4].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][4].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation6.Text = dt.Rows[0][5].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][5].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation7.Text = dt.Rows[0][6].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][6].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation8.Text = dt.Rows[0][7].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][7].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation9.Text = dt.Rows[0][8].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][8].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                        rbtnLocation10.Text = dt.Rows[0][9].ToString() + " (" + (Convert.ToDouble(dt.Rows[0][9].ToString()) / 25.4).ToString("0.00") + '"' + ")";
                    }
                    //load part
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("Part", " where ID='" + BienChung.idPart + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        txtFreqLow.Text = dt.Rows[0][9].ToString();
                        txtFreqUp.Text = dt.Rows[0][10].ToString();
                        if (dt.Rows[0][13].ToString() != "")
                        {
                            string weightID = BienChung.sqlServer.selectdatatheoid("weight", "ID", "Value", dt.Rows[0][13].ToString());
                            drplWeight.SelectedValue = weightID;
                            if (weightID != null)
                            {
                                drplWeight.SelectedValue = weightID;
                            }
                            else
                            {
                                drplWeight.SelectedValue = "-1";
                            }
                        }
                        else
                            drplWeight.SelectedValue = "-1";
                        string Number = BienChung.sqlServer.selectdatatheoid("Freq_Standard", "Number", "ID", dt.Rows[0][11].ToString());
                        if (Number != null)
                        {
                            drplStandard.SelectedValue = dt.Rows[0][11].ToString();
                        }
                        else
                        {
                            drplStandard.SelectedValue = "-1";
                        }
                        #region chon butt stop
                        if (dt.Rows[0][12].ToString() != "")
                        {
                            if (rbtnLocation1.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation1.Checked = true;
                            }
                            else
                            {
                                rbtnLocation1.Checked = false;
                            }


                            if (rbtnLocation2.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation2.Checked = true;
                            }
                            else
                            {
                                rbtnLocation2.Checked = false;
                            }
                            if (rbtnLocation3.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation3.Checked = true;
                            }
                            else
                            {
                                rbtnLocation3.Checked = false;
                            }
                            if (rbtnLocation4.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation4.Checked = true;
                            }
                            else
                            {
                                rbtnLocation4.Checked = false;
                            }
                            if (rbtnLocation5.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation5.Checked = true;
                            }
                            else
                            {
                                rbtnLocation5.Checked = false;
                            }
                            if (rbtnLocation6.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation6.Checked = true;
                            }
                            else
                            {
                                rbtnLocation6.Checked = false;
                            }
                            if (rbtnLocation7.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation7.Checked = true;
                            }
                            else
                            {
                                rbtnLocation7.Checked = false;
                            }
                            if (rbtnLocation8.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation8.Checked = true;
                            }
                            else
                            {
                                rbtnLocation8.Checked = false;
                            }
                            if (rbtnLocation9.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation9.Checked = true;
                            }
                            else
                            {
                                rbtnLocation9.Checked = false;
                            }
                            if (rbtnLocation10.Text.Split(' ')[0] == Convert.ToDouble(dt.Rows[0][12]).ToString("0.00"))
                            {
                                rbtnLocation10.Checked = true;
                            }
                            else
                            {
                                rbtnLocation10.Checked = false;
                            }
                        }
                        else
                        {
                            rbtnLocation1.Checked = false;
                            rbtnLocation2.Checked = false;
                            rbtnLocation3.Checked = false;
                            rbtnLocation4.Checked = false;
                            rbtnLocation5.Checked = false;
                            rbtnLocation6.Checked = false;
                            rbtnLocation7.Checked = false;
                            rbtnLocation8.Checked = false;
                            rbtnLocation9.Checked = false;
                            rbtnLocation10.Checked = false;
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }

            }
        }

        protected void btnApplyFreq_Click(object sender, EventArgs e)
        {
            if (drplStandard.SelectedItem.Text != "" && drplWeight.SelectedItem.Text != ""
               && (rbtnLocation1.Checked == true || rbtnLocation2.Checked == true || rbtnLocation3.Checked == true || rbtnLocation4.Checked == true || rbtnLocation5.Checked == true
               || rbtnLocation6.Checked == true || rbtnLocation7.Checked == true || rbtnLocation8.Checked == true || rbtnLocation9.Checked == true || rbtnLocation10.Checked == true))
            {
                if (txtFreqLow.Text != "" && txtFreqUp.Text != "")
                {
                    if (Convert.ToDouble(txtFreqLow.Text) >= 100 && Convert.ToDouble(txtFreqLow.Text) <= 499.9 && Convert.ToDouble(txtFreqUp.Text) >= 100.1 && Convert.ToDouble(txtFreqUp.Text) <= 500
                        && (Convert.ToDouble(Convert.ToDouble(txtFreqUp.Text) - Convert.ToDouble(txtFreqLow.Text)) >= 0.09999))
                    {
                        string checkName = "";
                        if (rbtnLocation1.Checked == true)
                        {
                            checkName = rbtnLocation1.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation2.Checked == true)
                        {
                            checkName = rbtnLocation2.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation3.Checked == true)
                        {
                            checkName = rbtnLocation3.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation4.Checked == true)
                        {
                            checkName = rbtnLocation4.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation5.Checked == true)
                        {
                            checkName = rbtnLocation5.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation6.Checked == true)
                        {
                            checkName = rbtnLocation6.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation7.Checked == true)
                        {
                            checkName = rbtnLocation7.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation8.Checked == true)
                        {
                            checkName = rbtnLocation8.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation9.Checked == true)
                        {
                            checkName = rbtnLocation9.Text.Split(' ')[0];
                        }
                        else if (rbtnLocation10.Checked == true)
                        {
                            checkName = rbtnLocation10.Text.Split(' ')[0];
                        }
                        if (BienChung.sqlServer.Update("Part", "set Freq_LL='" + Convert.ToDouble(txtFreqLow.Text.Trim()).ToString("0.000") + "',Freq_UL='" + Convert.ToDouble(txtFreqUp.Text.Trim()).ToString("0.000") + "',Freq_BSL='" + checkName.Trim() + "',Freq_Wt='" + drplWeight.SelectedItem.Text + "',Freq_Std='" + drplStandard.SelectedItem.Value + "' where ID ='" + BienChung.idPart + "'") == "GOOD")
                        {
                            // access -----------------------------------------

                            string id = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                            if (id != null)
                            {
                                if (BienChung.AccessServer.Update("Part", "set Freq_LL=" + Convert.ToDouble(txtFreqLow.Text.Trim()).ToString("0.000") + ",Freq_UL=" + Convert.ToDouble(txtFreqUp.Text.Trim()).ToString("0.000") + ",Freq_BSL=" + (Convert.ToDouble(checkName.Trim()) / 25.4).ToString("0.00") + ",Freq_Wt=" + drplWeight.SelectedItem.Text + ",Freq_Std=" + drplStandard.SelectedItem.Value + " where ID=" + id + "") == "GOOD")
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
                            //BienChung.AccessServer.Update("Part", "set Freq_LL=" + Convert.ToDouble(txtFreqLow.Text.Trim()).ToString("0.000") + ",Freq_UL=" + Convert.ToDouble(txtFreqUp.Text.Trim()).ToString("0.000") + ",Freq_BSL=" + (Convert.ToDouble(checkName.Trim()) / 25.4).ToString("0.00") + ",Freq_Wt=" + drplWeight.SelectedItem.Text + ",Freq_Std=" + drplStandard.SelectedItem.Value + " where ID=" + id + "");

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
                        if (Convert.ToDouble(txtFreqLow.Text) < 100)
                            txtFreqLow.Text = "100";
                        else if (Convert.ToDouble(txtFreqLow.Text) > 499.9)
                            txtFreqLow.Text = "499.9";

                        if (Convert.ToDouble(txtFreqUp.Text) < 100.1)
                            txtFreqUp.Text = "100.1";
                        else if (Convert.ToDouble(txtFreqUp.Text) > 500)
                            txtFreqUp.Text = "500";
                        if ((Convert.ToDouble(txtFreqUp.Text) - Convert.ToDouble(txtFreqLow.Text)) < 0.1)
                        {
                            txtFreqLow.Text = (Convert.ToDouble(txtFreqUp.Text) - 0.1).ToString();
                        }

                        string script = "alert(\"Edit Frequence Failed!,Exceeded Min or Max value allowed\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    if (txtFreqLow.Text.Trim() != "")
                    {
                        if (Convert.ToDouble(txtFreqLow.Text) < 100)
                            txtFreqLow.Text = "100";
                        else if (Convert.ToDouble(txtFreqLow.Text) > 499.9)
                            txtFreqLow.Text = "499.9";
                    }
                    else { txtFreqLow.Text = "100"; }
                    if (txtFreqUp.Text.Trim() != "")
                    {
                        if (Convert.ToDouble(txtFreqUp.Text) < 100.1)
                            txtFreqUp.Text = "100.1";
                        else if (Convert.ToDouble(txtFreqUp.Text) > 500)
                            txtFreqUp.Text = "500";
                    }
                    else { txtFreqUp.Text = "100.1"; }
                    if ((Convert.ToDouble(txtFreqUp.Text) - Convert.ToDouble(txtFreqLow.Text)) < 0.1)
                    {
                        txtFreqLow.Text = (Convert.ToDouble(txtFreqUp.Text) - 0.1).ToString();
                    }
                    string script = "alert(\"Edit Frequence Failed!,Exceeded Min or Max value allowed\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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