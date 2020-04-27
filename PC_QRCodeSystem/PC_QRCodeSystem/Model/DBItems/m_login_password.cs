using System;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    public class m_login_password
    {
        #region ALL FIELDS
        public string user_cd { get; set; }
        public string password { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public DateTime last_login_time { get; set; }
        public bool is_online { get; set; }
        #endregion

        #region QUERY
        /// <summary>
        /// Check user and password
        /// </summary>
        /// <param name="usercd">user code</param>
        /// <param name="pass">password</param>
        /// <returns></returns>
        public m_login_password CheckLogIn(string usercd, string pass)
        {
            try
            {
                EncryptDecrypt endecrypt = new EncryptDecrypt();
                pass = endecrypt.Encrypt(pass);
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = @"SELECT user_cd, registration_user_cd, registration_date_time, factory_cd, last_login_time, is_online ";
                query += "FROM m_login_password WHERE user_cd ='" + usercd + "' and password ='" + pass + "'";
                IDataReader reader;
                //Execute reader for read database
                reader = SQL.Command(query).ExecuteReader();
                query = string.Empty;
                reader.Read();
                //Get an item
                m_login_password outItem = new m_login_password
                {
                    user_cd = reader["user_cd"].ToString(),
                    factory_cd = reader["factory_cd"].ToString(),
                    is_online = (bool)reader["is_online"],
                    last_login_time = (DateTime)reader["last_login_time"],
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString(),
                };
                reader.Close();
                //Close SQL connection
                SQL.Close();
                return outItem;
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Wrong user or password!" + Environment.NewLine + "Please Log In again!");
            }
        }

        /// <summary>
        /// Log In and Log Out
        /// </summary>
        /// <param name="usercd">User code</param>
        /// <param name="isLogin">true: log in, false: log out</param>
        public bool LogIO(string usercd, bool isLogin)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = @"UPDATE m_login_password SET ";
            if (isLogin)
                query += "last_login_time='" + DateTime.Now + "', is_online = '1' ";
            else
                query += "is_online ='0' ";
            query += "WHERE user_cd ='" + usercd + "'";
            //Execute query
            int result = SQL.Command(query).ExecuteNonQuery();
            //Close SQL connection
            SQL.Close();
            if (result > 0) return isLogin;
            else return !isLogin;
        }

        public bool CheckOnline(string usercd)
        {
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT is_online FROM m_login_password WHERE user_cd ='" + usercd + "'";
            //Exectute scalar
            bool result = (bool)SQL.Command(query).ExecuteScalar();
            query = string.Empty;
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Change password of user
        /// </summary>
        /// <param name="inItem">input new info of user</param>
        /// <returns></returns>
        public bool ChangePassword(m_login_password inItem)
        {
            EncryptDecrypt endecrypt = new EncryptDecrypt();
            string pass = endecrypt.Encrypt(inItem.password);
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE m_login_password SET password ='" + pass + "' WHERE user_cd ='" + inItem.user_cd + "' ";
            //Execute non query
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            if (result > 0) return true;
            else return false;
        }
        #endregion
    }
}
