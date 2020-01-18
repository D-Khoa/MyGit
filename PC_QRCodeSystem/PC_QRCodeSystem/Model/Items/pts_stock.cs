using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    ///STOCK ITEM IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_stock
    {
        #region FIELDS OF STOCK ITEM
        public string packing_cd { get; set; }
        public string item_cd { get; set; }
        public string product_cd { get; set; }
        public string order_no { get; set; }
        public string supplier_cd { get; set; }
        public string po_no { get; set; }
        public DateTime received_date { get; set; }
        public string received_user_cd { get; set; }
        public double received_qty { get; set; }
        public double stock_qty { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<pts_stock> listStockItems { get; set; }
        #endregion

        public void GetListStockItem(pts_stock inItem)
        {

        }

    }
}
