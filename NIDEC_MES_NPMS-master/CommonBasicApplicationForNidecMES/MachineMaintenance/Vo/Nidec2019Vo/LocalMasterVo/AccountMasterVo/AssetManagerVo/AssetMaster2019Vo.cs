using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using System.Data;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AssetMaster2019Vo : ValueObject
    {
        public string asset_cd { get; set; }
        public string asset_name { get; set; }
        public string asset_life { get; set; }
        public string asset_type { get; set; }
        public DateTime dateFrom { get; set; }
        public bool checkDateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public bool checkDateTo { get; set; }
        public DataTable asset_data { get; set; }
    }
}
