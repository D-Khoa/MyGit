using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model.Temp_Items
{
    /// <summary>
    /// INPUT/OUTPUT MANAGEMENT
    /// </summary>
    public class pre661
    {
        string item_number { get; set; }
        DateTime delivery_date { get; set; }
        string process_cd { get; set; }
        string destination_cd { get; set; }
        string incharge { get; set; }
        int issue_cd { get; set; }
        double stockin_qty { get; set; }
        double stockout_qty { get; set; }
        double stock_qty { get; set; }
    }
}
