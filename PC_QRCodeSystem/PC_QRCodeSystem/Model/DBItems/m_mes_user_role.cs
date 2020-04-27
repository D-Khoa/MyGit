using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public class m_mes_user_role
    {
        public int user_role_id { get; set; }
        public string user_cd { get; set; }
        public string role_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public List<m_mes_user_role> listMesUserRole { get; set; }

        public m_mes_user_role()
        {
            listMesUserRole = new List<m_mes_user_role>();
        }

        /// <summary>
        /// Get list role of user
        /// </summary>
        /// <param name="usercode">User code</param>
        /// <returns></returns>
        public List<string> GetListRole(string usercode)
        {
            List<string> list = new List<string>();
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT distinct role_cd FROM m_mes_user_role WHERE user_cd ='" + usercode + "' ORDER BY role_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader["role_cd"].ToString());
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return list;
        }
    }
}
