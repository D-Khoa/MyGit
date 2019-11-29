using System;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AssetInfoVo : ValueObject
    {
        public string asset_cd { get; set; }
        public int asset_no { get; set; }
        public string asset_name { get; set; }
        public string asset_serial { get; set; }
        public string asset_model { get; set; }
        public double asset_life { get; set; }
        public double acquistion_cost { get; set; }
        public DateTime acquistion_date { get; set; }
        public string asset_invoice { get; set; }
        public string asset_po { get; set; }
        public string asset_type { get; set; }
        public string factory_cd { get; set; }
        public string asset_supplier { get; set; }
        public string label_status { get; set; }
        public List<ValueObject> AssetInfoList = new List<ValueObject>();
    }
}
