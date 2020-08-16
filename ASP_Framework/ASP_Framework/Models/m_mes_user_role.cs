using System;

namespace ASP_Framework.Models
{
    public class m_mes_user_role
    {
        public int user_role_id { get; set; }
        public string user_cd { get; set; }
        public string role_cd { get; set; }
        public string reg_user { get; set; }
        public DateTime reg_date { get; set; }
    }
}