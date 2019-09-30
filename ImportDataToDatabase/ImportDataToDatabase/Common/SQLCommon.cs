using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ImportDataToDatabase.Common
{
    public class SQLCommon
    {
        public SqlConnection ConnectionDB;
        public StringBuilder ConnectionString = new StringBuilder();

        public  SQLCommon()
        {
            ConnectionString.Append(@"Data Source=Shin;Initial Catalog = mtest;
                                      Integrated Security = True");
        }

        public void SQLExcuteNonQuery(string sql)
        {
            ConnectionDB = new SqlConnection(ConnectionString.ToString());
            ConnectionDB.Open();
            SqlCommand command = new SqlCommand(sql, ConnectionDB);
            command.ExecuteNonQuery();
            ConnectionDB.Close();
        }

        public void InsertDatatableToDB(ref DataTable dt)
        {
            ConnectionDB = new SqlConnection(ConnectionString.ToString());
            ConnectionDB.Open();
            using (var adapte = new SqlDataAdapter("select * from techlinkdb", ConnectionDB))
            using (var builder = new SqlCommandBuilder(adapte))
            {
                adapte.InsertCommand = builder.GetInsertCommand();
                adapte.Update(dt);
            }
            ConnectionDB.Close();
        }
    }
}
