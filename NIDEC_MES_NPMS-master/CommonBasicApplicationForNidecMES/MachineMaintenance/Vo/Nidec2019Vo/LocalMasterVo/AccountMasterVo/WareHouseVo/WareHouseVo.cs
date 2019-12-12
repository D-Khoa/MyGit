using System;
using System.Data;
using Com.Nidec.Mes.Framework;
using System.Collections.Generic;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo
{
    public class WareHouseVo : ValueObject
    {
        public string asset_code { get; set; }
        public string asset_name { get; set; }
        public string asset_model { get; set; }
        public string asset_type { get; set; }
        public string rank { get; set; }
      //  public string list_account_location { get; set; }
        public string invoice { get; set; }
        public string location { get; set; }
        public string label_status { get; set; }
        public string net_value { get; set; }
        public string inventory_times { get; set; }
        public DataTable table { get; set; }
    }
}
