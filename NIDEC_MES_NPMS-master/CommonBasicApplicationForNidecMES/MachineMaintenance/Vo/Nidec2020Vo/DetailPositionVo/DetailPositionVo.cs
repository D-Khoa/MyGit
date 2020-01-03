using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class DetailPositionVo : ValueObject
    {
        public int detail_postion_id { get; set; }
        public int location_id { get; set; }
        public string detail_postion_cd { get; set; }
        public string detail_postion_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
    }
}
