using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace ATSCADAWebApp
{
    public partial class ReportPage : System.Web.UI.Page
    {
        string[] ArrayTo, ArrayFrom;
        char[] TimeCut = new char[] { '/', ' ' };
        DataTable dt = new DataTable();
        #region Main Static Objects - THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED OR MODIFIED
        /// <summary>
        /// THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED
        /// </summary>
        static iDriverWeb Driver = new iDriverWeb();
        static List<Control> allControls = new List<Control>();
        static SetDriver SD = new SetDriver();
        #endregion

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
            #endregion
            if (!IsPostBack)
            {
                ArrayFrom = (DateTime.Now.ToString("MM/dd/yyyy")).Split(TimeCut, StringSplitOptions.RemoveEmptyEntries);

                FromData.Text = ArrayFrom[0] + "/" + ArrayFrom[1] + "/" + ArrayFrom[2];
                ToData.Text = ArrayFrom[0] + "/" + ArrayFrom[1] + "/" + ArrayFrom[2];
                if (dt != null)
                {
                    dt.Clear();
                }
                dt = BienChung.sqlServer.selectdatatheocot("ZMike", "ID,Name", "");
                if (dt != null && dt.Rows.Count != 0)
                {
                    dt.Rows.Add(new object[] { "-1", "All" });
                    drplName.DataSource =dt;
                    drplName.DataTextField = "Name";
                    drplName.DataValueField = "ID";
                    drplName.DataBind();
                }
                if (dt != null)
                {
                    dt.Clear();
                }
                dt = BienChung.sqlServer.selectdatatheocot("Part", "ID,Number", "");
                if (dt != null && dt.Rows.Count != 0)
                {

                    drplPart.DataSource = dt;
                    drplPart.DataTextField = "Number";
                    drplPart.DataValueField = "ID";
                    drplPart.DataBind();
                }
            }
        }

       
       
        public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        protected void btnSerch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt != null)
                {
                    dt.Clear();
                }
                ArrayTo = (FromData.Text.Trim()).Split(TimeCut, StringSplitOptions.RemoveEmptyEntries);
                ArrayFrom = (ToData.Text.Trim()).Split(TimeCut, StringSplitOptions.RemoveEmptyEntries);
                if (drplName.SelectedItem.Text != "All")
                {
                    //dt = BienChung.sqlServer.selectdatatheocot("DatalogZMike", "Station,ShaftNum,[DateTime],Part,MeasType,WorkOrder,DiamReading,RangeReading,MaxOver,MinUnder,DiamUL,DiamLL,MaxOverUL,MinUnderLL,PassFail,BuildType", "where Part='" + drplPart.SelectedItem.Text + "' AND ShaftType='" + drplSaveType.SelectedItem.Value + "' AND Station='" + drplName.SelectedItem.Text + "' AND DateTime >='" + ArrayTo[2] + "-" + ArrayTo[0] + "-" + ArrayTo[1] + " 00:00:00.000' AND DateTime <='" + ArrayFrom[2] + "-" + ArrayFrom[0] + "-" + ArrayFrom[1] + " 23:59:59.999'");
                    dt = BienChung.sqlServer.selectdatatheocot("DatalogZMike", "Station,ShaftNum,[DateTime],Part,MeasType,WorkOrder,DiamReading,RangeReading,MaxOver,MinUnder,DiamUL,DiamLL,MaxOverUL,MinUnderLL,PassFail,BuildType"
                        , $"where Part='{drplPart.SelectedItem.Text}' AND ShaftType='{drplSaveType.SelectedItem.Value}' AND Station='{drplName.SelectedItem.Text}' " +
                        $"AND DateTime >='{ArrayTo[2]}-{ArrayTo[0]}-{ArrayTo[1]} 00:00:00.000' AND DateTime <='{ArrayFrom[2]}-{ArrayFrom[0]}-{ArrayFrom[1]} 23:59:59.999' " +
                        $"order by WorkOrder asc,ShaftNum asc,MeasType asc");
                }
                else if (drplName.SelectedItem.Text == "All")
                {
                    //dt = BienChung.sqlServer.selectdatatheocot("DatalogZMike", "Station,ShaftNum,[DateTime],Part,MeasType,WorkOrder,DiamReading,RangeReading,MaxOver,MinUnder,DiamUL,DiamLL,MaxOverUL,MinUnderLL,PassFail,BuildType", "where  Part='" + drplPart.SelectedItem.Text + "' AND ShaftType='" + drplSaveType.SelectedItem.Value + "' AND DateTime >='" + ArrayTo[2] + "-" + ArrayTo[0] + "-" + ArrayTo[1] + " 00:00:00.000' AND DateTime <='" + ArrayFrom[2] + "-" + ArrayFrom[0] + "-" + ArrayFrom[1] + " 23:59:59.999'");
                    dt = BienChung.sqlServer.selectdatatheocot("DatalogZMike", "Station,ShaftNum,[DateTime],Part,MeasType,WorkOrder,DiamReading,RangeReading,MaxOver,MinUnder,DiamUL,DiamLL,MaxOverUL,MinUnderLL,PassFail,BuildType"
                        , $"where Part='{drplPart.SelectedItem.Text}' AND ShaftType='{drplSaveType.SelectedItem.Value}' " +
                        $"AND DateTime >='{ArrayTo[2]}-{ArrayTo[0]}-{ArrayTo[1]} 00:00:00.000' AND DateTime <='{ArrayFrom[2]}-{ArrayFrom[0]}-{ArrayFrom[1]} 23:59:59.999' " +
                        $"order by WorkOrder asc,ShaftNum asc,MeasType asc");
                }
                Data.DataSource = dt;
                Data.DataBind();
            }
            catch { }
        }

        protected void btnDowload_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename= Report_Data.xls");
            Response.ContentType = "application/vnd.xls";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Data.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Data_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Header)
            {
                Data.CssClass = "DataStyleAll";
                e.Row.Cells[0].Text = "Station";
                e.Row.Cells[1].Text = "Shaft Num";
                e.Row.Cells[2].Text = "Date-Time";
                e.Row.Cells[3].Text = "Part";
                e.Row.Cells[4].Text = "MeasType";
                e.Row.Cells[5].Text = "WorkOrder";
                e.Row.Cells[6].Text = "Diam Reading";
                e.Row.Cells[7].Text = "Range Reading";
                e.Row.Cells[8].Text = "Max Over";
                e.Row.Cells[9].Text = "Min Under";
                e.Row.Cells[10].Text = "Diam UL";
                e.Row.Cells[11].Text = "Diam LL";
                e.Row.Cells[12].Text = "Max Over";
                e.Row.Cells[13].Text = "Min Under";
                e.Row.Cells[14].Text = "Pass/Fail";
                e.Row.Cells[15].Text = "Build Type";

            }
        }
    }
}