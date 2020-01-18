using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public class pts_stockout_log
    {
        public int stockout_log_id { get; set; }
        public string packing_cd { get; set; }
        public DateTime use_date { get; set; }
        public DateTime stockout_date { get; set; }
        public double stockout_qty { get; set; }
        public string stockout_user_cd { get; set; }
        public string sign_cd { get; set; }
        public string confirm_user_cd { get; set; }
        public string comment { get; set; }
        public string log_reg_date { get; set; }

    }
}
