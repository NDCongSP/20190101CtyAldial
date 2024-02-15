using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATSCADAWebApp
{
    public partial class ZMikePage : System.Web.UI.Page
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
                btnApplyEditZmike.Enabled = false;
            }
            #endregion
            if (!IsPostBack)
            {
                try
                {
                    lblPartSelecte.Text = "Part Selected : " + BienChung.textPart;
                    //doc bang ZMmeasType
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.selectdatatheocot("ZMmeasType", "ID,Name", "");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        dt.Rows.Add(new object[] { "-1", "" });
                        drplMeasType1.DataSource = drplMeasType2.DataSource = drplMeasType3.DataSource = drplMeasType4.DataSource = drplMeasType5.DataSource = dt;
                        drplMeasType6.DataSource = drplMeasType7.DataSource = drplMeasType8.DataSource = drplMeasType9.DataSource = drplMeasType10.DataSource = dt;
                        drplMeasType1.DataTextField = "Name";
                        drplMeasType1.DataValueField = "ID";
                        drplMeasType2.DataTextField = "Name";
                        drplMeasType2.DataValueField = "ID";
                        drplMeasType3.DataTextField = "Name";
                        drplMeasType3.DataValueField = "ID";
                        drplMeasType4.DataTextField = "Name";
                        drplMeasType4.DataValueField = "ID";
                        drplMeasType5.DataTextField = "Name";
                        drplMeasType5.DataValueField = "ID";
                        drplMeasType6.DataTextField = "Name";
                        drplMeasType6.DataValueField = "ID";
                        drplMeasType7.DataTextField = "Name";
                        drplMeasType7.DataValueField = "ID";
                        drplMeasType8.DataTextField = "Name";
                        drplMeasType8.DataValueField = "ID";
                        drplMeasType9.DataTextField = "Name";
                        drplMeasType9.DataValueField = "ID";
                        drplMeasType10.DataTextField = "Name";
                        drplMeasType10.DataValueField = "ID";
                        drplMeasType1.DataBind();
                        drplMeasType2.DataBind();
                        drplMeasType3.DataBind();
                        drplMeasType4.DataBind();
                        drplMeasType5.DataBind();
                        drplMeasType6.DataBind();
                        drplMeasType7.DataBind();
                        drplMeasType8.DataBind();
                        drplMeasType9.DataBind();
                        drplMeasType10.DataBind();
                    }
                    //load meas type
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = BienChung.sqlServer.SelectDataWhere("PartZM", " where PartID='" + BienChung.idPart + "'");
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        drplQtyMeasTypes.SelectedValue = dt.Rows.Count.ToString();
                    }
                    else
                    {
                        drplQtyMeasTypes.SelectedValue = "";
                    }

                    if (drplQtyMeasTypes.Text == "3")
                    {

                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = false;
                        txtDiamLL4.Visible = false;
                        txtDiamUL4.Visible = false;
                        txtMinUnder4.Visible = false;
                        txtMaxOder4.Visible = false;
                        drplMeasType5.Visible = false;
                        txtDiamLL5.Visible = false;
                        txtDiamUL5.Visible = false;
                        txtMinUnder5.Visible = false;
                        txtMaxOder5.Visible = false;
                        drplMeasType6.Visible = false;
                        txtDiamLL6.Visible = false;
                        txtDiamUL6.Visible = false;
                        txtMinUnder6.Visible = false;
                        txtMaxOder6.Visible = false;
                        drplMeasType7.Visible = false;
                        txtDiamLL7.Visible = false;
                        txtDiamUL7.Visible = false;
                        txtMinUnder7.Visible = false;
                        txtMaxOder7.Visible = false;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = "-1";
                        txtDiamLL4.Text = "";
                        txtDiamUL4.Text = "";
                        txtMinUnder4.Text = "";
                        txtMaxOder4.Text = "";
                        drplMeasType5.SelectedValue = "-1";
                        txtDiamLL5.Text = "";
                        txtDiamUL5.Text = "";
                        txtMinUnder5.Text = "";
                        txtMaxOder5.Text = "";
                        drplMeasType6.SelectedValue = "-1";
                        txtDiamLL6.Text = "";
                        txtDiamUL6.Text = "";
                        txtMinUnder6.Text = "";
                        txtMaxOder6.Text = "";
                        drplMeasType7.SelectedValue = "-1";
                        txtDiamLL7.Text = "";
                        txtDiamUL7.Text = "";
                        txtMinUnder7.Text = "";
                        txtMaxOder7.Text = "";
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";

                    }
                    else if (drplQtyMeasTypes.Text == "4")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = false;
                        txtDiamLL5.Visible = false;
                        txtDiamUL5.Visible = false;
                        txtMinUnder5.Visible = false;
                        txtMaxOder5.Visible = false;
                        drplMeasType6.Visible = false;
                        txtDiamLL6.Visible = false;
                        txtDiamUL6.Visible = false;
                        txtMinUnder6.Visible = false;
                        txtMaxOder6.Visible = false;
                        drplMeasType7.Visible = false;
                        txtDiamLL7.Visible = false;
                        txtDiamUL7.Visible = false;
                        txtMinUnder7.Visible = false;
                        txtMaxOder7.Visible = false;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = "-1";
                        txtDiamLL5.Text = "";
                        txtDiamUL5.Text = "";
                        txtMinUnder5.Text = "";
                        txtMaxOder5.Text = "";
                        drplMeasType6.SelectedValue = "-1";
                        txtDiamLL6.Text = "";
                        txtDiamUL6.Text = "";
                        txtMinUnder6.Text = "";
                        txtMaxOder6.Text = "";
                        drplMeasType7.SelectedValue = "-1";
                        txtDiamLL7.Text = "";
                        txtDiamUL7.Text = "";
                        txtMinUnder7.Text = "";
                        txtMaxOder7.Text = "";
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "5")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = false;
                        txtDiamLL6.Visible = false;
                        txtDiamUL6.Visible = false;
                        txtMinUnder6.Visible = false;
                        txtMaxOder6.Visible = false;
                        drplMeasType7.Visible = false;
                        txtDiamLL7.Visible = false;
                        txtDiamUL7.Visible = false;
                        txtMinUnder7.Visible = false;
                        txtMaxOder7.Visible = false;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = "-1";
                        txtDiamLL6.Text = "";
                        txtDiamUL6.Text = "";
                        txtMinUnder6.Text = "";
                        txtMaxOder6.Text = "";
                        drplMeasType7.SelectedValue = "-1";
                        txtDiamLL7.Text = "";
                        txtDiamUL7.Text = "";
                        txtMinUnder7.Text = "";
                        txtMaxOder7.Text = "";
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "6")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = true;
                        txtDiamLL6.Visible = true;
                        txtDiamUL6.Visible = true;
                        txtMinUnder6.Visible = true;
                        txtMaxOder6.Visible = true;
                        drplMeasType7.Visible = false;
                        txtDiamLL7.Visible = false;
                        txtDiamUL7.Visible = false;
                        txtMinUnder7.Visible = false;
                        txtMaxOder7.Visible = false;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = docZMtype(dt.Rows[5][1].ToString());
                        txtDiamLL6.Text = dt.Rows[5][2].ToString();
                        txtDiamUL6.Text = dt.Rows[5][3].ToString();
                        txtMinUnder6.Text = dt.Rows[5][4].ToString();
                        txtMaxOder6.Text = dt.Rows[5][5].ToString();
                        drplMeasType7.SelectedValue = "-1";
                        txtDiamLL7.Text = "";
                        txtDiamUL7.Text = "";
                        txtMinUnder7.Text = "";
                        txtMaxOder7.Text = "";
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "7")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = true;
                        txtDiamLL6.Visible = true;
                        txtDiamUL6.Visible = true;
                        txtMinUnder6.Visible = true;
                        txtMaxOder6.Visible = true;
                        drplMeasType7.Visible = true;
                        txtDiamLL7.Visible = true;
                        txtDiamUL7.Visible = true;
                        txtMinUnder7.Visible = true;
                        txtMaxOder7.Visible = true;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = docZMtype(dt.Rows[5][1].ToString());
                        txtDiamLL6.Text = dt.Rows[5][2].ToString();
                        txtDiamUL6.Text = dt.Rows[5][3].ToString();
                        txtMinUnder6.Text = dt.Rows[5][4].ToString();
                        txtMaxOder6.Text = dt.Rows[5][5].ToString();
                        drplMeasType7.SelectedValue = docZMtype(dt.Rows[6][1].ToString());
                        txtDiamLL7.Text = dt.Rows[6][2].ToString();
                        txtDiamUL7.Text = dt.Rows[6][3].ToString();
                        txtMinUnder7.Text = dt.Rows[6][4].ToString();
                        txtMaxOder7.Text = dt.Rows[6][5].ToString();
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "8")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = true;
                        txtDiamLL6.Visible = true;
                        txtDiamUL6.Visible = true;
                        txtMinUnder6.Visible = true;
                        txtMaxOder6.Visible = true;
                        drplMeasType7.Visible = true;
                        txtDiamLL7.Visible = true;
                        txtDiamUL7.Visible = true;
                        txtMinUnder7.Visible = true;
                        txtMaxOder7.Visible = true;
                        drplMeasType8.Visible = true;
                        txtDiamLL8.Visible = true;
                        txtDiamUL8.Visible = true;
                        txtMinUnder8.Visible = true;
                        txtMaxOder8.Visible = true;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = docZMtype(dt.Rows[5][1].ToString());
                        txtDiamLL6.Text = dt.Rows[5][2].ToString();
                        txtDiamUL6.Text = dt.Rows[5][3].ToString();
                        txtMinUnder6.Text = dt.Rows[5][4].ToString();
                        txtMaxOder6.Text = dt.Rows[5][5].ToString();
                        drplMeasType7.SelectedValue = docZMtype(dt.Rows[6][1].ToString());
                        txtDiamLL7.Text = dt.Rows[6][2].ToString();
                        txtDiamUL7.Text = dt.Rows[6][3].ToString();
                        txtMinUnder7.Text = dt.Rows[6][4].ToString();
                        txtMaxOder7.Text = dt.Rows[6][5].ToString();
                        drplMeasType8.SelectedValue = docZMtype(dt.Rows[7][1].ToString());
                        txtDiamLL8.Text = dt.Rows[7][2].ToString();
                        txtDiamUL8.Text = dt.Rows[7][3].ToString();
                        txtMinUnder8.Text = dt.Rows[7][4].ToString();
                        txtMaxOder8.Text = dt.Rows[7][5].ToString();
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "9")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = true;
                        txtDiamLL6.Visible = true;
                        txtDiamUL6.Visible = true;
                        txtMinUnder6.Visible = true;
                        txtMaxOder6.Visible = true;
                        drplMeasType7.Visible = true;
                        txtDiamLL7.Visible = true;
                        txtDiamUL7.Visible = true;
                        txtMinUnder7.Visible = true;
                        txtMaxOder7.Visible = true;
                        drplMeasType8.Visible = true;
                        txtDiamLL8.Visible = true;
                        txtDiamUL8.Visible = true;
                        txtMinUnder8.Visible = true;
                        txtMaxOder8.Visible = true;
                        drplMeasType9.Visible = true;
                        txtDiamLL9.Visible = true;
                        txtDiamUL9.Visible = true;
                        txtMinUnder9.Visible = true;
                        txtMaxOder9.Visible = true;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = docZMtype(dt.Rows[5][1].ToString());
                        txtDiamLL6.Text = dt.Rows[5][2].ToString();
                        txtDiamUL6.Text = dt.Rows[5][3].ToString();
                        txtMinUnder6.Text = dt.Rows[5][4].ToString();
                        txtMaxOder6.Text = dt.Rows[5][5].ToString();
                        drplMeasType7.SelectedValue = docZMtype(dt.Rows[6][1].ToString());
                        txtDiamLL7.Text = dt.Rows[6][2].ToString();
                        txtDiamUL7.Text = dt.Rows[6][3].ToString();
                        txtMinUnder7.Text = dt.Rows[6][4].ToString();
                        txtMaxOder7.Text = dt.Rows[6][5].ToString();
                        drplMeasType8.SelectedValue = docZMtype(dt.Rows[7][1].ToString());
                        txtDiamLL8.Text = dt.Rows[7][2].ToString();
                        txtDiamUL8.Text = dt.Rows[7][3].ToString();
                        txtMinUnder8.Text = dt.Rows[7][4].ToString();
                        txtMaxOder8.Text = dt.Rows[7][5].ToString();
                        drplMeasType9.SelectedValue = docZMtype(dt.Rows[8][1].ToString());
                        txtDiamLL9.Text = dt.Rows[8][2].ToString();
                        txtDiamUL9.Text = dt.Rows[8][3].ToString();
                        txtMinUnder9.Text = dt.Rows[8][4].ToString();
                        txtMaxOder9.Text = dt.Rows[8][5].ToString();
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                    else if (drplQtyMeasTypes.Text == "10")
                    {
                        drplMeasType1.Visible = true;
                        txtDiamLL1.Visible = true;
                        txtDiamUL1.Visible = true;
                        txtMinUnder1.Visible = true;
                        txtMaxOder1.Visible = true;
                        drplMeasType2.Visible = true;
                        txtDiamLL2.Visible = true;
                        txtDiamUL2.Visible = true;
                        txtMinUnder2.Visible = true;
                        txtMaxOder2.Visible = true;
                        drplMeasType3.Visible = true;
                        txtDiamLL3.Visible = true;
                        txtDiamUL3.Visible = true;
                        txtMinUnder3.Visible = true;
                        txtMaxOder3.Visible = true;
                        drplMeasType4.Visible = true;
                        txtDiamLL4.Visible = true;
                        txtDiamUL4.Visible = true;
                        txtMinUnder4.Visible = true;
                        txtMaxOder4.Visible = true;
                        drplMeasType5.Visible = true;
                        txtDiamLL5.Visible = true;
                        txtDiamUL5.Visible = true;
                        txtMinUnder5.Visible = true;
                        txtMaxOder5.Visible = true;
                        drplMeasType6.Visible = true;
                        txtDiamLL6.Visible = true;
                        txtDiamUL6.Visible = true;
                        txtMinUnder6.Visible = true;
                        txtMaxOder6.Visible = true;
                        drplMeasType7.Visible = true;
                        txtDiamLL7.Visible = true;
                        txtDiamUL7.Visible = true;
                        txtMinUnder7.Visible = true;
                        txtMaxOder7.Visible = true;
                        drplMeasType8.Visible = true;
                        txtDiamLL8.Visible = true;
                        txtDiamUL8.Visible = true;
                        txtMinUnder8.Visible = true;
                        txtMaxOder8.Visible = true;
                        drplMeasType9.Visible = true;
                        txtDiamLL9.Visible = true;
                        txtDiamUL9.Visible = true;
                        txtMinUnder9.Visible = true;
                        txtMaxOder9.Visible = true;
                        drplMeasType10.Visible = true;
                        txtDiamLL10.Visible = true;
                        txtDiamUL10.Visible = true;
                        txtMinUnder10.Visible = true;
                        txtMaxOder10.Visible = true;
                        drplMeasType1.SelectedValue = docZMtype(dt.Rows[0][1].ToString());
                        txtDiamLL1.Text = dt.Rows[0][2].ToString();
                        txtDiamUL1.Text = dt.Rows[0][3].ToString();
                        txtMinUnder1.Text = dt.Rows[0][4].ToString();
                        txtMaxOder1.Text = dt.Rows[0][5].ToString();
                        drplMeasType2.SelectedValue = docZMtype(dt.Rows[1][1].ToString());
                        txtDiamLL2.Text = dt.Rows[1][2].ToString();
                        txtDiamUL2.Text = dt.Rows[1][3].ToString();
                        txtMinUnder2.Text = dt.Rows[1][4].ToString();
                        txtMaxOder2.Text = dt.Rows[1][5].ToString();
                        drplMeasType3.SelectedValue = docZMtype(dt.Rows[2][1].ToString());
                        txtDiamLL3.Text = dt.Rows[2][2].ToString();
                        txtDiamUL3.Text = dt.Rows[2][3].ToString();
                        txtMinUnder3.Text = dt.Rows[2][4].ToString();
                        txtMaxOder3.Text = dt.Rows[2][5].ToString();
                        drplMeasType4.SelectedValue = docZMtype(dt.Rows[3][1].ToString());
                        txtDiamLL4.Text = dt.Rows[3][2].ToString();
                        txtDiamUL4.Text = dt.Rows[3][3].ToString();
                        txtMinUnder4.Text = dt.Rows[3][4].ToString();
                        txtMaxOder4.Text = dt.Rows[3][5].ToString();
                        drplMeasType5.SelectedValue = docZMtype(dt.Rows[4][1].ToString());
                        txtDiamLL5.Text = dt.Rows[4][2].ToString();
                        txtDiamUL5.Text = dt.Rows[4][3].ToString();
                        txtMinUnder5.Text = dt.Rows[4][4].ToString();
                        txtMaxOder5.Text = dt.Rows[4][5].ToString();
                        drplMeasType6.SelectedValue = docZMtype(dt.Rows[5][1].ToString());
                        txtDiamLL6.Text = dt.Rows[5][2].ToString();
                        txtDiamUL6.Text = dt.Rows[5][3].ToString();
                        txtMinUnder6.Text = dt.Rows[5][4].ToString();
                        txtMaxOder6.Text = dt.Rows[5][5].ToString();
                        drplMeasType7.SelectedValue = docZMtype(dt.Rows[6][1].ToString());
                        txtDiamLL7.Text = dt.Rows[6][2].ToString();
                        txtDiamUL7.Text = dt.Rows[6][3].ToString();
                        txtMinUnder7.Text = dt.Rows[6][4].ToString();
                        txtMaxOder7.Text = dt.Rows[6][5].ToString();
                        drplMeasType8.SelectedValue = docZMtype(dt.Rows[7][1].ToString());
                        txtDiamLL8.Text = dt.Rows[7][2].ToString();
                        txtDiamUL8.Text = dt.Rows[7][3].ToString();
                        txtMinUnder8.Text = dt.Rows[7][4].ToString();
                        txtMaxOder8.Text = dt.Rows[7][5].ToString();
                        drplMeasType9.SelectedValue = docZMtype(dt.Rows[8][1].ToString());
                        txtDiamLL9.Text = dt.Rows[8][2].ToString();
                        txtDiamUL9.Text = dt.Rows[8][3].ToString();
                        txtMinUnder9.Text = dt.Rows[8][4].ToString();
                        txtMaxOder9.Text = dt.Rows[8][5].ToString();
                        drplMeasType10.SelectedValue = docZMtype(dt.Rows[9][1].ToString());
                        txtDiamLL10.Text = dt.Rows[9][2].ToString();
                        txtDiamUL10.Text = dt.Rows[9][3].ToString();
                        txtMinUnder10.Text = dt.Rows[9][4].ToString();
                        txtMaxOder10.Text = dt.Rows[9][5].ToString();
                    }
                    else if (drplQtyMeasTypes.Text == "")
                    {
                        drplMeasType1.Visible = false;
                        txtDiamLL1.Visible = false;
                        txtDiamUL1.Visible = false;
                        txtMinUnder1.Visible = false;
                        txtMaxOder1.Visible = false;
                        drplMeasType2.Visible = false;
                        txtDiamLL2.Visible = false;
                        txtDiamUL2.Visible = false;
                        txtMinUnder2.Visible = false;
                        txtMaxOder2.Visible = false;
                        drplMeasType3.Visible = false;
                        txtDiamLL3.Visible = false;
                        txtDiamUL3.Visible = false;
                        txtMinUnder3.Visible = false;
                        txtMaxOder3.Visible = false;
                        drplMeasType4.Visible = false;
                        txtDiamLL4.Visible = false;
                        txtDiamUL4.Visible = false;
                        txtMinUnder4.Visible = false;
                        txtMaxOder4.Visible = false;
                        drplMeasType5.Visible = false;
                        txtDiamLL5.Visible = false;
                        txtDiamUL5.Visible = false;
                        txtMinUnder5.Visible = false;
                        txtMaxOder5.Visible = false;
                        drplMeasType6.Visible = false;
                        txtDiamLL6.Visible = false;
                        txtDiamUL6.Visible = false;
                        txtMinUnder6.Visible = false;
                        txtMaxOder6.Visible = false;
                        drplMeasType7.Visible = false;
                        txtDiamLL7.Visible = false;
                        txtDiamUL7.Visible = false;
                        txtMinUnder7.Visible = false;
                        txtMaxOder7.Visible = false;
                        drplMeasType8.Visible = false;
                        txtDiamLL8.Visible = false;
                        txtDiamUL8.Visible = false;
                        txtMinUnder8.Visible = false;
                        txtMaxOder8.Visible = false;
                        drplMeasType9.Visible = false;
                        txtDiamLL9.Visible = false;
                        txtDiamUL9.Visible = false;
                        txtMinUnder9.Visible = false;
                        txtMaxOder9.Visible = false;
                        drplMeasType10.Visible = false;
                        txtDiamLL10.Visible = false;
                        txtDiamUL10.Visible = false;
                        txtMinUnder10.Visible = false;
                        txtMaxOder10.Visible = false;
                        drplMeasType1.SelectedValue = "-1";
                        txtDiamLL1.Text = "";
                        txtDiamUL1.Text = "";
                        txtMinUnder1.Text = "";
                        txtMaxOder1.Text = "";
                        drplMeasType2.SelectedValue = "-1";
                        txtDiamLL2.Text = "";
                        txtDiamUL2.Text = "";
                        txtMinUnder2.Text = "";
                        txtMaxOder2.Text = "";
                        drplMeasType3.SelectedValue = "-1";
                        txtDiamLL3.Text = "";
                        txtDiamUL3.Text = "";
                        txtMinUnder3.Text = "";
                        txtMaxOder3.Text = "";
                        drplMeasType4.SelectedValue = "-1";
                        txtDiamLL4.Text = "";
                        txtDiamUL4.Text = "";
                        txtMinUnder4.Text = "";
                        txtMaxOder4.Text = "";
                        drplMeasType5.SelectedValue = "-1";
                        txtDiamLL5.Text = "";
                        txtDiamUL5.Text = "";
                        txtMinUnder5.Text = "";
                        txtMaxOder5.Text = "";
                        drplMeasType6.SelectedValue = "-1";
                        txtDiamLL6.Text = "";
                        txtDiamUL6.Text = "";
                        txtMinUnder6.Text = "";
                        txtMaxOder6.Text = "";
                        drplMeasType7.SelectedValue = "-1";
                        txtDiamLL7.Text = "";
                        txtDiamUL7.Text = "";
                        txtMinUnder7.Text = "";
                        txtMaxOder7.Text = "";
                        drplMeasType8.SelectedValue = "-1";
                        txtDiamLL8.Text = "";
                        txtDiamUL8.Text = "";
                        txtMinUnder8.Text = "";
                        txtMaxOder8.Text = "";
                        drplMeasType9.SelectedValue = "-1";
                        txtDiamLL9.Text = "";
                        txtDiamUL9.Text = "";
                        txtMinUnder9.Text = "";
                        txtMaxOder9.Text = "";
                        drplMeasType10.SelectedValue = "-1";
                        txtDiamLL10.Text = "";
                        txtDiamUL10.Text = "";
                        txtMinUnder10.Text = "";
                        txtMaxOder10.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    lbltest.Text = ex.ToString();
                }


            }
        }
        string docZMtype(string id)
        {
            string Name = BienChung.sqlServer.selectdatatheoid("ZMmeasType", "Name", "ID", id);
            if (Name == null)
            {
                return "-1";
            }
            else
            {
                return id;
            }

        }
        bool KiemTraLap()
        {
                string[] mang = new string[10];
                mang[0] = drplMeasType1.SelectedItem.Value;
                mang[1] = drplMeasType2.SelectedItem.Value;
                mang[2] = drplMeasType3.SelectedItem.Value;
                mang[3] = drplMeasType4.SelectedItem.Value;
                mang[4] = drplMeasType5.SelectedItem.Value;
                mang[5] = drplMeasType6.SelectedItem.Value;
                mang[6] = drplMeasType7.SelectedItem.Value;
                mang[7] = drplMeasType8.SelectedItem.Value;
                mang[8] = drplMeasType9.SelectedItem.Value;
                mang[9] = drplMeasType10.SelectedItem.Value;
                for (int i = 0; i < Convert.ToInt32(drplQtyMeasTypes.SelectedItem.Text); i++)
                {
                    for (int j = i + 1; j < Convert.ToInt32(drplQtyMeasTypes.SelectedItem.Text); j++)
                    {
                        if (mang[i] != "-1")
                        {
                            if (mang[i] == mang[j])
                            {
                                return false;
                            }
                        }
                    }
                }

                return true;
        }

        protected void btnApplyEditZmike_Click(object sender, EventArgs e)
        {
            if (drplQtyMeasTypes.SelectedItem.Text != "")
            {
                if (KiemTraLap() == true)
                {
                    if (drplQtyMeasTypes.SelectedItem.Text == "3")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1")
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != ""
                                && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != ""
                                && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != ""
                                && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != ""
                                )
                            {
                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                    && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {

                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                            //if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                            //{
                                            //    BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                            //    BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                            //    BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                            //}
                                            //------------------------------------------------------------

                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";

                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";

                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";

                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";

                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }
                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }

                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }

                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }

                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }

                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "4")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1")
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                                && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                                && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                                && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                                )
                            {
                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                    && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                             "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                             "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                             "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);

                                            //------------------------------------------------------------

                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";

                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";

                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";

                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";

                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }
                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }

                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }

                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }

                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }

                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "5")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                            && drplMeasType5.SelectedItem.Value != "-1"

                            )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                                && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                                && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                                && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                                && txtDiamLL5.Text.Trim() != ""
                                && txtDiamUL5.Text.Trim() != ""
                                && txtMaxOder5.Text.Trim() != ""
                                && txtMinUnder5.Text.Trim() != ""

                                )
                            {
                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                    && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                    && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                    && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                    && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')") == "GOOD")

                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                            {
                                                BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                                BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                                BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                                BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                                BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")");
                                            }
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                            //------------------------------------------------------------

                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";


                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";


                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";



                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";


                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }

                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }
                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }


                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }


                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }


                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }


                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }

                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "6")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                      && drplMeasType5.SelectedItem.Value != "-1" && drplMeasType6.SelectedItem.Value != "-1"

                      )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                              && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                              && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                              && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                              && txtDiamLL5.Text.Trim() != "" && txtDiamLL6.Text.Trim() != ""
                              && txtDiamUL5.Text.Trim() != "" && txtDiamUL6.Text.Trim() != ""
                              && txtMaxOder5.Text.Trim() != "" && txtMaxOder6.Text.Trim() != ""
                              && txtMinUnder5.Text.Trim() != "" && txtMinUnder6.Text.Trim() != ""

                              )
                            {

                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL6.Text) >= 7.65 && Convert.ToDouble(txtDiamUL6.Text) <= 50.8 && Convert.ToDouble(txtDiamLL6.Text) >= 7.62 && Convert.ToDouble(txtDiamLL6.Text) <= 50.77
                                && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder6.Text) >= 0.003 && Convert.ToDouble(txtMinUnder6.Text) <= 0.508 && Convert.ToDouble(txtMaxOder6.Text) >= 0.003 && Convert.ToDouble(txtMaxOder6.Text) <= 0.508
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType6.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder6.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";





                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";





                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";




                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";





                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                    {
                                        txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                    }


                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }

                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }
                                if (txtDiamUL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                }
                                else { txtDiamUL6.Text = "7.65"; }





                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }
                                if (txtDiamLL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                }
                                else { txtDiamLL6.Text = "7.62"; }





                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }
                                if (txtMinUnder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                }
                                else { txtMinUnder6.Text = "0.003"; }





                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }
                                if (txtMaxOder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                }
                                else { txtMaxOder6.Text = "0.003"; }





                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                {
                                    txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                }

                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "7")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                        && drplMeasType5.SelectedItem.Value != "-1" && drplMeasType6.SelectedItem.Value != "-1" && drplMeasType7.SelectedItem.Value != "-1"

                        )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                              && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                              && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                              && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                              && txtDiamLL5.Text.Trim() != "" && txtDiamLL6.Text.Trim() != "" && txtDiamLL7.Text.Trim() != ""
                              && txtDiamUL5.Text.Trim() != "" && txtDiamUL6.Text.Trim() != "" && txtDiamUL7.Text.Trim() != ""
                              && txtMaxOder5.Text.Trim() != "" && txtMaxOder6.Text.Trim() != "" && txtMaxOder7.Text.Trim() != ""
                              && txtMinUnder5.Text.Trim() != "" && txtMinUnder6.Text.Trim() != "" && txtMinUnder7.Text.Trim() != ""

                              )
                            {

                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL6.Text) >= 7.65 && Convert.ToDouble(txtDiamUL6.Text) <= 50.8 && Convert.ToDouble(txtDiamLL6.Text) >= 7.62 && Convert.ToDouble(txtDiamLL6.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL7.Text) >= 7.65 && Convert.ToDouble(txtDiamUL7.Text) <= 50.8 && Convert.ToDouble(txtDiamLL7.Text) >= 7.62 && Convert.ToDouble(txtDiamLL7.Text) <= 50.77
                                && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder6.Text) >= 0.003 && Convert.ToDouble(txtMinUnder6.Text) <= 0.508 && Convert.ToDouble(txtMaxOder6.Text) >= 0.003 && Convert.ToDouble(txtMaxOder6.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder7.Text) >= 0.003 && Convert.ToDouble(txtMinUnder7.Text) <= 0.508 && Convert.ToDouble(txtMaxOder7.Text) >= 0.003 && Convert.ToDouble(txtMaxOder7.Text) <= 0.508
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType6.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder6.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType7.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder7.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";




                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";




                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";




                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";




                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                    {
                                        txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                    {
                                        txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                    }


                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }

                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }
                                if (txtDiamUL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                }
                                else { txtDiamUL6.Text = "7.65"; }
                                if (txtDiamUL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                }
                                else { txtDiamUL7.Text = "7.65"; }




                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }
                                if (txtDiamLL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                }
                                else { txtDiamLL6.Text = "7.62"; }
                                if (txtDiamLL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                }
                                else { txtDiamLL7.Text = "7.62"; }




                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }
                                if (txtMinUnder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                }
                                else { txtMinUnder6.Text = "0.003"; }
                                if (txtMinUnder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                }
                                else { txtMinUnder7.Text = "0.003"; }




                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }
                                if (txtMaxOder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                }
                                else { txtMaxOder6.Text = "0.003"; }
                                if (txtMaxOder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                }
                                else { txtMaxOder7.Text = "0.003"; }




                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                {
                                    txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                {
                                    txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                }
                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "8")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                         && drplMeasType5.SelectedItem.Value != "-1" && drplMeasType6.SelectedItem.Value != "-1" && drplMeasType7.SelectedItem.Value != "-1" && drplMeasType8.SelectedItem.Value != "-1"

                         )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                              && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                              && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                              && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                              && txtDiamLL5.Text.Trim() != "" && txtDiamLL6.Text.Trim() != "" && txtDiamLL7.Text.Trim() != "" && txtDiamLL8.Text.Trim() != ""
                              && txtDiamUL5.Text.Trim() != "" && txtDiamUL6.Text.Trim() != "" && txtDiamUL7.Text.Trim() != "" && txtDiamUL8.Text.Trim() != ""
                              && txtMaxOder5.Text.Trim() != "" && txtMaxOder6.Text.Trim() != "" && txtMaxOder7.Text.Trim() != "" && txtMaxOder8.Text.Trim() != ""
                              && txtMinUnder5.Text.Trim() != "" && txtMinUnder6.Text.Trim() != "" && txtMinUnder7.Text.Trim() != "" && txtMinUnder8.Text.Trim() != ""

                              )
                            {

                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL6.Text) >= 7.65 && Convert.ToDouble(txtDiamUL6.Text) <= 50.8 && Convert.ToDouble(txtDiamLL6.Text) >= 7.62 && Convert.ToDouble(txtDiamLL6.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL7.Text) >= 7.65 && Convert.ToDouble(txtDiamUL7.Text) <= 50.8 && Convert.ToDouble(txtDiamLL7.Text) >= 7.62 && Convert.ToDouble(txtDiamLL7.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL8.Text) >= 7.65 && Convert.ToDouble(txtDiamUL8.Text) <= 50.8 && Convert.ToDouble(txtDiamLL8.Text) >= 7.62 && Convert.ToDouble(txtDiamLL8.Text) <= 50.77
                                && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder6.Text) >= 0.003 && Convert.ToDouble(txtMinUnder6.Text) <= 0.508 && Convert.ToDouble(txtMaxOder6.Text) >= 0.003 && Convert.ToDouble(txtMaxOder6.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder7.Text) >= 0.003 && Convert.ToDouble(txtMinUnder7.Text) <= 0.508 && Convert.ToDouble(txtMaxOder7.Text) >= 0.003 && Convert.ToDouble(txtMaxOder7.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder8.Text) >= 0.003 && Convert.ToDouble(txtMinUnder8.Text) <= 0.508 && Convert.ToDouble(txtMaxOder8.Text) >= 0.003 && Convert.ToDouble(txtMaxOder8.Text) <= 0.508
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType6.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder6.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType7.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder7.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType8.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder8.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";



                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";



                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";



                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";



                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                    {
                                        txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                    {
                                        txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                    {
                                        txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                    }

                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }

                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }
                                if (txtDiamUL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                }
                                else { txtDiamUL6.Text = "7.65"; }
                                if (txtDiamUL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                }
                                else { txtDiamUL7.Text = "7.65"; }
                                if (txtDiamUL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";
                                }
                                else { txtDiamUL8.Text = "7.65"; }



                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }
                                if (txtDiamLL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                }
                                else { txtDiamLL6.Text = "7.62"; }
                                if (txtDiamLL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                }
                                else { txtDiamLL7.Text = "7.62"; }
                                if (txtDiamLL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";
                                }
                                else { txtDiamLL8.Text = "7.62"; }



                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }
                                if (txtMinUnder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                }
                                else { txtMinUnder6.Text = "0.003"; }
                                if (txtMinUnder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                }
                                else { txtMinUnder7.Text = "0.003"; }
                                if (txtMinUnder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";
                                }
                                else { txtMinUnder8.Text = "0.003"; }



                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }
                                if (txtMaxOder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                }
                                else { txtMaxOder6.Text = "0.003"; }
                                if (txtMaxOder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                }
                                else { txtMaxOder7.Text = "0.003"; }
                                if (txtMaxOder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";
                                }
                                else { txtMaxOder8.Text = "0.003"; }



                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                {
                                    txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                {
                                    txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                {
                                    txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                }


                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "9")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                           && drplMeasType5.SelectedItem.Value != "-1" && drplMeasType6.SelectedItem.Value != "-1" && drplMeasType7.SelectedItem.Value != "-1" && drplMeasType8.SelectedItem.Value != "-1"
                           && drplMeasType9.SelectedItem.Value != "-1"
                           )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                              && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                              && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                              && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                              && txtDiamLL5.Text.Trim() != "" && txtDiamLL6.Text.Trim() != "" && txtDiamLL7.Text.Trim() != "" && txtDiamLL8.Text.Trim() != ""
                              && txtDiamUL5.Text.Trim() != "" && txtDiamUL6.Text.Trim() != "" && txtDiamUL7.Text.Trim() != "" && txtDiamUL8.Text.Trim() != ""
                              && txtMaxOder5.Text.Trim() != "" && txtMaxOder6.Text.Trim() != "" && txtMaxOder7.Text.Trim() != "" && txtMaxOder8.Text.Trim() != ""
                              && txtMinUnder5.Text.Trim() != "" && txtMinUnder6.Text.Trim() != "" && txtMinUnder7.Text.Trim() != "" && txtMinUnder8.Text.Trim() != ""
                              && txtDiamLL9.Text.Trim() != ""
                              && txtDiamUL9.Text.Trim() != ""
                              && txtMaxOder9.Text.Trim() != ""
                              && txtMinUnder9.Text.Trim() != ""
                              )
                            {

                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL6.Text) >= 7.65 && Convert.ToDouble(txtDiamUL6.Text) <= 50.8 && Convert.ToDouble(txtDiamLL6.Text) >= 7.62 && Convert.ToDouble(txtDiamLL6.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL7.Text) >= 7.65 && Convert.ToDouble(txtDiamUL7.Text) <= 50.8 && Convert.ToDouble(txtDiamLL7.Text) >= 7.62 && Convert.ToDouble(txtDiamLL7.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL8.Text) >= 7.65 && Convert.ToDouble(txtDiamUL8.Text) <= 50.8 && Convert.ToDouble(txtDiamLL8.Text) >= 7.62 && Convert.ToDouble(txtDiamLL8.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL9.Text) >= 7.65 && Convert.ToDouble(txtDiamUL9.Text) <= 50.8 && Convert.ToDouble(txtDiamLL9.Text) >= 7.62 && Convert.ToDouble(txtDiamLL9.Text) <= 50.77
                                && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder6.Text) >= 0.003 && Convert.ToDouble(txtMinUnder6.Text) <= 0.508 && Convert.ToDouble(txtMaxOder6.Text) >= 0.003 && Convert.ToDouble(txtMaxOder6.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder7.Text) >= 0.003 && Convert.ToDouble(txtMinUnder7.Text) <= 0.508 && Convert.ToDouble(txtMaxOder7.Text) >= 0.003 && Convert.ToDouble(txtMaxOder7.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder8.Text) >= 0.003 && Convert.ToDouble(txtMinUnder8.Text) <= 0.508 && Convert.ToDouble(txtMaxOder8.Text) >= 0.003 && Convert.ToDouble(txtMaxOder8.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder9.Text) >= 0.003 && Convert.ToDouble(txtMinUnder9.Text) <= 0.508 && Convert.ToDouble(txtMaxOder9.Text) >= 0.003 && Convert.ToDouble(txtMaxOder9.Text) <= 0.508
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType6.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder6.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType7.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder7.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType8.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder8.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType9.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder9.Text.Trim()).ToString("0.000") + "')") == "GOOD")
                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL9.Text) < 7.65)
                                        txtDiamUL9.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL9.Text) > 50.8)
                                        txtDiamUL9.Text = "50.8";


                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL9.Text) < 7.62)
                                        txtDiamLL9.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL9.Text) > 50.77)
                                        txtDiamLL9.Text = "50.77";


                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder9.Text) < 0.003)
                                        txtMinUnder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder9.Text) > 0.508)
                                        txtMinUnder9.Text = "0.508";



                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder9.Text) < 0.003)
                                        txtMaxOder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder9.Text) > 0.508)
                                        txtMaxOder9.Text = "0.508";


                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                    {
                                        txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                    {
                                        txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                    {
                                        txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) < 0.03)
                                    {
                                        txtDiamLL9.Text = (Convert.ToDouble(txtDiamUL9.Text) - 0.03).ToString();
                                    }

                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }

                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }
                                if (txtDiamUL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                }
                                else { txtDiamUL6.Text = "7.65"; }
                                if (txtDiamUL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                }
                                else { txtDiamUL7.Text = "7.65"; }
                                if (txtDiamUL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";
                                }
                                else { txtDiamUL8.Text = "7.65"; }
                                if (txtDiamUL9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL9.Text) < 7.65)
                                        txtDiamUL9.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL9.Text) > 50.8)
                                        txtDiamUL9.Text = "50.8";
                                }
                                else { txtDiamUL9.Text = "7.65"; }


                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }
                                if (txtDiamLL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                }
                                else { txtDiamLL6.Text = "7.62"; }
                                if (txtDiamLL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                }
                                else { txtDiamLL7.Text = "7.62"; }
                                if (txtDiamLL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";
                                }
                                else { txtDiamLL8.Text = "7.62"; }
                                if (txtDiamLL9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL9.Text) < 7.62)
                                        txtDiamLL9.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL9.Text) > 50.77)
                                        txtDiamLL9.Text = "50.77";
                                }
                                else { txtDiamLL9.Text = "7.62"; }


                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }
                                if (txtMinUnder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                }
                                else { txtMinUnder6.Text = "0.003"; }
                                if (txtMinUnder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                }
                                else { txtMinUnder7.Text = "0.003"; }
                                if (txtMinUnder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";
                                }
                                else { txtMinUnder8.Text = "0.003"; }
                                if (txtMinUnder9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder9.Text) < 0.003)
                                        txtMinUnder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder9.Text) > 0.508)
                                        txtMinUnder9.Text = "0.508";
                                }
                                else { txtMinUnder9.Text = "0.003"; }


                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }
                                if (txtMaxOder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                }
                                else { txtMaxOder6.Text = "0.003"; }
                                if (txtMaxOder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                }
                                else { txtMaxOder7.Text = "0.003"; }
                                if (txtMaxOder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";
                                }
                                else { txtMaxOder8.Text = "0.003"; }
                                if (txtMaxOder9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder9.Text) < 0.003)
                                        txtMaxOder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder9.Text) > 0.508)
                                        txtMaxOder9.Text = "0.508";
                                }
                                else { txtMaxOder9.Text = "0.003"; }


                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                {
                                    txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                {
                                    txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                {
                                    txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) < 0.03)
                                {
                                    txtDiamLL9.Text = (Convert.ToDouble(txtDiamUL9.Text) - 0.03).ToString();
                                }

                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                    else if (drplQtyMeasTypes.SelectedItem.Text == "10")
                    {
                        if (drplMeasType1.SelectedItem.Value != "-1" && drplMeasType2.SelectedItem.Value != "-1" && drplMeasType3.SelectedItem.Value != "-1" && drplMeasType4.SelectedItem.Value != "-1"
                           && drplMeasType5.SelectedItem.Value != "-1" && drplMeasType6.SelectedItem.Value != "-1" && drplMeasType7.SelectedItem.Value != "-1" && drplMeasType8.SelectedItem.Value != "-1"
                           && drplMeasType9.SelectedItem.Value != "-1" && drplMeasType10.SelectedItem.Value != "-1"
                           )
                        {
                            if (txtDiamLL1.Text.Trim() != "" && txtDiamLL2.Text.Trim() != "" && txtDiamLL3.Text.Trim() != "" && txtDiamLL4.Text.Trim() != ""
                              && txtDiamUL1.Text.Trim() != "" && txtDiamUL2.Text.Trim() != "" && txtDiamUL3.Text.Trim() != "" && txtDiamUL4.Text.Trim() != ""
                              && txtMaxOder1.Text.Trim() != "" && txtMaxOder2.Text.Trim() != "" && txtMaxOder3.Text.Trim() != "" && txtMaxOder4.Text.Trim() != ""
                              && txtMinUnder1.Text.Trim() != "" && txtMinUnder2.Text.Trim() != "" && txtMinUnder3.Text.Trim() != "" && txtMinUnder4.Text.Trim() != ""
                              && txtDiamLL5.Text.Trim() != "" && txtDiamLL6.Text.Trim() != "" && txtDiamLL7.Text.Trim() != "" && txtDiamLL8.Text.Trim() != ""
                              && txtDiamUL5.Text.Trim() != "" && txtDiamUL6.Text.Trim() != "" && txtDiamUL7.Text.Trim() != "" && txtDiamUL8.Text.Trim() != ""
                              && txtMaxOder5.Text.Trim() != "" && txtMaxOder6.Text.Trim() != "" && txtMaxOder7.Text.Trim() != "" && txtMaxOder8.Text.Trim() != ""
                              && txtMinUnder5.Text.Trim() != "" && txtMinUnder6.Text.Trim() != "" && txtMinUnder7.Text.Trim() != "" && txtMinUnder8.Text.Trim() != ""
                              && txtDiamLL9.Text.Trim() != "" && txtDiamLL10.Text.Trim() != ""
                              && txtDiamUL9.Text.Trim() != "" && txtDiamUL10.Text.Trim() != ""
                              && txtMaxOder9.Text.Trim() != "" && txtMaxOder10.Text.Trim() != ""
                              && txtMinUnder9.Text.Trim() != "" && txtMinUnder10.Text.Trim() != ""
                              )
                            {

                                if (Convert.ToDouble(txtDiamUL1.Text) >= 7.65 && Convert.ToDouble(txtDiamUL1.Text) <= 50.8 && Convert.ToDouble(txtDiamLL1.Text) >= 7.62 && Convert.ToDouble(txtDiamLL1.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL2.Text) >= 7.65 && Convert.ToDouble(txtDiamUL2.Text) <= 50.8 && Convert.ToDouble(txtDiamLL2.Text) >= 7.62 && Convert.ToDouble(txtDiamLL2.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL3.Text) >= 7.65 && Convert.ToDouble(txtDiamUL3.Text) <= 50.8 && Convert.ToDouble(txtDiamLL3.Text) >= 7.62 && Convert.ToDouble(txtDiamLL3.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL4.Text) >= 7.65 && Convert.ToDouble(txtDiamUL4.Text) <= 50.8 && Convert.ToDouble(txtDiamLL4.Text) >= 7.62 && Convert.ToDouble(txtDiamLL4.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL5.Text) >= 7.65 && Convert.ToDouble(txtDiamUL5.Text) <= 50.8 && Convert.ToDouble(txtDiamLL5.Text) >= 7.62 && Convert.ToDouble(txtDiamLL5.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL6.Text) >= 7.65 && Convert.ToDouble(txtDiamUL6.Text) <= 50.8 && Convert.ToDouble(txtDiamLL6.Text) >= 7.62 && Convert.ToDouble(txtDiamLL6.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL7.Text) >= 7.65 && Convert.ToDouble(txtDiamUL7.Text) <= 50.8 && Convert.ToDouble(txtDiamLL7.Text) >= 7.62 && Convert.ToDouble(txtDiamLL7.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL8.Text) >= 7.65 && Convert.ToDouble(txtDiamUL8.Text) <= 50.8 && Convert.ToDouble(txtDiamLL8.Text) >= 7.62 && Convert.ToDouble(txtDiamLL8.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL9.Text) >= 7.65 && Convert.ToDouble(txtDiamUL9.Text) <= 50.8 && Convert.ToDouble(txtDiamLL9.Text) >= 7.62 && Convert.ToDouble(txtDiamLL9.Text) <= 50.77
                                && Convert.ToDouble(txtDiamUL10.Text) >= 7.65 && Convert.ToDouble(txtDiamUL10.Text) <= 50.8 && Convert.ToDouble(txtDiamLL10.Text) >= 7.62 && Convert.ToDouble(txtDiamLL10.Text) <= 50.77
                                && Convert.ToDouble(txtMinUnder1.Text) >= 0.003 && Convert.ToDouble(txtMinUnder1.Text) <= 0.508 && Convert.ToDouble(txtMaxOder1.Text) >= 0.003 && Convert.ToDouble(txtMaxOder1.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder2.Text) >= 0.003 && Convert.ToDouble(txtMinUnder2.Text) <= 0.508 && Convert.ToDouble(txtMaxOder2.Text) >= 0.003 && Convert.ToDouble(txtMaxOder2.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder3.Text) >= 0.003 && Convert.ToDouble(txtMinUnder3.Text) <= 0.508 && Convert.ToDouble(txtMaxOder3.Text) >= 0.003 && Convert.ToDouble(txtMaxOder3.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder4.Text) >= 0.003 && Convert.ToDouble(txtMinUnder4.Text) <= 0.508 && Convert.ToDouble(txtMaxOder4.Text) >= 0.003 && Convert.ToDouble(txtMaxOder4.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder5.Text) >= 0.003 && Convert.ToDouble(txtMinUnder5.Text) <= 0.508 && Convert.ToDouble(txtMaxOder5.Text) >= 0.003 && Convert.ToDouble(txtMaxOder5.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder6.Text) >= 0.003 && Convert.ToDouble(txtMinUnder6.Text) <= 0.508 && Convert.ToDouble(txtMaxOder6.Text) >= 0.003 && Convert.ToDouble(txtMaxOder6.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder7.Text) >= 0.003 && Convert.ToDouble(txtMinUnder7.Text) <= 0.508 && Convert.ToDouble(txtMaxOder7.Text) >= 0.003 && Convert.ToDouble(txtMaxOder7.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder8.Text) >= 0.003 && Convert.ToDouble(txtMinUnder8.Text) <= 0.508 && Convert.ToDouble(txtMaxOder8.Text) >= 0.003 && Convert.ToDouble(txtMaxOder8.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder9.Text) >= 0.003 && Convert.ToDouble(txtMinUnder9.Text) <= 0.508 && Convert.ToDouble(txtMaxOder9.Text) >= 0.003 && Convert.ToDouble(txtMaxOder9.Text) <= 0.508
                                && Convert.ToDouble(txtMinUnder10.Text) >= 0.003 && Convert.ToDouble(txtMinUnder10.Text) <= 0.508 && Convert.ToDouble(txtMaxOder10.Text) >= 0.003 && Convert.ToDouble(txtMaxOder10.Text) <= 0.508
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) >= 0.029999
                                && Convert.ToDouble(Convert.ToDouble(txtDiamUL10.Text) - Convert.ToDouble(txtDiamLL10.Text)) >= 0.029999)
                                {
                                    // XOA CAC DONG CU
                                    if (BienChung.sqlServer.deletedata("PartZM", "where PartID='" + BienChung.idPart + "'") == "GOOD")
                                    {
                                        if (BienChung.sqlServer.themData("PartZM", "values('" + BienChung.idPart + "','" + drplMeasType1.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder1.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder1.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType2.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder2.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder2.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType3.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder3.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder3.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType4.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder4.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder4.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType5.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder5.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder5.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType6.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder6.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder6.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType7.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder7.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder7.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType8.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder8.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder8.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType9.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder9.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder9.Text.Trim()).ToString("0.000") + "')," +
                                            "('" + BienChung.idPart + "','" + drplMeasType10.SelectedItem.Value + "','" + Convert.ToDouble(txtDiamLL10.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtDiamUL10.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMinUnder10.Text.Trim()).ToString("0.000") + "','" + Convert.ToDouble(txtMaxOder10.Text.Trim()).ToString("0.000") + "')") == "GOOD")


                                        {
                                            // accesss--------------------------------------------------
                                            string idPart = BienChung.AccessServer.selectdatatheoid("Part", "ID", "Number", BienChung.textPart);
                                            string idZM1 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType1.SelectedItem.Text);
                                            string idZM2 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType2.SelectedItem.Text);
                                            string idZM3 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType3.SelectedItem.Text);
                                            string idZM4 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType4.SelectedItem.Text);
                                            string idZM5 = BienChung.AccessServer.selectdatatheoid("ZMmeasType", "ID", "Name", drplMeasType5.SelectedItem.Text);
                                            if (idPart != null && idZM1 != null && idZM2 != null && idZM3 != null && idZM4 != null && idZM5 != null)
                                            {
                                                if (BienChung.AccessServer.deletedata("PartZM", "where PartID=" + idPart + "") == "GOOD")
                                                {
                                                    if (BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM1 + "," + (Convert.ToDouble(txtDiamLL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder1.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder1.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM2 + "," + (Convert.ToDouble(txtDiamLL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder2.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder2.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                         BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM3 + "," + (Convert.ToDouble(txtDiamLL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder3.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder3.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                           BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM4 + "," + (Convert.ToDouble(txtDiamLL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder4.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder4.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD" &&
                                                            BienChung.AccessServer.themData("PartZM", "([PartID],[ZMID],[Diam_LL],[Diam_UL],[Min_Under],[Max_Over]) values(" + idPart + "," + idZM5 + "," + (Convert.ToDouble(txtDiamLL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtDiamUL5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMinUnder5.Text.Trim()) / 25.4).ToString("0.0000") + "," + (Convert.ToDouble(txtMaxOder5.Text.Trim()) / 25.4).ToString("0.0000") + ")") == "GOOD")
                                                    {
                                                        string script = "alert(\"Edit Z-Mike successful!\");";
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
                                                string script = "alert(\"Update Accsess Failed!\");";
                                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string script = "alert(\"Edit Z-Mike Failed!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    // GHI CAC DONG MOI
                                }
                                else
                                {
                                    #region SUA LẠI TEBOX
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL9.Text) < 7.65)
                                        txtDiamUL9.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL9.Text) > 50.8)
                                        txtDiamUL9.Text = "50.8";
                                    if (Convert.ToDouble(txtDiamUL10.Text) < 7.65)
                                        txtDiamUL10.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL10.Text) > 50.8)
                                        txtDiamUL10.Text = "50.8";

                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL9.Text) < 7.62)
                                        txtDiamLL9.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL9.Text) > 50.77)
                                        txtDiamLL9.Text = "50.77";
                                    if (Convert.ToDouble(txtDiamLL10.Text) < 7.62)
                                        txtDiamLL10.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL10.Text) > 50.77)
                                        txtDiamLL10.Text = "50.77";

                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder9.Text) < 0.003)
                                        txtMinUnder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder9.Text) > 0.508)
                                        txtMinUnder9.Text = "0.508";
                                    if (Convert.ToDouble(txtMinUnder10.Text) < 0.003)
                                        txtMinUnder10.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder10.Text) > 0.508)
                                        txtMinUnder10.Text = "0.508";


                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder9.Text) < 0.003)
                                        txtMaxOder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder9.Text) > 0.508)
                                        txtMaxOder9.Text = "0.508";
                                    if (Convert.ToDouble(txtMaxOder10.Text) < 0.003)
                                        txtMaxOder10.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder10.Text) > 0.508)
                                        txtMaxOder10.Text = "0.508";

                                    if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                    {
                                        txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                    {
                                        txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                    {
                                        txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                    {
                                        txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                    {
                                        txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                    {
                                        txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                    {
                                        txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                    {
                                        txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) < 0.03)
                                    {
                                        txtDiamLL9.Text = (Convert.ToDouble(txtDiamUL9.Text) - 0.03).ToString();
                                    }
                                    if ((Convert.ToDouble(txtDiamUL10.Text) - Convert.ToDouble(txtDiamLL10.Text)) < 0.03)
                                    {
                                        txtDiamLL10.Text = (Convert.ToDouble(txtDiamUL10.Text) - 0.03).ToString();
                                    }
                                    #endregion
                                    string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                                }

                            }
                            else
                            {
                                #region SUA LẠI TEBOX
                                if (txtDiamUL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL1.Text) < 7.65)
                                        txtDiamUL1.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL1.Text) > 50.8)
                                        txtDiamUL1.Text = "50.8";
                                }
                                else { txtDiamUL1.Text = "7.65"; }
                                if (txtDiamUL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL2.Text) < 7.65)
                                        txtDiamUL2.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL2.Text) > 50.8)
                                        txtDiamUL2.Text = "50.8";

                                }
                                else { txtDiamUL2.Text = "7.65"; }
                                if (txtDiamUL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL3.Text) < 7.65)
                                        txtDiamUL3.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL3.Text) > 50.8)
                                        txtDiamUL3.Text = "50.8";
                                }
                                else { txtDiamUL3.Text = "7.65"; }
                                if (txtDiamUL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL4.Text) < 7.65)
                                        txtDiamUL4.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL4.Text) > 50.8)
                                        txtDiamUL4.Text = "50.8";
                                }
                                else { txtDiamUL4.Text = "7.65"; }
                                if (txtDiamUL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL5.Text) < 7.65)
                                        txtDiamUL5.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL5.Text) > 50.8)
                                        txtDiamUL5.Text = "50.8";
                                }
                                else { txtDiamUL5.Text = "7.65"; }
                                if (txtDiamUL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL6.Text) < 7.65)
                                        txtDiamUL6.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL6.Text) > 50.8)
                                        txtDiamUL6.Text = "50.8";
                                }
                                else { txtDiamUL6.Text = "7.65"; }
                                if (txtDiamUL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL7.Text) < 7.65)
                                        txtDiamUL7.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL7.Text) > 50.8)
                                        txtDiamUL7.Text = "50.8";
                                }
                                else { txtDiamUL7.Text = "7.65"; }
                                if (txtDiamUL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL8.Text) < 7.65)
                                        txtDiamUL8.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL8.Text) > 50.8)
                                        txtDiamUL8.Text = "50.8";
                                }
                                else { txtDiamUL8.Text = "7.65"; }
                                if (txtDiamUL9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL9.Text) < 7.65)
                                        txtDiamUL9.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL9.Text) > 50.8)
                                        txtDiamUL9.Text = "50.8";
                                }
                                else { txtDiamUL9.Text = "7.65"; }
                                if (txtDiamUL10.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamUL10.Text) < 7.65)
                                        txtDiamUL10.Text = "7.65";
                                    else if (Convert.ToDouble(txtDiamUL10.Text) > 50.8)
                                        txtDiamUL10.Text = "50.8";
                                }
                                else { txtDiamUL10.Text = "7.65"; }

                                if (txtDiamLL1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL1.Text) < 7.62)
                                        txtDiamLL1.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL1.Text) > 50.77)
                                        txtDiamLL1.Text = "50.77";
                                }
                                else { txtDiamLL1.Text = "7.62"; }
                                if (txtDiamLL2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL2.Text) < 7.62)
                                        txtDiamLL2.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL2.Text) > 50.77)
                                        txtDiamLL2.Text = "50.77";

                                }
                                else { txtDiamLL2.Text = "7.62"; }
                                if (txtDiamLL3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL3.Text) < 7.62)
                                        txtDiamLL3.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL3.Text) > 50.77)
                                        txtDiamLL3.Text = "50.77";
                                }
                                else { txtDiamLL3.Text = "7.62"; }
                                if (txtDiamLL4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL4.Text) < 7.62)
                                        txtDiamLL4.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL4.Text) > 50.77)
                                        txtDiamLL4.Text = "50.77";
                                }
                                else { txtDiamLL4.Text = "7.62"; }
                                if (txtDiamLL5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL5.Text) < 7.62)
                                        txtDiamLL5.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL5.Text) > 50.77)
                                        txtDiamLL5.Text = "50.77";
                                }
                                else { txtDiamLL5.Text = "7.62"; }
                                if (txtDiamLL6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL6.Text) < 7.62)
                                        txtDiamLL6.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL6.Text) > 50.77)
                                        txtDiamLL6.Text = "50.77";
                                }
                                else { txtDiamLL6.Text = "7.62"; }
                                if (txtDiamLL7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL7.Text) < 7.62)
                                        txtDiamLL7.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL7.Text) > 50.77)
                                        txtDiamLL7.Text = "50.77";
                                }
                                else { txtDiamLL7.Text = "7.62"; }
                                if (txtDiamLL8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL8.Text) < 7.62)
                                        txtDiamLL8.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL8.Text) > 50.77)
                                        txtDiamLL8.Text = "50.77";
                                }
                                else { txtDiamLL8.Text = "7.62"; }
                                if (txtDiamLL9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL9.Text) < 7.62)
                                        txtDiamLL9.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL9.Text) > 50.77)
                                        txtDiamLL9.Text = "50.77";
                                }
                                else { txtDiamLL9.Text = "7.62"; }
                                if (txtDiamLL10.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtDiamLL10.Text) < 7.62)
                                        txtDiamLL10.Text = "7.62";
                                    else if (Convert.ToDouble(txtDiamLL10.Text) > 50.77)
                                        txtDiamLL10.Text = "50.77";
                                }
                                else { txtDiamLL10.Text = "7.62"; }

                                if (txtMinUnder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder1.Text) < 0.003)
                                        txtMinUnder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder1.Text) > 0.508)
                                        txtMinUnder1.Text = "0.508";
                                }
                                else { txtMinUnder1.Text = "0.003"; }
                                if (txtMinUnder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder2.Text) < 0.003)
                                        txtMinUnder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder2.Text) > 0.508)
                                        txtMinUnder2.Text = "0.508";

                                }
                                else { txtMinUnder2.Text = "0.003"; }
                                if (txtMinUnder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder3.Text) < 0.003)
                                        txtMinUnder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder3.Text) > 0.508)
                                        txtMinUnder3.Text = "0.508";
                                }
                                else { txtMinUnder3.Text = "0.003"; }
                                if (txtMinUnder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder4.Text) < 0.003)
                                        txtMinUnder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder4.Text) > 0.508)
                                        txtMinUnder4.Text = "0.508";
                                }
                                else { txtMinUnder4.Text = "0.003"; }
                                if (txtMinUnder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder5.Text) < 0.003)
                                        txtMinUnder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder5.Text) > 0.508)
                                        txtMinUnder5.Text = "0.508";
                                }
                                else { txtMinUnder5.Text = "0.003"; }
                                if (txtMinUnder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder6.Text) < 0.003)
                                        txtMinUnder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder6.Text) > 0.508)
                                        txtMinUnder6.Text = "0.508";
                                }
                                else { txtMinUnder6.Text = "0.003"; }
                                if (txtMinUnder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder7.Text) < 0.003)
                                        txtMinUnder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder7.Text) > 0.508)
                                        txtMinUnder7.Text = "0.508";
                                }
                                else { txtMinUnder7.Text = "0.003"; }
                                if (txtMinUnder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder8.Text) < 0.003)
                                        txtMinUnder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder8.Text) > 0.508)
                                        txtMinUnder8.Text = "0.508";
                                }
                                else { txtMinUnder8.Text = "0.003"; }
                                if (txtMinUnder9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder9.Text) < 0.003)
                                        txtMinUnder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder9.Text) > 0.508)
                                        txtMinUnder9.Text = "0.508";
                                }
                                else { txtMinUnder9.Text = "0.003"; }
                                if (txtMinUnder10.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMinUnder10.Text) < 0.003)
                                        txtMinUnder10.Text = "0.003";
                                    else if (Convert.ToDouble(txtMinUnder10.Text) > 0.508)
                                        txtMinUnder10.Text = "0.508";
                                }
                                else { txtMinUnder10.Text = "0.003"; }

                                if (txtMaxOder1.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder1.Text) < 0.003)
                                        txtMaxOder1.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder1.Text) > 0.508)
                                        txtMaxOder1.Text = "0.508";
                                }
                                else { txtMaxOder1.Text = "0.003"; }
                                if (txtMaxOder2.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder2.Text) < 0.003)
                                        txtMaxOder2.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder2.Text) > 0.508)
                                        txtMaxOder2.Text = "0.508";

                                }
                                else { txtMaxOder2.Text = "0.003"; }
                                if (txtMaxOder3.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder3.Text) < 0.003)
                                        txtMaxOder3.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder3.Text) > 0.508)
                                        txtMaxOder3.Text = "0.508";
                                }
                                else { txtMaxOder3.Text = "0.003"; }
                                if (txtMaxOder4.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder4.Text) < 0.003)
                                        txtMaxOder4.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder4.Text) > 0.508)
                                        txtMaxOder4.Text = "0.508";
                                }
                                else { txtMaxOder4.Text = "0.003"; }
                                if (txtMaxOder5.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder5.Text) < 0.003)
                                        txtMaxOder5.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder5.Text) > 0.508)
                                        txtMaxOder5.Text = "0.508";
                                }
                                else { txtMaxOder5.Text = "0.003"; }
                                if (txtMaxOder6.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder6.Text) < 0.003)
                                        txtMaxOder6.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder6.Text) > 0.508)
                                        txtMaxOder6.Text = "0.508";
                                }
                                else { txtMaxOder6.Text = "0.003"; }
                                if (txtMaxOder7.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder7.Text) < 0.003)
                                        txtMaxOder7.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder7.Text) > 0.508)
                                        txtMaxOder7.Text = "0.508";
                                }
                                else { txtMaxOder7.Text = "0.003"; }
                                if (txtMaxOder8.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder8.Text) < 0.003)
                                        txtMaxOder8.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder8.Text) > 0.508)
                                        txtMaxOder8.Text = "0.508";
                                }
                                else { txtMaxOder8.Text = "0.003"; }
                                if (txtMaxOder9.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder9.Text) < 0.003)
                                        txtMaxOder9.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder9.Text) > 0.508)
                                        txtMaxOder9.Text = "0.508";
                                }
                                else { txtMaxOder9.Text = "0.003"; }
                                if (txtMaxOder10.Text.Trim() != "")
                                {
                                    if (Convert.ToDouble(txtMaxOder10.Text) < 0.003)
                                        txtMaxOder10.Text = "0.003";
                                    else if (Convert.ToDouble(txtMaxOder10.Text) > 0.508)
                                        txtMaxOder10.Text = "0.508";
                                }
                                else { txtMaxOder10.Text = "0.003"; }

                                if ((Convert.ToDouble(txtDiamUL1.Text) - Convert.ToDouble(txtDiamLL1.Text)) < 0.03)
                                {
                                    txtDiamLL1.Text = (Convert.ToDouble(txtDiamUL1.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL2.Text) - Convert.ToDouble(txtDiamLL2.Text)) < 0.03)
                                {
                                    txtDiamLL2.Text = (Convert.ToDouble(txtDiamUL2.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL3.Text) - Convert.ToDouble(txtDiamLL3.Text)) < 0.03)
                                {
                                    txtDiamLL3.Text = (Convert.ToDouble(txtDiamUL3.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL4.Text) - Convert.ToDouble(txtDiamLL4.Text)) < 0.03)
                                {
                                    txtDiamLL4.Text = (Convert.ToDouble(txtDiamUL4.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL5.Text) - Convert.ToDouble(txtDiamLL5.Text)) < 0.03)
                                {
                                    txtDiamLL5.Text = (Convert.ToDouble(txtDiamUL5.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL6.Text) - Convert.ToDouble(txtDiamLL6.Text)) < 0.03)
                                {
                                    txtDiamLL6.Text = (Convert.ToDouble(txtDiamUL6.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL7.Text) - Convert.ToDouble(txtDiamLL7.Text)) < 0.03)
                                {
                                    txtDiamLL7.Text = (Convert.ToDouble(txtDiamUL7.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL8.Text) - Convert.ToDouble(txtDiamLL8.Text)) < 0.03)
                                {
                                    txtDiamLL8.Text = (Convert.ToDouble(txtDiamUL8.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL9.Text) - Convert.ToDouble(txtDiamLL9.Text)) < 0.03)
                                {
                                    txtDiamLL9.Text = (Convert.ToDouble(txtDiamUL9.Text) - 0.03).ToString();
                                }
                                if ((Convert.ToDouble(txtDiamUL10.Text) - Convert.ToDouble(txtDiamLL10.Text)) < 0.03)
                                {
                                    txtDiamLL10.Text = (Convert.ToDouble(txtDiamUL10.Text) - 0.03).ToString();
                                }
                                #endregion
                                string script = "alert(\"Edit Z-Mike Failed!,Exceeded Min or Max value allowed\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }

                        }
                        else
                        {
                            string script = "alert(\"Edit Z-Mike Failed!,Please select Meas Type\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                        }
                    }
                }
                else
                {
                    string script = "alert(\"Meas Type cannot overlap!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
        }

        protected void drplQtyMeasTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drplQtyMeasTypes.Text == "3")
            {

                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = false;
                txtDiamLL4.Visible = false;
                txtDiamUL4.Visible = false;
                txtMinUnder4.Visible = false;
                txtMaxOder4.Visible = false;
                drplMeasType5.Visible = false;
                txtDiamLL5.Visible = false;
                txtDiamUL5.Visible = false;
                txtMinUnder5.Visible = false;
                txtMaxOder5.Visible = false;
                drplMeasType6.Visible = false;
                txtDiamLL6.Visible = false;
                txtDiamUL6.Visible = false;
                txtMinUnder6.Visible = false;
                txtMaxOder6.Visible = false;
                drplMeasType7.Visible = false;
                txtDiamLL7.Visible = false;
                txtDiamUL7.Visible = false;
                txtMinUnder7.Visible = false;
                txtMaxOder7.Visible = false;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;


            }
            else if (drplQtyMeasTypes.Text == "4")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = false;
                txtDiamLL5.Visible = false;
                txtDiamUL5.Visible = false;
                txtMinUnder5.Visible = false;
                txtMaxOder5.Visible = false;
                drplMeasType6.Visible = false;
                txtDiamLL6.Visible = false;
                txtDiamUL6.Visible = false;
                txtMinUnder6.Visible = false;
                txtMaxOder6.Visible = false;
                drplMeasType7.Visible = false;
                txtDiamLL7.Visible = false;
                txtDiamUL7.Visible = false;
                txtMinUnder7.Visible = false;
                txtMaxOder7.Visible = false;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "5")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = false;
                txtDiamLL6.Visible = false;
                txtDiamUL6.Visible = false;
                txtMinUnder6.Visible = false;
                txtMaxOder6.Visible = false;
                drplMeasType7.Visible = false;
                txtDiamLL7.Visible = false;
                txtDiamUL7.Visible = false;
                txtMinUnder7.Visible = false;
                txtMaxOder7.Visible = false;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "6")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = true;
                txtDiamLL6.Visible = true;
                txtDiamUL6.Visible = true;
                txtMinUnder6.Visible = true;
                txtMaxOder6.Visible = true;
                drplMeasType7.Visible = false;
                txtDiamLL7.Visible = false;
                txtDiamUL7.Visible = false;
                txtMinUnder7.Visible = false;
                txtMaxOder7.Visible = false;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "7")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = true;
                txtDiamLL6.Visible = true;
                txtDiamUL6.Visible = true;
                txtMinUnder6.Visible = true;
                txtMaxOder6.Visible = true;
                drplMeasType7.Visible = true;
                txtDiamLL7.Visible = true;
                txtDiamUL7.Visible = true;
                txtMinUnder7.Visible = true;
                txtMaxOder7.Visible = true;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "8")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = true;
                txtDiamLL6.Visible = true;
                txtDiamUL6.Visible = true;
                txtMinUnder6.Visible = true;
                txtMaxOder6.Visible = true;
                drplMeasType7.Visible = true;
                txtDiamLL7.Visible = true;
                txtDiamUL7.Visible = true;
                txtMinUnder7.Visible = true;
                txtMaxOder7.Visible = true;
                drplMeasType8.Visible = true;
                txtDiamLL8.Visible = true;
                txtDiamUL8.Visible = true;
                txtMinUnder8.Visible = true;
                txtMaxOder8.Visible = true;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "9")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = true;
                txtDiamLL6.Visible = true;
                txtDiamUL6.Visible = true;
                txtMinUnder6.Visible = true;
                txtMaxOder6.Visible = true;
                drplMeasType7.Visible = true;
                txtDiamLL7.Visible = true;
                txtDiamUL7.Visible = true;
                txtMinUnder7.Visible = true;
                txtMaxOder7.Visible = true;
                drplMeasType8.Visible = true;
                txtDiamLL8.Visible = true;
                txtDiamUL8.Visible = true;
                txtMinUnder8.Visible = true;
                txtMaxOder8.Visible = true;
                drplMeasType9.Visible = true;
                txtDiamLL9.Visible = true;
                txtDiamUL9.Visible = true;
                txtMinUnder9.Visible = true;
                txtMaxOder9.Visible = true;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
            else if (drplQtyMeasTypes.Text == "10")
            {
                drplMeasType1.Visible = true;
                txtDiamLL1.Visible = true;
                txtDiamUL1.Visible = true;
                txtMinUnder1.Visible = true;
                txtMaxOder1.Visible = true;
                drplMeasType2.Visible = true;
                txtDiamLL2.Visible = true;
                txtDiamUL2.Visible = true;
                txtMinUnder2.Visible = true;
                txtMaxOder2.Visible = true;
                drplMeasType3.Visible = true;
                txtDiamLL3.Visible = true;
                txtDiamUL3.Visible = true;
                txtMinUnder3.Visible = true;
                txtMaxOder3.Visible = true;
                drplMeasType4.Visible = true;
                txtDiamLL4.Visible = true;
                txtDiamUL4.Visible = true;
                txtMinUnder4.Visible = true;
                txtMaxOder4.Visible = true;
                drplMeasType5.Visible = true;
                txtDiamLL5.Visible = true;
                txtDiamUL5.Visible = true;
                txtMinUnder5.Visible = true;
                txtMaxOder5.Visible = true;
                drplMeasType6.Visible = true;
                txtDiamLL6.Visible = true;
                txtDiamUL6.Visible = true;
                txtMinUnder6.Visible = true;
                txtMaxOder6.Visible = true;
                drplMeasType7.Visible = true;
                txtDiamLL7.Visible = true;
                txtDiamUL7.Visible = true;
                txtMinUnder7.Visible = true;
                txtMaxOder7.Visible = true;
                drplMeasType8.Visible = true;
                txtDiamLL8.Visible = true;
                txtDiamUL8.Visible = true;
                txtMinUnder8.Visible = true;
                txtMaxOder8.Visible = true;
                drplMeasType9.Visible = true;
                txtDiamLL9.Visible = true;
                txtDiamUL9.Visible = true;
                txtMinUnder9.Visible = true;
                txtMaxOder9.Visible = true;
                drplMeasType10.Visible = true;
                txtDiamLL10.Visible = true;
                txtDiamUL10.Visible = true;
                txtMinUnder10.Visible = true;
                txtMaxOder10.Visible = true;

            }
            else if (drplQtyMeasTypes.Text == "")
            {
                drplMeasType1.Visible = false;
                txtDiamLL1.Visible = false;
                txtDiamUL1.Visible = false;
                txtMinUnder1.Visible = false;
                txtMaxOder1.Visible = false;
                drplMeasType2.Visible = false;
                txtDiamLL2.Visible = false;
                txtDiamUL2.Visible = false;
                txtMinUnder2.Visible = false;
                txtMaxOder2.Visible = false;
                drplMeasType3.Visible = false;
                txtDiamLL3.Visible = false;
                txtDiamUL3.Visible = false;
                txtMinUnder3.Visible = false;
                txtMaxOder3.Visible = false;
                drplMeasType4.Visible = false;
                txtDiamLL4.Visible = false;
                txtDiamUL4.Visible = false;
                txtMinUnder4.Visible = false;
                txtMaxOder4.Visible = false;
                drplMeasType5.Visible = false;
                txtDiamLL5.Visible = false;
                txtDiamUL5.Visible = false;
                txtMinUnder5.Visible = false;
                txtMaxOder5.Visible = false;
                drplMeasType6.Visible = false;
                txtDiamLL6.Visible = false;
                txtDiamUL6.Visible = false;
                txtMinUnder6.Visible = false;
                txtMaxOder6.Visible = false;
                drplMeasType7.Visible = false;
                txtDiamLL7.Visible = false;
                txtDiamUL7.Visible = false;
                txtMinUnder7.Visible = false;
                txtMaxOder7.Visible = false;
                drplMeasType8.Visible = false;
                txtDiamLL8.Visible = false;
                txtDiamUL8.Visible = false;
                txtMinUnder8.Visible = false;
                txtMaxOder8.Visible = false;
                drplMeasType9.Visible = false;
                txtDiamLL9.Visible = false;
                txtDiamUL9.Visible = false;
                txtMinUnder9.Visible = false;
                txtMaxOder9.Visible = false;
                drplMeasType10.Visible = false;
                txtDiamLL10.Visible = false;
                txtDiamUL10.Visible = false;
                txtMinUnder10.Visible = false;
                txtMaxOder10.Visible = false;

            }
        }
    }
}