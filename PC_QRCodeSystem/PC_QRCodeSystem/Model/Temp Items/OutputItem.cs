using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public class OutputItem
    {
        #region ALL FIELDS
        public int issue_cd { get; set; }
        public string destination_cd { get; set; }
        public string item_number { get; set; }
        //public string item_name { get; set; }
        //public string supplier_cd { get; set; }
        //public string supplier_name { get; set; }
        //public string supplier_invoice { get; set; }
        public double delivery_qty { get; set; }
        public DateTime delivery_date { get; set; }
        public string order_number { get; set; }
        public string incharge { get; set; }
        public List<OutputItem> listOutputItem;
        public OutputItem()
        {
            listOutputItem = new List<OutputItem>();
        }
        #endregion

        public void ExportCSV(List<OutputItem> inList)
        {
            var properties = inList[0].GetType().GetProperties();
            string filename = @"\stockout_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            using (StreamWriter sw = new StreamWriter(SettingItem.outputFolder + filename))
            {
                string line = string.Empty;
                //Write columns
                line = string.Join("?", properties.Select(x => x.Name));
                sw.WriteLine(line);
                for (int i = 0; i < inList.Count; i++)
                {
                    var propretiesValue = inList[i].GetType().GetProperties();
                    line = string.Join("?", propretiesValue.Select(x => x.GetValue(inList[i], null)));
                    sw.WriteLine(line);
                }
                sw.Flush();
                sw.Close();
            }
        }
    }
}
