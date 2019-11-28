using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DKMES
{
    class DBMySQLUtils
    {

        public static MySqlConnection
                 GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";Port=" + port + ";Uid=" + username + ";Pwd=" + password+ ";SslMode=Required;";
            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}