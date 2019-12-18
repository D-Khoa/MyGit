using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace YieldMonitor.Model
{
    public class SSQL
    {
        public SqlConnection connection;
        public string strConnection;

        public SSQL()
        {
            strConnection = @"Data Source=SHIN\SHINSQL;Initial Catalog=master;Integrated Security=True";
        }

        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new SqlConnection(strConnection);
                connection.Open();
                command = new SqlCommand(sql, connection);
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

        public void getListString(string sql, ref List<string> list)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new SqlConnection(strConnection);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                list.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    list.Add(row[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }
        }

        public double sqlExecuteScalarDouble(string sql)
        {
            double response;
            try
            {
                connection = new SqlConnection(strConnection);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                response = Convert.ToDouble(command.ExecuteScalar());
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL executeschalar moethod failed." + System.Environment.NewLine + ex.Message
                                , "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return 100;
            }
        }
    }
}
