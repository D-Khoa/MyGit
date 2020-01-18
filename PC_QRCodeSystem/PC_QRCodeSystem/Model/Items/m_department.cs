using System;
using System.Collections.Generic;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// DEPARTMENT IN NIDEC
    /// </summary>
    public class m_department
    {
        #region FIELDS OF DEAPARTMENT
        public string dept_cd { get; set; }
        public string dept_name { get; set; }
        public string m_user_cd { get; set; }
        public string gm_user_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<m_department> listDept { get; set; }
        #endregion

        /// <summary>
        /// Get list department from database with department code and user code
        /// </summary>
        /// <param name="dept_code">string.empty if get list without department code</param>
        /// <param name="user_code">string.empty if get list without user code</param>
        public void GetListDepartment(string dept_code, string user_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listDept = new List<m_department>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select b.user_cd, b.user_name, a.* from m_department a left join m_mes_user b on a.dept_cd = b.dept_cd where 1=1 ";
            if (string.IsNullOrEmpty(dept_code))
                query += "and a.dept_cd = '" + dept_code + "' ";
            if (string.IsNullOrEmpty(user_code))
                query += "and b.user_cd = '" + user_code + "' ";
            query += "order by dept_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                m_department outItem = new m_department
                {
                    dept_cd = reader["dept_cd"].ToString(),
                    dept_name = reader["dept_name"].ToString(),
                    m_user_cd = reader["m_user_cd"].ToString(),
                    gm_user_cd = reader["gm_user_cd"].ToString(),
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
    }
}
