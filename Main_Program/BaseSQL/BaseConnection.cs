using System.Data.SqlClient;
namespace BaseSQL
{
    class BaseConnection
    {
        //Data Source=Shin;Initial Catalog=QLMap;
        //Persist Security Info=True;User ID=admin;Password=***********
        public static string sqlsever { get; set; }
        public static string sqldatabase { get; set; }
        public static string sqluser { get; set; }
        public static string sqlpass { get; set; }

        public static SqlConnection GetConnectDB(string sever, string database, string user, string pass)
        {
            string connstring = "Data Source=" + sever + ";"
                          + "Initial Catalog=" + database + ";"
                          + "Persist Security Info=True;"
                          + "User ID=" + user + ";"
                          + "Password=" + pass;
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }

        public static SqlConnection ConnectDB()
        {
            return GetConnectDB(sqlsever, sqldatabase, sqluser, sqlpass);
        }
    }
}
