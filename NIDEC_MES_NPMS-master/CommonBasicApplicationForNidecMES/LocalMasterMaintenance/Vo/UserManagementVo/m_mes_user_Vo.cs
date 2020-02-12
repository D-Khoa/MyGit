using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_mes_user_Vo : ValueObject
    {
        public string user_cd { get; set; }
        public string user_name { get; set; }
        public int locale_id { get; set; }
        public string multi_login_flag { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string registrated_factory_cd { get; set; }
        public string dept_cd { get; set; }
        public string user_position_cd { get; set; }
    }
}
