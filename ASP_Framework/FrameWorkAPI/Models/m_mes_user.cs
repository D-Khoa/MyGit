using System;

namespace FrameWorkAPI.Models
{
    public class m_mes_user
    {
        public int user_id { get; set; }
        public string user_cd { get; set; }
        public string user_name { get; set; }
        public string user_email { get; set; }
        public string user_phone { get; set; }
        public string user_password { get; set; }
        public bool user_is_active { get; set; }
        public bool user_is_online { get; set; }
        public DateTime reg_date { get; set; }
    }
}