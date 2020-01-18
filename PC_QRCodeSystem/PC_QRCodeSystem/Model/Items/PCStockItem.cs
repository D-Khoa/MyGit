using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public class PCStockItem
    {
        #region INFOMATIONS OF STOCK IN ITEMS
        public int Packing_ID { get; set; }
        public string Packing_Code { get; set; }
        public string Item_Number { get; set; }
        public string Item_Name { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Invoice { get; set; }
        public string PO_No { get; set; }
        public double Delivery_Qty { get; set; }
        public DateTime StockIn_Date { get; set; }
        public double Stock_Qty { get; set; }
        public string Incharge { get; set; }
        public DateTime Registrator_Date { get; set; }
        public bool CheckDateFrom { get; set; }
        public bool CheckDateTo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        #endregion


    }
}
