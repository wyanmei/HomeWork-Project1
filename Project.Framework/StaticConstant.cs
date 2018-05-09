using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Framework
{
    public class StaticConstant
    {
        /// <summary>
        /// sqlserver数据库连接
        /// </summary>
        public static string STR_SQL_CONNECTION_STRING = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        private static string DBHLPER_CONFIG = ConfigurationManager.AppSettings["IDBHelper"];
    }
}
