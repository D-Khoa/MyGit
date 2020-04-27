using System;
using System.Collections.Generic;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// USER ON MES INFO
    /// </summary>
    public class m_mes_user
    {
        #region FIELDS OF USER ON MES
        public string user_cd { get; set; }
        public string user_name { get; set; }
        public int locale_id { get; set; }
        public string multi_login_flag { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string registrated_factory_cd { get; set; }
        public string dept_cd { get; set; }
        public string user_position_cd { get; set; }
        public List<m_mes_user> listMesUser;
        public m_mes_user()
        {
            listMesUser = new List<m_mes_user>();
        }
        #endregion

        /// <summary>
        /// Get an user infomation
        /// </summary>
        /// <param name="user_code">User code</param>
        /// <returns></returns>
        public m_mes_user GetUser(string user_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT user_cd, user_name, locale_id, multi_login_flag, registration_user_cd, registration_date_time, ";
            query += "registrated_factory_cd, dept_cd, user_position_cd FROM m_mes_user WHERE 1=1 ";
            if (user_code.Length >= 6)
                query += "AND user_cd like '%" + user_code + "'";
            else
                query += "AND user_cd ='" + user_code + "'";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            reader.Read();
            //Get an item
            m_mes_user outItem = new m_mes_user
            {
                user_cd = reader["user_cd"].ToString(),
                user_name = reader["user_name"].ToString(),
                locale_id = (int)reader["locale_id"],
                multi_login_flag = reader["multi_login_flag"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString(),
                dept_cd = reader["dept_cd"].ToString(),
                user_position_cd = reader["user_position_cd"].ToString(),
            };
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Get user infomation with department and position
        /// </summary>
        /// <param name="dept_code"></param>
        /// <param name="postion_code"></param>
        /// <returns></returns>
        public m_mes_user GetPositionUser(string dept_code, string postion_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = @"SELECT user_cd, user_name, locale_id, multi_login_flag, registration_user_cd, registration_date_time,
                      registrated_factory_cd, dept_cd, user_position_cd FROM m_mes_user ";
            query += "WHERE dept_cd ='" + dept_code + "' and user_position_cd ='" + postion_code + "'";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            reader.Read();
            //Get an item
            m_mes_user outItem = new m_mes_user
            {
                user_cd = reader["user_cd"].ToString(),
                user_name = reader["user_name"].ToString(),
                locale_id = (int)reader["locale_id"],
                multi_login_flag = reader["multi_login_flag"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString(),
                dept_cd = reader["dept_cd"].ToString(),
                user_position_cd = reader["user_position_cd"].ToString(),
            };
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Get list user with department and position
        /// </summary>
        /// <param name="dept_code"></param>
        /// <param name="postion_code"></param>
        public void GetListUser(string dept_code, string postion_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = @"SELECT user_cd, user_name, locale_id, multi_login_flag, registration_user_cd, registration_date_time,
                      registrated_factory_cd, dept_cd, user_position_cd FROM m_mes_user WHERE 1=1 ";
            if (!string.IsNullOrEmpty(dept_code))
                query += "and dept_cd ='" + dept_code + "' ";
            if (!string.IsNullOrEmpty(postion_code))
                query += "and user_position_cd ='" + postion_code + "' ";
            query += "ORDER BY user_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                m_mes_user outItem = new m_mes_user
                {
                    user_cd = reader["user_cd"].ToString(),
                    user_name = reader["user_name"].ToString(),
                    locale_id = (int)reader["locale_id"],
                    multi_login_flag = reader["multi_login_flag"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString(),
                    dept_cd = reader["dept_cd"].ToString(),
                    user_position_cd = reader["user_position_cd"].ToString(),
                };
                listMesUser.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
    }
}
