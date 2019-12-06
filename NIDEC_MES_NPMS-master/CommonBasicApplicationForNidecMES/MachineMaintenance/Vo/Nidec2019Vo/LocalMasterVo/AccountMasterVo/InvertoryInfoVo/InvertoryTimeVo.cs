using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class InvertoryTimeVo : ValueObject
    {
        public int invertory_time_id { get; set; }
        public string invertory_time_name { get; set; }
        public int invertory_time_last { get; set; }
    }
}
