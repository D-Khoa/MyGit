using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class AccountLocationVo : ValueObject
    {
        public int account_location_id { get; set; }
        public string account_location_cd { get; set; }
        public string account_location_name { get; set; }
        public string account_location_type { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
    }
}
