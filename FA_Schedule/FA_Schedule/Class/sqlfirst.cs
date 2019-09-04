using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;


namespace FA_Schedule
{
    class sqlfirst
    {
        NpgsqlConnection connection;
        public string server = "192.168.145.12";
        public string database = "usrdb";
        public string conString()
        {
            return @"Server=" + server + "; Port=5432; User Id=pqm; Password=dbuser;"
                        + "Database=" + database + "; CommandTimeout=50; Timeout=50;";
        }

        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new NpgsqlConnection(conString());
                connection.Open();
                command = new NpgsqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                cmb.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }
        }
        public string sqlExecuteScalarString(string sql)
        {
            string response;
            try
            {
                connection = new NpgsqlConnection(conString());
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                response = Convert.ToString(command.ExecuteScalar());
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL executeschalar moethod failed." + System.Environment.NewLine + ex.Message
                                , "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return String.Empty;
            }
        }

        public void datatable(string sql, ref DataTable dt1)
        {
            NpgsqlConnection connection = new NpgsqlConnection(conString());
            NpgsqlCommand command = new NpgsqlCommand();

            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
            {
                connection.Open();
                command.CommandText = sql;
                command.Connection = connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt1);
                connection.Close();
            }
        }
    }
}