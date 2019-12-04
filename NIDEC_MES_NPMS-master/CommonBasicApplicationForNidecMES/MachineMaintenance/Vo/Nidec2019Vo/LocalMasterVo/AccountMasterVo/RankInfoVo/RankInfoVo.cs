using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class RankInfoVo : ValueObject
    {
        public string rank_cd { get; set; }
        public string rank_name { get; set; }
    }
}
