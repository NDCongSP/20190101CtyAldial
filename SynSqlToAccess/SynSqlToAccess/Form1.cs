using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using System.Threading;

namespace SynSqlToAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Sqldt = new DataTable();
        public static SqlServer sqlServer = new SqlServer();
        public static AccessServer AccessServer = new AccessServer();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlServer.chuoiKetNoiSqlServer= ConfigurationManager.AppSettings["SqlConstring"];
            AccessServer.chuoiKetNoiAccessServer = ConfigurationManager.AppSettings["AccConstring"];
        }
        private string  updateaccess(string tenbang)
        {
            // read data from 
            if (Sqldt != null)
            {
                Sqldt.Clear();
            }
            Sqldt = sqlServer.SelectData(tenbang);
            if (Sqldt != null)
            {
                this.txtLog.AppendText("--> Đọc Sql bảng  " + tenbang + " thành công"+ "\r\n");
            }
            else
            {
                this.txtLog.AppendText("--> Đọc Sql bảng  " + tenbang + " thất bại" + "\r\n");
            }
            try
            {
                //------------------------------------------------------------
                // creat and open connect access
                OleDbConnection connect = new OleDbConnection(AccessServer.chuoiKetNoiAccessServer);
                connect.Open();
                // delete table access
                string Strdelete = "delete from " + tenbang;
                OleDbCommand cmddelete = new OleDbCommand(Strdelete, connect);
                cmddelete.ExecuteNonQuery();
                cmddelete.Dispose();
                cmddelete = null;
                // new insert accesss
                for (int i = 0; i < Sqldt.Rows.Count; i++)
                {
                    //string str = "insert into Freq_Standard values('" + Sqldt.Rows[i][0].ToString() + "','" + Sqldt.Rows[i][1].ToString() + "','" + Sqldt.Rows[i][2].ToString() + "','" + Sqldt.Rows[i][3].ToString() + "','" + Sqldt.Rows[i][4].ToString() + "','" + Sqldt.Rows[i][5].ToString()+ "','" + Sqldt.Rows[i][6].ToString() + "','" + Sqldt.Rows[i][7].ToString() + "','" + Sqldt.Rows[i][8].ToString() + "',NULL,NULL,NULL)";
                    string str = "insert into " + tenbang + " values('";
                    for (int j = 0; j < Sqldt.Columns.Count; j++)
                    {
                        if (j < Sqldt.Columns.Count - 1)
                        {
                           
                            if (j==11 && tenbang.Trim() == "Freq_Standard")
                            {
                                if (Sqldt.Rows[i][j].ToString() != "")
                                {
                                    str = str + Sqldt.Rows[i][j].ToString() + "')";
                                }
                                else
                                {
                                    str = str + "NULL)";
                                }
                                break;
                            }    
                            else
                            {
                                if (Sqldt.Rows[i][j].ToString() != "")
                                {
                                    if (Sqldt.Rows[i][j + 1].ToString() != "")
                                    {
                                        str = str + Sqldt.Rows[i][j].ToString() + "','";
                                    }
                                    else
                                    {
                                        str = str + Sqldt.Rows[i][j].ToString() + "',";
                                    }

                                }
                                else
                                {

                                    if (Sqldt.Rows[i][j + 1].ToString() != "")
                                    {
                                        str = str + "NULL,'";
                                    }
                                    else
                                    {
                                        str = str + "NULL,";
                                    }
                                }
                            }
                          

                        }
                        else if (j == Sqldt.Columns.Count - 1)
                        {

                            if (Sqldt.Rows[i][j].ToString() != "")
                            {
                                str = str + Sqldt.Rows[i][j].ToString() + "')";
                            }
                            else
                            {
                                str = str + "NULL)";
                            }
                        }
                       
                    }
                    //MessageBox.Show(str);
                    OleDbCommand cmd = new OleDbCommand(str, connect);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = null;
                }

                connect.Close();
                connect.Dispose();
                return "GOOD";
            }
            catch(Exception ex)
            {
                this.txtErro.AppendText("--> Quá trình đồng bộ đã xảy ra lỗi" + "\r\n");
                this.txtErro.AppendText("--> "+ex.ToString() + "\r\n");
                return "BAD";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            string strtable = comboBox1.Text;
            if (strtable.Trim() == "")
            {
                this.txtLog.AppendText("--> Bạn chưa chọn bảng để đồng bộ, vui lòng chọn lại!!" + "\r\n");
            }
            else if (strtable == "All")
            {
                this.txtLog.AppendText("--> Bạn đã chọn đồng bộ tất cả các bảng!!" + "\r\n");
                // đồng bộ bảng Flex_Standard
                if (updateaccess("Flex_Standard") == "GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Flex_Standard thành công" + "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Flex_Standard thất bại" + "\r\n");
                }
                // đồng bộ bảng Freq_Standard
                if (updateaccess("Freq_Standard") == "GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Freq_Standard thành công" + "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Freq_Standard thất bại" + "\r\n");
                }
                // đồng bộ bảng Part
                if (updateaccess("Part") == "GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Part thành công" + "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng Part thất bại" + "\r\n");
                }
                // đồng bộ bảng PartZM
                if (updateaccess("PartZM") == "GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng PartZM thành công" + "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng PartZM thất bại" + "\r\n");
                }
                // đồng bộ bảng ZMmeasType
                if (updateaccess("ZMmeasType") == "GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng ZMmeasType thành công" + "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng ZMmeasType thất bại" + "\r\n");
                }
                this.txtLog.AppendText("\r\n");
                this.txtLog.AppendText("\r\n");
                this.txtLog.AppendText("--> Quá trình đồng bộ bảng kết thúc!!!" + "\r\n");
                //Thread.Sleep(1000);
                //this.txtLog.Clear();
            }
            else
            {
                this.txtLog.AppendText("--> Bạn đã chọn đồng bộ bảng " + strtable + "\r\n");
                if (updateaccess(strtable)=="GOOD")
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng " + strtable +" thành công"+ "\r\n");
                }
                else
                {
                    this.txtLog.AppendText("--> Đồng bộ bảng " + strtable + " thất bại" + "\r\n");
                }
                this.txtLog.AppendText("\r\n");
                this.txtLog.AppendText("\r\n");
                this.txtLog.AppendText("--> Quá trình đồng bộ bảng kết thúc!!!" + "\r\n");
                //Thread.Sleep(1000);
                //this.txtLog.Clear();
            }
           
        }
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtLog.Clear();
            this.txtErro.Clear();
        }
    }
}
