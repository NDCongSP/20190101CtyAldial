using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Threading;
using System.Configuration;

namespace ATSCADAWebApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
      DataTable dataUseraccount = new DataTable();
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

          
            if(!IsPostBack)
            {
                BienChung.sqlServer.chuoiKetNoiSqlServer = ConfigurationManager.AppSettings["chuoiSqlServer"];
                BienChung.AccessServer.chuoiKetNoiAccessServer= ConfigurationManager.AppSettings["chuoiAccessServer"];
            }

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            dataUseraccount = BienChung.sqlServer.SelectDataWhere("useraccount","where [User]='"+txtUser.Text.Trim()+"'");
            if (dataUseraccount != null)
            {
                if(dataUseraccount.Rows.Count != 0)
                {
                    if ((txtUser.Text == dataUseraccount.Rows[0][0].ToString().Trim()) && (txtPassword.Text == dataUseraccount.Rows[0][1].ToString().Trim()) )
                    {
                        Session["Login"] = "True";
                        BienChung.role = dataUseraccount.Rows[0][2].ToString().Trim();
                        Response.Redirect("PartPage.aspx");
                    }
                    else
                    {
                        Session["Login"] = "False";
                        string script = "alert(\"Login failed!, Pass is incorrect!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    Session["Login"] = "False";
                    string script = "alert(\"Login failed!,User does not exist!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            else
            {
                Session["Login"] = "False";
                string script = "alert(\"Login failed!, No connection to the server!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
           
        }
    }
}