using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATSCADAWebApp
{
    public class BienChung
    {
        public static SqlServer sqlServer = new SqlServer();
        public static AccessServer AccessServer = new AccessServer();
        public static string user = "", password="",role="",idPart="",textPart="";
    }
}