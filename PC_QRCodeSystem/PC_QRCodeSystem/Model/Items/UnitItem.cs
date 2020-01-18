using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public class UnitItem
    {
        public string Item_Number { get; set; }
        public string Item_Name { get; set; }
        public double Unit_Qty { get; set; }
        public string Unit_Type { get; set; }

        public BindingList<UnitItem> GetAllUnitItem()
        {
            BindingList<UnitItem> list = new BindingList<UnitItem>();
            GetData gdata = new GetData();
            gdata.GetAllUnitItem(ref list);
            return list;
        }
    }
}
