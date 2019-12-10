using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    class UserLocationVo : ValueObject
    {
        public int user_location_id { get; set; }
        public string user_location_cd { get; set; }
        public string user_location_name { get; set; }
    }
}
