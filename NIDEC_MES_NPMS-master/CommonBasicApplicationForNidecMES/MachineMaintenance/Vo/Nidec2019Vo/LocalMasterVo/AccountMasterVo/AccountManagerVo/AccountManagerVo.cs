using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class AccountManagerVo : ValueObject
    {
        public List<string> list_asset_model { get; set; }
        public List<string> list_asset_type { get; set; }
        public List<string> list_asset_invoice { get; set; }
        public List<string> list_asset_label { get; set; }
        public List<string> list_account_cd { get; set; }
        public List<string> list_account_location { get; set; }
        public List<string> list_location { get; set; }
        public List<string> list_invertory_times { get; set; }
        public List<string> list_rank { get; set; }
        public List<string> list_factory { get; set; }
        public DataTable table { get; set; }
    }
}
