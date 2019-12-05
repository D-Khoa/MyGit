using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountLocationVo : ValueObject
    {
        public string account_location_cd { get; set; }
        public string account_location_name { get; set; }
    }
}
