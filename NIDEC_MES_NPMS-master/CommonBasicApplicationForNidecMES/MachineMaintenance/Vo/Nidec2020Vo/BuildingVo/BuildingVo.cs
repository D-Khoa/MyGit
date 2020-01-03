using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class BuildingVo : ValueObject
    {
        public int building_id { get; set; }
        public string building_cd { get; set; }
        public string building_name { get; set; }
        public string factory_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
    }
}
