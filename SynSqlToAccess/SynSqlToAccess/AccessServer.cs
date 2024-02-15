using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SynSqlToAccess
{
    public  class AccessServer
    {

        public string chuoiKetNoiAccessServer = "";
        //public string chuoiKetNoiSqlServer = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\Editor\ab.accdb";
        public DataTable SelectData(string tenbang)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                DataTable ds = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + tenbang, connect);
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
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                DataTable ds = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT "+tencot+" FROM " + tenbang + " "+where, connect);
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
            //try
            //{
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                DataTable ds = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT " + tencotGiatri + " FROM " + tenbang + " where "+tencotID+" ='"+giatri+"'", connect);
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
            //}
            //catch { return null; }
        }
        public DataTable selectdatanew_limit(string tenbang, string tencot_sapsep, string soluong_limit)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                DataTable ds = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + tenbang + " order by " + tencot_sapsep + " desc limit " + soluong_limit + "", connect);
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
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                string str = "insert into " + tenbang + " " + values + "";
                OleDbCommand cmd = new OleDbCommand(str, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                connect.Close();
                connect.Dispose();
                return "GOOD";
            }
            catch { return "BAD"; }
        }
        public string themDataall(string tenbang, string values)
        {
            //try
            //{
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                string str = "insert into " + tenbang + " ([ID],[Number],[Flex_Val],[Hole_Number],[Clamp_To_Wt],[Clamp_To_Sensor],[Clamp_To_Tip]) values " + values;
                OleDbCommand cmd = new OleDbCommand(str, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                connect.Close();
                connect.Dispose();
                return "GOOD";
            //}
            //catch { return "BAD"; }
        }
        public string Update(string tenbang, string set)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                string str = "update "+tenbang+" " + set + "";
                OleDbCommand cmd = new OleDbCommand(str, connect);
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
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                string str = "delete from " + tenbang + " " + where + "";
                OleDbCommand cmd = new OleDbCommand(str, connect);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                connect.Close();
                connect.Dispose();
                return "GOOD";
            }
            catch { return "BAD"; }
        }
        public string deletedataall(string tenbang)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                string str = "delete from " + tenbang ;
                OleDbCommand cmd = new OleDbCommand(str, connect);
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
                OleDbConnection connect = new OleDbConnection(chuoiKetNoiAccessServer);
                connect.Open();
                DataTable TableReturn = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + tenbang + " " + where + " ", connect);
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
