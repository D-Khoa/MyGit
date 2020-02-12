using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_user_position_Vo : ValueObject
    {
        public int user_position_id { get; set; }
        public string user_position_cd { get; set; }
        public string user_position_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
    }
}
