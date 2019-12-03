using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountInfoVo : ValueObject
    {
        public string asset_Cd { get; set; }
        public int asset_no { get; set; }
        public string asset_name { get; set; }
        public string asset_model { get; set; }
        public string asset_serial { get; set; }
        public string asset_supplier { get; set; }
        public string asset_type { get; set; }
        public int account_Qty { get; set; }
        public string unit_cd { get; set; }
        public string rank_cd { get; set; }
        public string account_Cd { get; set; }
        public string account_location_cd { get; set; }
        public string comment_data { get; set; }
        public double asset_life { get; set; }
        public DateTime acquisition { get; set; }
        public DateTime depreciation_start { get; set; }
        public DateTime depreciation_end { get; set; }
        public double acquisition_cost { get; set; }
        public double monthly_depreciation { get; set; }
        public double current_depreciation { get; set; }
        public double accum_depreciation { get; set; }
        public double net_value { get; set; }
        public string asset_invoice { get; set; }
        public string invertory_time { get; set; }
        public string location_cd { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public string label_status { get; set; }
    }
}
