using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public string chuoiKetNoiSqlServer = "Data Source=103.48.195.37;Initial Catalog=ALD_MFG;User ID=sa; Password=R00t!@#$%i%L5X%!Q";
        private void button1_Click(object sender, EventArgs e)
        {
            dt = SelectData("PartZM");
            dataGridView1.DataSource = dt;
        }
        public DataTable SelectData(string tenbang)
        {
            try
            {
                SqlConnection connect = new SqlConnection(chuoiKetNoiSqlServer);
                connect.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + tenbang, connect);
                ad.Fill(ds);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return ds;
            }
            catch { return null; }
        }
        public DataTable SelectData1(string tenbang)
        {
            try
            {
                SqlConnection connect = new SqlConnection(chuoiKetNoiSqlServer);
                connect.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT ID,Freq_BSL FROM " + tenbang, connect);
                ad.Fill(ds);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return ds;
            }
            catch { return null; }
        }
        public string deletedata(string tenbang, string where)
        {
            try
            {
                SqlConnection connect = new SqlConnection(chuoiKetNoiSqlServer);
                connect.Open();
                string str = "delete from " + tenbang + " " + where + "";
                SqlCommand cmd = new SqlCommand(str, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                connect.Close();
                connect.Dispose();
                return "GOOD";
            }
            catch { return "BAD"; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            DataColumn dc = new DataColumn("PartID");
            dt1.Columns.Add(dc);

            dc = new DataColumn("ZMID");
            dt1.Columns.Add(dc);

            dc = new DataColumn("Diam_LL");
            dt1.Columns.Add(dc);

            dc = new DataColumn("Diam_UL");
            dt1.Columns.Add(dc);

            dc = new DataColumn("Min_Under");
            dt1.Columns.Add(dc);

            dc = new DataColumn("Max_Over");
            dt1.Columns.Add(dc);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = dt.Rows[i][0].ToString();
                dr[1] = dt.Rows[i][1].ToString();
                dr[2] = (Convert.ToDouble(dt.Rows[i][2].ToString())*25.4).ToString("0.000");
                dr[3] = (Convert.ToDouble(dt.Rows[i][3].ToString()) * 25.4).ToString("0.000");
                dr[4] = (Convert.ToDouble(dt.Rows[i][4].ToString()) * 25.4).ToString("0.000");
                dr[5] = (Convert.ToDouble(dt.Rows[i][5].ToString()) * 25.4).ToString("0.000");

                dt1.Rows.Add(dr);
              
            }
            dataGridView2.DataSource = dt1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt = SelectData1("Part");
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataColumn dc = new DataColumn("ID");
            dt1.Columns.Add(dc);

            dc = new DataColumn("Freq_BSL");
            dt1.Columns.Add(dc);

            //dc = new DataColumn("Flex_LL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Flex_UL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("SW_LL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("SW_UL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("SW_Wt_LL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("SW_Wt_UL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("SW_Meas_Type", typeof(string));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Freq_LL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Freq_UL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Freq_Std", typeof(int));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Freq_BSL", typeof(float));
            //dt1.Columns.Add(dc);

            //dc = new DataColumn("Freq_Wt", typeof(int));
            //dt1.Columns.Add(dc);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                //dr[2] = dt.Rows[i][2];
                //dr[3] = dt.Rows[i][3];
                //dr[4] = dt.Rows[i][4];
                //dr[5] = dt.Rows[i][5];
                //dr[6] = dt.Rows[i][6];
                //dr[7] = dt.Rows[i][7];
                //dr[8] =dt.Rows[i][8];
                //dr[9] =dt.Rows[i][9];
                //dr[10] = dt.Rows[i][10];
                //dr[11] = dt.Rows[i][11];
                if (dt.Rows[i][1].ToString() != "")
                {
                    dr[1] = (Convert.ToDouble(dt.Rows[i][1].ToString()) * 25.4).ToString("0.00");
                }
                else
                {
                    dr[1] = dt.Rows[i][1];
                }
               // dr[13] = dt.Rows[i][13];

                dt1.Rows.Add(dr);

            }
            dataGridView2.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //deletedata("PartZM", "");
           
            deletedata("PartZM", "");
            SqlConnection connect = new SqlConnection(chuoiKetNoiSqlServer);
            connect.Open();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string str = "insert into PartZM values('" + dt1.Rows[i][0].ToString() + "','" + dt1.Rows[i][1].ToString() + "','" + dt1.Rows[i][2].ToString() + "','" + dt1.Rows[i][3].ToString() + "','" + dt1.Rows[i][4].ToString() + "','" + dt1.Rows[i][5].ToString() + "')";
                SqlCommand cmd = new SqlCommand(str, connect);
                cmd.ExecuteNonQuery();
            }
            connect.Close();
            connect.Dispose();
            MessageBox.Show("Lưu OK!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(chuoiKetNoiSqlServer);
            connect.Open();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if(dt1.Rows[i][1].ToString()!="")
                {
                    string str = "update Part set Freq_BSL='" + dt1.Rows[i][1].ToString() + "' where ID='" + dt1.Rows[i][0].ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, connect);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string str = "update Part set Freq_BSL=NULL where ID='" + dt1.Rows[i][0].ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, connect);
                    cmd.ExecuteNonQuery();
                }
               
            }
            //cmd.Dispose();
            //cmd = null;
            connect.Close();
            connect.Dispose();
            MessageBox.Show("Up OK!");
        }
    }
}
