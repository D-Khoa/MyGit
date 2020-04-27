using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// ISSUE CODE I/O IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_issue_code
    {
        #region FIELDS OF ISSUE CODE
        public int issue_cd { get; set; }
        public string issue_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<pts_issue_code> listIssueCode { get; set; }
        public pts_issue_code()
        {
            listIssueCode = new List<pts_issue_code>();
        }
        #endregion

        /// <summary>
        /// Get infomation of an issue code
        /// </summary>
        /// <param name="issue_code">issue code need get infomation</param>
        public pts_issue_code GetIssueCode(int issue_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_issue_code where 1=1 ";
            query += "and issue_cd = '" + issue_code + "' ";
            query += "order by issue_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            //Get an item
            reader.Read();
            pts_issue_code outItem = new pts_issue_code
            {
                issue_cd = (int)reader["issue_cd"],
                issue_name = reader["issue_name"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString()
            };
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Get list all issue code
        /// </summary>
        public void GetListIssueCode()
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listIssueCode = new List<pts_issue_code>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_issue_code where 1=1 ";
            query += "order by issue_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_issue_code outItem = new pts_issue_code
                {
                    issue_cd = (int)reader["issue_cd"],
                    issue_name = reader["issue_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listIssueCode.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        public int AddIssueCode(pts_issue_code addptsissuecd)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_issue_code(issue_cd, issue_name, registration_user_cd)";
            query += "VALUES ('" + addptsissuecd.issue_cd + "','" + addptsissuecd.issue_name + "','";
            query += addptsissuecd.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        public int UpdateIssueCode(pts_issue_code UpdateIssueCd)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_issue_code SET issue_cd='" + UpdateIssueCd.issue_cd + "', issue_name='" + UpdateIssueCd.issue_name + "',registration_user_cd ='" + UpdateIssueCd.registration_user_cd;
            query += "', registration_date_time = now() where issue_cd ='" + UpdateIssueCd.issue_cd + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        public int Delete(int issue)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM pts_issue_code WHERE issue_cd ='" + issue + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;

        }
    }
}
