using System;
using System.Data;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AssetMaster2019Vo : ValueObject
    {
        public int asset_id { get; set; }
        public string asset_cd { get; set; }
        public int asset_no { get; set; }
        public string asset_name { get; set; }
        public string asset_life { get; set; }
        public string asset_type { get; set; }
        public string label_status { get; set; }
        public DateTime dateFrom { get; set; }
        public bool checkDateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public bool checkDateTo { get; set; }
        public DataTable asset_data { get; set; }
        public int executeInt { get; set; }
    }
}
