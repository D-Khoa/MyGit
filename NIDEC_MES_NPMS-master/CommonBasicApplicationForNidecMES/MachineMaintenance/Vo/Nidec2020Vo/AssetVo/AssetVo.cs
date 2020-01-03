using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class AssetVo : ValueObject
    {
        public int asset_id { get; set; }
        public string asset_no { get; set; }
        public string asset_cd { get; set; }
        public string asset_name { get; set; }
        public string asset_model { get; set; }
        public string asset_serial { get; set; }
        public string asset_supplier { get; set; }
        public string asset_invoice { get; set; }
        public int asset_life { get; set; }
        public DateTime acquistion_date { get; set; }
        public double acquistion_cost { get; set; }
        public string asset_type { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public string label_status { get; set; }
        public string asset_po { get; set; }
    }
}
