using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountInfoVo : ValueObject
    {
        public int account_main_id { get; set; }

        #region ASSET
        public int asset_id { get; set; }
        public string asset_cd { get; set; }
        public int asset_no { get; set; }
        public string asset_name { get; set; }
        public string asset_model { get; set; }
        public string asset_serial { get; set; }
        public string asset_supplier { get; set; }
        public string asset_type { get; set; }
        public string asset_invoice { get; set; }
        public string label_status { get; set; }
        public DateTime acquisition_date { get; set; }
        public double acquisition_cost { get; set; }
        public double asset_life { get; set; }
        #endregion

        #region RANK
        public int rank_id { get; set; }
        public string rank_name { get; set; }
        #endregion

        #region ACCOUNT CODE
        public int account_code_id { get; set; }
        public string account_code_name { get; set; }
        #endregion

        #region UNIT
        public int unit_id { get; set; }
        public string unit_name { get; set; }
        #endregion

        #region ACCOUNT
        public int qty { get; set; }
        public DateTime depreciation_start { get; set; }
        public DateTime depreciation_end { get; set; }
        public double monthly_depreciation { get; set; }
        public double current_depreciation { get; set; }
        public double accum_depreciation { get; set; }
        public double net_value { get; set; }
        public string comment_data { get; set; }
        #endregion

        #region INVENTORY
        public int invertory_time_id { get; set; }
        #endregion

        #region USER
        public int user_location_id { get; set; }
        public string user_location_cd { get; set; }
        public string user_location_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        #endregion

        #region LOCATION
        public int account_location_id { get; set; }
        public string account_location_name { get; set; }
        public int location_id { get; set; }
        public string factory_cd { get; set; }
        #endregion

        public int update { get; set; }
    }
}
