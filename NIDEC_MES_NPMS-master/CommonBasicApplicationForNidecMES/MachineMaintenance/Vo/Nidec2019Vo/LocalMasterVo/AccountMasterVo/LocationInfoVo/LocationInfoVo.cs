using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class LocationInfoVo : ValueObject
    {
        public int location_id { get; set; }
        public string location_cd { get; set; }
        public string location_name { get; set; }
    }
}
