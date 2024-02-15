using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Aldila
{
    public class SqlServer
    {
      
       
        public DataTable SelectData(string tenbang)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
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
        public DataTable selectdatatheocot(string tenbang, string tencot,string where)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT " + tencot + " FROM " + tenbang + " " + where, connect);
                ad.Fill(ds);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return ds;
            }
            catch { return null; }
        }
        public string  selectdatatheoid(string tenbang, string tencotGiatri, string tencotID,string giatri)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT " + tencotGiatri + " FROM " + tenbang + " where "+tencotID+" ='"+giatri+"'", connect);
                ad.Fill(ds);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                if(ds!=null&&ds.Rows.Count!=0)
                {
                    return ds.Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }
        public DataTable selectdatanew_limit(string tenbang, string tencot_sapsep, string soluong_limit)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                DataTable ds = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + tenbang + " order by " + tencot_sapsep + " desc limit " + soluong_limit + "", connect);
                ad.Fill(ds);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return ds;
            }
            catch { return null; }
        }
        public string themData(string tenbang, string values)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                string str = "insert into " + tenbang + " " + values + "";
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
        public string Update(string tenbang, string set)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                string str = "update "+tenbang+" " + set + "";
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
        public string deletedata(string tenbang, string where)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
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
        public DataTable SelectDataWhere(string tenbang, string where)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                DataTable TableReturn = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + tenbang + " " + where + " ", connect);
                ad.Fill(TableReturn);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return TableReturn;
            }
            catch { return null; }
        }
        public DataTable SelectDataWhere_ds(string tenbang,string tencotb,string where)
        {
            try
            {
                SqlConnection connect = new SqlConnection(bienchung.chuoiKetNoiSqlServer);
                connect.Open();
                DataTable TableReturn = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT " + tencotb + " FROM " + tenbang + " " + where + " ", connect);
                ad.Fill(TableReturn);
                ad.Dispose();
                connect.Close();
                connect.Dispose();
                return TableReturn;
            }
            catch { return null; }
        }

    }
}
