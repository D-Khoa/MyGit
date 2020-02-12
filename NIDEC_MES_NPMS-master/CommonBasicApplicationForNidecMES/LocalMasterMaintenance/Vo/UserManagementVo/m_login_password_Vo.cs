using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_login_password_Vo : ValueObject
    {
        public string user_cd { get; set; }
        public string password { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public bool is_online { get; set; }
        public DateTime last_login_time { get; set; }
    }
}
