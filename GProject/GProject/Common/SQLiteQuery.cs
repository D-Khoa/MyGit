using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace GProject.Common
{
    public class SQLiteQuery
    {
        SQLiteConnection con = new SQLiteConnection();
        public string dbname { get; set; }

        public SQLiteQuery(string dbinput)
        {
            dbname = Path.GetFileName(dbinput);
            if (!File.Exists(dbname))
                SQLiteConnection.CreateFile(dbname);
        }

        public void createConnection()
        {
            string strconnect = "Data Source=MyDatabase.sqlite;Version=3;";
            con.ConnectionString = strconnect;
            con.Open();
        }

        public void closeConnection()
        {
            con.Close();
        }

        public void createTable(string tblname, DataTable dt)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Create table [" + dbname + "].[" + tblname + "](");
            foreach (DataColumn col in dt.Columns)
            {
                sql.Append(col.ColumnName);
                sql.Append(" ");
                sql.Append(col.DataType);
                sql.Append(",");
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append(");");
            createConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public void insertRow(string tblname, string[] columns, string[] datarow)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into " + tblname + "(");
            foreach (string col in columns)
            {
                sql.Append(col);
                sql.Append(",");
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append(") value(");
            foreach (string value in datarow)
            {
                sql.Append(value);
                sql.Append(",");
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append(");");
            createConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
    }
}
