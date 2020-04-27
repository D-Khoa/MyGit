using System;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    public class m_user_position
    {
        #region ALL FIELDS OF ITEM
        public int user_position_id { get; set; }
        public string user_position_cd { get; set; }
        public string user_position_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<m_user_position> listUserPosition { get; set; }
        #endregion

        public m_user_position()
        {
            listUserPosition = new BindingList<m_user_position>();
        }

        /// <summary>
        /// Get list user position
        /// </summary>
        /// <param name="position_code">string.emty if get all items</param>
        public void Search(string position_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listUserPosition = new BindingList<m_user_position>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT user_position_id, user_position_cd, user_position_name, registration_user_cd, registration_date_time ";
            query += "FROM m_user_position WHERE 1=1 ";
            if (!string.IsNullOrEmpty(position_code))
                query += "and user_position_cd = '" + position_code + "' ";
            query += "ORDER BY user_position_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                m_user_position outItem = new m_user_position
                {
                    user_position_id = (int)reader["user_position_id"],
                    user_position_cd = reader["user_position_cd"].ToString(),
                    user_position_name = reader["user_position_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listUserPosition.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        /// <summary>
        /// Add an user position
        /// </summary>
        /// <param name="inItem">input user position</param>
        /// <returns></returns>
        public int Add(m_user_position inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO m_user_position(user_position_cd, user_position_name, registration_user_cd) ";
            query += "VALUES('" + inItem.user_position_cd + "','" + inItem.user_position_name + "','";
            query += inItem.registration_user_cd + "') ";
            //Execute non query for add item
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            //Close SQL connection
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Update an user position
        /// </summary>
        /// <param name="inItem">input user position</param>
        /// <returns></returns>
        public int Update(m_user_position inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE m_user_position ";
            query += "SET user_position_cd ='" + inItem.user_position_cd + "', user_position_name ='" + inItem.user_position_name;
            query += "', registration_user_cd ='" + inItem.registration_user_cd + "', registration_date_time = now() ";
            query += "WHERE user_position_id ='" + inItem.user_position_id + "'";
            //Execute non query for add item
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            //Close SQL connection
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Delete an user postition
        /// </summary>
        /// <param name="inItem">input user position</param>
        /// <returns></returns>
        public int Delete(m_user_position inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM m_user_position WHERE user_position_id ='" + inItem.user_position_id + "'";
            //Execute non query for add item
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            //Close SQL connection
            SQL.Close();
            return result;
        }
       
    }
}
