using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountCodeVo : ValueObject
    {
        public int account_code_id { get; set; }
        public string account_code_cd { get; set; }
        public string account_code_name { get; set; }
    }
}
