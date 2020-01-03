using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class UserLocationVo : ValueObject
    {
        public int user_location_id { get; set; }
        public string user_location_cd { get; set; }
        public string user_location_name { get; set; }
        public string dept_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
    }
}
