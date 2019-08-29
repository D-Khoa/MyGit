using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaseSQL
{
    public class BaseCommand
    {
        public static string command { get; set; }
        public static SqlConnection conn = BaseConnection.ConnectDB();

        public static SqlDataReader ReaderDB (string cmd)
        {
            conn.Open();
            SqlCommand scmd = new SqlCommand(cmd, conn);
            SqlDataReader rdr = scmd.ExecuteReader();
            conn.Close();
            return rdr;
        }

        public static string ScalarDB(string cmd)
        {
            conn.Open();
            SqlCommand scmd = new SqlCommand(cmd, conn);
            string scl = scmd.ExecuteScalar().ToString();
            conn.Close();
            return scl;
        }

        public static int NonQueryDB(string cmd)
        {
            conn.Open();
            SqlCommand scmd = new SqlCommand(cmd, conn);
            int nq = scmd.ExecuteNonQuery();
            conn.Close();
            return nq;
        }

        public static string select(string column, string table, string cond)
        {
            string s = "";
            if (cond != "")
                s = "select " + column + " from " + table + " where " + cond;
            else s = "select " + column + " from " + table;
            return s;
        }
    }
}
