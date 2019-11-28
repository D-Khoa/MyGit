using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DKMES
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "mysql06.dotvndns.vn";
            int port = 3306;
            string database = "iottechn_asp";
            string username = "iottechn_mod";
            string password = "4865awds";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}