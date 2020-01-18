using System;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PC_QRCodeSystem.Model
{
    public class PSQL
    {
        public NpgsqlConnection connection;
        public string strConnection;


        public PSQL()
        {
            //Connect string
            strConnection = Properties.Settings.Default.CONNECTSTRING_MES;
        }

        /// <summary>
        /// Open SQL connection
        /// </summary>
        public void Open()
        {
            connection = new NpgsqlConnection(strConnection);
            connection.Open();
        }

        /// <summary>
        /// Close SQL connection
        /// </summary>
        public void Close()
        {
            connection.Dispose();
            connection.Close();
        }

        public IDbCommand Command(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            return command;
        }

        /// <summary>
        /// Get data into combobox
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmb"></param>
        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new NpgsqlConnection(strConnection);
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
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get data list string
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="list"></param>
        public void getListString(string sql, ref List<string> list)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                command = new NpgsqlCommand(sql, connection);
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
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get data into autocomplete text box
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="txt"></param>
        public void getAutoCompleteData(string sql, ref TextBox txt)
        {
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataSet ds = new DataSet();
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                command = new NpgsqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataCollection.Add(row[0].ToString());
                }
                txt.AutoCompleteCustomSource = DataCollection;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get a double value data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public double sqlExecuteScalarDouble(string sql)
        {
            double response;
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                response = Convert.ToDouble(command.ExecuteScalar());
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get a string value data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string sqlExecuteScalarString(string sql)
        {
            string response;
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                response = Convert.ToString(command.ExecuteScalar());
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get a boolean value data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool sqlExecuteScalarBool(string sql)
        {
            bool response;
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                response = (bool)command.ExecuteScalar();
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get a long value data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public long sqlExecuteScalarLong(string sql)
        {
            long response;
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                response = (long)command.ExecuteScalar();
                connection.Close();
                return response;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Execute a query return a boolean value
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="result_message_show"></param>
        /// <returns></returns>
        public bool sqlExecuteNonQuery(string sql)
        {
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                int response = command.ExecuteNonQuery();
                if (response >= 1)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new Exception("Not successful!");
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Execute a query return number of data
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="result_message_show"></param>
        /// <returns></returns>
        public int sqlExecuteNonQueryInt(string sql)
        {
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                int response = command.ExecuteNonQuery();
                if (response >= 1)
                {
                    connection.Close();
                    return response;
                }
                else
                {
                    connection.Close();
                    throw new Exception("Not successful");
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Execute a query return state (0: OK, 1: NG, 2: ERROR)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="result_message_show"></param>
        /// <returns></returns>
        public int sqlExecuteNonQueryState(string sql, bool result_message_show)
        {
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                int response = command.ExecuteNonQuery();
                if (response >= 1)
                {
                    connection.Close();
                    return 1;
                }
                else
                {
                    connection.Close();
                    return 0;
                }
            }
            catch
            {
                connection.Close();
                return 2;
            }
        }

        /// <summary>
        /// Get data from adapter into datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dt"></param>
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            NpgsqlConnection connection = new NpgsqlConnection(strConnection);
            NpgsqlCommand command = new NpgsqlCommand();

            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
            {
                command.CommandText = sql;
                command.Connection = connection;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
            }
        }

        /// <summary>
        /// Execute a query return boolean value and get data into datatable
        /// </summary>
        /// <param name="sql">Query</param>
        /// <param name="dt">Datatable</param>
        /// <returns>Boolean</returns>
        public bool sqlExecuteReader(string sql, ref DataTable dt)
        {
            dt = new DataTable();
            try
            {
                connection = new NpgsqlConnection(strConnection);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                return (dt.Rows.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }
    }
}
