using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    ///DESTINATION IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_destination
    {
        #region FIELDS OF DEPARTMENT
        public int destination_id { get; set; }
        public string destination_cd { get; set; }
        public string destination_name { get; set; }
        public string dept_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_destination> listdestination { get; set; }
        #endregion

        /// <summary>
        /// Get list destination from database with destination code and department code
        /// </summary>
        /// <param name="des_code">string.empty if get list without destination code</param>
        /// <param name="dept_code">string.empty if get list without department code</param>
        public void GetListDestination(string des_code, string dept_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listdestination = new BindingList<pts_destination>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT destination_id, destination_cd, destination_name, dept_cd, registration_user_cd, registration_date_time ";
            query += "FROM pts_destination WHERE 1=1 ";
            if (!string.IsNullOrEmpty(des_code))
                query += "and destination_cd = '" + des_code + "' ";
            if (!string.IsNullOrEmpty(dept_code))
                query += "and dept_cd = '" + dept_code + "' ";
            query += "order by destination_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_destination outItem = new pts_destination
                {
                    destination_id = (int)reader["destination_id"],
                    destination_cd = reader["destination_cd"].ToString(),
                    destination_name = reader["destination_name"].ToString(),
                    dept_cd = reader["dept_cd"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listdestination.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
        public int AddDestination(pts_destination adddest)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_destination(destination_cd, destination_name, dept_cd, registration_user_cd)";
            query += "VALUES ('" + adddest.destination_cd + "','" + adddest.destination_name + "','" + adddest.dept_cd + "','" + adddest.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
        public int UpdateDest(pts_destination updest)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_destination SET destination_cd='" + updest.destination_cd + "',destination_name = '" + updest.destination_name+ "',dept_cd = '" + updest.dept_cd;
            query += "', registration_user_cd ='" + updest.registration_user_cd;
            query += "', registration_date_time = now() where destination_id ='" + updest.destination_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
        public int DeleteDest(int id)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM pts_destination WHERE destination_id ='" + id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;

        }
    }
}
