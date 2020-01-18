using System;
using System.Collections.Generic;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    ///DESTINATION IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_destination : Object
    {
        #region FIELDS OF DEPARTMENT
        public string destination_cd { get; set; }
        public string destination_name { get; set; }
        public string dept_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<pts_destination> listDepartment { get; set; }
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
            listDepartment = new List<pts_destination>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_destination where 1=1 ";
            if (string.IsNullOrEmpty(des_code))
                query += "and destination_cd = '" + des_code + "' ";
            if (string.IsNullOrEmpty(dept_code))
                query += "and dept_cd = '" + dept_code + "' ";
            query += "order by destination_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_destination outItem = new pts_destination
                {
                    destination_cd = reader["destination_cd"].ToString(),
                    destination_name = reader["destination_name"].ToString(),
                    dept_cd = reader["dept_cd"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listDepartment.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
    }
}
