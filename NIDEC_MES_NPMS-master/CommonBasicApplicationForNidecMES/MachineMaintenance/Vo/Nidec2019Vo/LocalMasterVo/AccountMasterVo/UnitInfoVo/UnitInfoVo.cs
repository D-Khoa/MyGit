using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class UnitInfoVo : ValueObject
    {
        public int unit_id { get; set; }
        public string unit_cd { get; set; }
        public string unit_name { get; set; }
    }
}
