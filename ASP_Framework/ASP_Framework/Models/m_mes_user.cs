using System;
using System.Collections.Generic;
using System.Data;

namespace ASP_Framework.Models
{
    public class m_mes_user
    {
        #region FIELDS
        /// <summary>
        /// ID of user in DB
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// User code in DB
        /// </summary>
        public string user_cd { get; set; }
        /// <summary>
        /// Nam of user
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// Email of user
        /// </summary>
        public string user_email { get; set; }
        /// <summary>
        /// Phone number of user
        /// </summary>
        public string user_phone { get; set; }
        /// <summary>
        /// Password of user
        /// </summary>
        public string user_password { get; set; }
        /// <summary>
        /// Active state of user
        /// </summary>
        public bool user_is_active { get; set; }
        /// <summary>
        /// Online state of user
        /// </summary>
        public bool user_is_online { get; set; }
        /// <summary>
        /// Registrator date of user
        /// </summary>
        public DateTime reg_date { get; set; }
        /// <summary>
        /// Factory of user
        /// </summary>
        public string factory_cd { get; set; }
        /// <summary>
        /// Last login ip address
        /// </summary>
        public string last_ipaddress { get; set; }
        /// <summary>
        /// Last login date
        /// </summary>
        public DateTime last_online { get; set; }
        #endregion

        #region QUERY
        //Create SQL connect
        private readonly MESSQL mESSQL = new MESSQL();
        /// <summary>
        /// Get all users into a collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<m_mes_user> AllUsers()
        {
            string query = "SELECT * FROM [mesdb].[dbo].[m_mes_user]";
            List<m_mes_user> users = new List<m_mes_user>();
            IDbConnection dbConnection = mESSQL.DbContext();
            dbConnection.Open();
            IDbCommand dbCommand = mESSQL.DbCommand(query, dbConnection);
            IDataReader reader = dbCommand.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new m_mes_user
                {
                    user_id = (int)reader["user_id"],
                    user_cd = reader["user_cd"].ToString(),
                    user_name = reader["user_name"].ToString(),
                    user_email = reader["user_email"].ToString(),
                    user_phone = reader["user_phone"].ToString(),
                    user_password = reader["user_password"].ToString(),
                    user_is_active = (bool)reader["user_is_active"],
                    user_is_online = (bool)reader["user_is_online"],
                    reg_date = (DateTime)reader["reg_date"],
                    factory_cd = reader["factory_cd"].ToString(),
                    last_ipaddress = reader["last_ipaddress"].ToString(),
                    last_online = (DateTime)reader["last_online"],
                });
            }
            reader.Close();
            dbConnection.Close();
            return users;
        }
        /// <summary>
        /// Get an user
        /// </summary>
        /// <param name="inInfo">input info condition</param>
        /// <returns></returns>
        public m_mes_user GetUser(m_mes_user inInfo)
        {
            string query = "SELECT * FROM [mesdb].[dbo].[m_mes_user] WHERE 1=1 ";
            if (inInfo.user_id > 0)
            {
                query += "AND user_id ='" + inInfo.user_id + "' ";
            }
            if (!string.IsNullOrEmpty(inInfo.user_cd))
            {
                query += "AND user_cd ='" + inInfo.user_cd + "' ";
            }
            if (!string.IsNullOrEmpty(inInfo.user_email))
            {
                query += "AND user_email ='" + inInfo.user_email + "' ";
            }
            if (!string.IsNullOrEmpty(inInfo.user_phone))
            {
                query += "AND user_phone ='" + inInfo.user_phone + "' ";
            }
            IDbConnection dbConnection = mESSQL.DbContext();
            dbConnection.Open();
            IDbCommand dbCommand = mESSQL.DbCommand(query, dbConnection);
            IDataReader reader = dbCommand.ExecuteReader();
            reader.Read();
            m_mes_user user = new m_mes_user
            {
                user_id = (int)reader["user_id"],
                user_cd = reader["user_cd"].ToString(),
                user_name = reader["user_name"].ToString(),
                user_email = reader["user_email"].ToString(),
                user_phone = reader["user_phone"].ToString(),
                user_password = reader["user_password"].ToString(),
                user_is_active = (bool)reader["user_is_active"],
                user_is_online = (bool)reader["user_is_online"],
                reg_date = (DateTime)reader["reg_date"],
                factory_cd = reader["factory_cd"].ToString(),
                last_ipaddress = reader["last_ipaddress"].ToString(),
                last_online = (DateTime)reader["last_online"],
            };
            reader.Close();
            dbConnection.Close();
            return user;
        }
        /// <summary>
        /// Add new user into DB
        /// </summary>
        /// <param name="inUser">input user info</param>
        /// <returns></returns>
        public int AddUser(m_mes_user inUser)
        {
            inUser.user_password = EncryptDecrypt.Encrypt(inUser.user_password);
            string query = @"USE [mesdb]                             
                             DECLARE @RC int
                             DECLARE @user_cd nvarchar(20)
                             DECLARE @user_name nvarchar(32)
                             DECLARE @user_email nvarchar(32)
                             DECLARE @user_phone nvarchar(12)
                             DECLARE @user_password nvarchar(32)
                             SET @user_cd ='" + inUser.user_cd + "';\n"
                          + "SET @user_name ='" + inUser.user_name + "';\n"
                          + "SET @user_email ='" + inUser.user_email + "';\n"
                          + "SET @user_phone ='" + inUser.user_phone + "';\n"
                          + "SET @user_password ='" + inUser.user_password + "';\n"
                         + @"EXECUTE @RC = [dbo].[AddUser] 
                                @user_cd
                               ,@user_name
                               ,@user_email
                               ,@user_phone
                               ,@user_password";
            IDbConnection dbConnection = mESSQL.DbContext();
            dbConnection.Open();
            IDbCommand dbCommand = mESSQL.DbCommand(query, dbConnection);
            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            return result;
        }
        #endregion
    }
}