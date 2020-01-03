using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class AccountWHVo : ValueObject
    {
        public int warehouse_main_id { get; set; }
        public int asset_id { get; set; }
        public int qty { get; set; }
        public int unit_id { get; set; }
        public int account_code_id { get; set; }
        public int account_location_id { get; set; }
        public int rank_id { get; set; }
        public string comment_data { get; set; }
        public DateTime depreciation_start { get; set; }
        public DateTime depreciation_end { get; set; }
        public double current_depreciation { get; set; }
        public double monthly_depreciation { get; set; }
        public double accum_depreciation_now { get; set; }
        public double net_value { get; set; }
        public int before_location_id { get; set; }
        public int after_location_id { get; set; }
        public int user_location_id { get; set; }
        public int detail_position_id { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
        public int inventory_time_id { get; set; }
    }
}
