using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PC_QRCodeSystem.Model
{
    public class PremacIn
    {
        //public int packing_id { get; set; }
        //public string packing_cd { get; set; }
        public string Item_Number { get; set; }
        public string Item_Name { get; set; }
        //public double unit_qty { get; set; }
        //public int unit_cd { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Invoice { get; set; }
        public string PO_No { get; set; }
        public double Delivery_Qty { get; set; }
        //public DateTime stock_out_date { get; set; }
        public DateTime Delivery_Date { get; set; }
        //public double stock_qty { get; set; }
        public string Incharge { get; set; }
        //public DateTime Registrator_Date { get; set; }

        /// <summary>
        /// Get infomations of item into list item from file Premac
        /// </summary>
        /// <param name="premacfile"></param>
        /// <returns></returns>
        public List<PremacIn> GetItemFromPremacFile(string premacfile)
        {
            List<PremacIn> listitem = new List<PremacIn>();
            foreach (string line in File.ReadLines(premacfile))
            {
                if (line.Contains("(CPFXE049)") || line.Contains("SupplierCD"))
                    continue;
                string[] columns = line.Split('?');
                listitem.Add(new PremacIn
                {
                    Item_Number = columns[2].Trim(),
                    Item_Name = columns[3].Trim(),
                    PO_No = columns[4].Trim(),
                    Supplier_Name = columns[1].Trim(),
                    Supplier_Invoice = columns[29].Trim(),
                    Delivery_Date = DateTime.Parse(columns[9].Trim()),
                    Delivery_Qty = double.Parse(columns[10].Trim()),
                    Incharge = columns[15].Trim(),
                });
            }
            listitem.Sort((a, b) => a.Item_Number.CompareTo(b.Item_Number));
            return listitem;
        }
    }
}
