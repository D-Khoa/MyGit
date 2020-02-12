using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_authority_control_Vo : ValueObject
    {
        public string authority_control_cd { get; set; }
        public string authority_control_name { get; set; }
        public string parent_control_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }

    }
}
