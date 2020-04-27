using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// DEPARTMENT IN NIDEC
    /// </summary>
    public class m_department
    {
        #region FIELDS OF DEAPARTMENT
        public int dept_id { get; set; }
        public string dept_cd { get; set; }
        public string dept_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<m_department> listDept { get; set; }
        #endregion

       
        /// <summary>
        /// Get all department
        /// </summary>
        public void GetListDepartment()
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listDept = new BindingList <m_department>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select dept_id, dept_cd, dept_name, registration_user_cd, registration_date_time from m_department ";
            query += "order by dept_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                m_department outItem = new m_department
                {
                    dept_id = (int)reader["dept_id"],
                    dept_cd = reader["dept_cd"].ToString(),
                    dept_name = reader["dept_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listDept.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
        public int AddDepartment(m_department adddept)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO m_department(dept_cd, dept_name, registration_user_cd)";
            query += "VALUES ('" + adddept.dept_cd + "','" + adddept.dept_name + "','" + adddept.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
        public int UpdateDept(m_department updept)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE m_department SET dept_cd='" + updept.dept_cd+ "',dept_name = '" + updept.dept_name;
            query += "', registration_user_cd ='" + updept.registration_user_cd;
            query += "', registration_date_time = now() where dept_id ='" + updept.dept_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
        public int DeleteDept(int id)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM m_department WHERE dept_id ='" + id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;

        }
    }
}
