using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ASP_Framework.Models;
using System.Configuration;
using System.Data;
using System.Reflection;

namespace ASP_Framework.Controllers.Api
{
    public class MesUserController : ApiController
    {
        public MesUserController()
        {

        }

        private readonly MESSQL mESSQL = new MESSQL();
        // GET: All user
        public IHttpActionResult Get()
        {
            string query = "SELECT * FROM [mesdb].[dbo].[m_mes_user]";
            IList<m_mes_user> users = new List<m_mes_user>();
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
                });
            }
            reader.Close();
            dbConnection.Close();
            if (users.Count == 0) return NotFound();
            return Ok(users);
        }

        //POST: Add user
        public IHttpActionResult AddUser(m_mes_user inUser)
        {
            if (!ModelState.IsValid) return BadRequest("Not a vaild model");
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
            if (result > 0) return Ok();
            else return BadRequest("Can't add this user!");
        }
    }
}