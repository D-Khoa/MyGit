using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;
using System.Text;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountManagerVo : ValueObject
    {
        public string list_asset_model { get; set; }
        public string list_asset_type { get; set; }
        public string list_asset_invoice { get; set; }
        public string list_asset_label { get; set; }
        public string list_account_cd { get; set; }
        public string list_account_location { get; set; }
        public string list_location { get; set; }
        public string list_invertory_times { get; set; }
        public string list_rank { get; set; }
        public string list_factory { get; set; }
        public string list_unit { get; set; }
        public string asset_cd { get; set; }
        public string asset_name { get; set; }
        public bool value_expired { get; set; }
        public bool value_valid { get; set; }
        public DataTable table { get; set; }
    }
}
