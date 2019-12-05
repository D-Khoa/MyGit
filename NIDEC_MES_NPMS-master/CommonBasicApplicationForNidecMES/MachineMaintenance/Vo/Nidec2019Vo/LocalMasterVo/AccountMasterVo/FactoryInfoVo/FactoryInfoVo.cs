using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class FactoryInfoVo : ValueObject
    {
        public string factory_cd { get; set; }
        public string factory_name { get; set; }
    }
}
