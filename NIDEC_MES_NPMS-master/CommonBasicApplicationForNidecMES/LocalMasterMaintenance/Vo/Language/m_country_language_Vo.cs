using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.LocalMasterMaintenance.Vo
{
    public class m_country_language_Vo : ValueObject
    {
        public int locale_id { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
    }
}
