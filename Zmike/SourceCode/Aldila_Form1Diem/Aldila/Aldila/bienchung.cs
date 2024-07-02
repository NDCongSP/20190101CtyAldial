using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldila
{
    public static class bienchung
    {
        public static  SqlServer sql = new SqlServer();
        public static List<string> lstrdata = new List<string>();
        public static string part, workorder,buildtype,shaftType;
        public static int partvalue;
        public static bool khoa=false;
        public static int sample_time, resetNewTime = 0;
        public static byte sample_number;
        public static byte initial;
        public static int number_of_pos = 0;
        public static string tenMay = "", tenTask = "",key="",ipcloud="";
        public static string chuoiKetNoiSqlServer = "";
        public static double offset = 0;
        public static string AddStringIntoWork { get; set; }
    }
}
