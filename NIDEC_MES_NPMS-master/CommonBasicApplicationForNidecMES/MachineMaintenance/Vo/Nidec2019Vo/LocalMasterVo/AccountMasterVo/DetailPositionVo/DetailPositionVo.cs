using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class DetailPositionVo : ValueObject
    {
        public int detail_postion_id { get; set; }
        public string detail_postion_cd { get; set; }
        public string detail_postion_name { get; set; }
    }
}
