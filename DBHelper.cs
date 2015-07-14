using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBS
{
    public class DBHelper
    {
        public static string ConnectionString()
        {
            return @"server=MACINE\MSSQLSERVERR;database=bbs_db;Integrated Security=SSPI;";
        }
    }
}