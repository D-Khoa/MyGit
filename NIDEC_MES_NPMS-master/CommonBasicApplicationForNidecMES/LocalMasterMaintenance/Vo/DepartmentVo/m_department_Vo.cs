using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_department_Vo : ValueObject
    {
        public int dept_id { get; set; }
        public string dept_cd { get; set; }
        public string dept_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
    }
}
