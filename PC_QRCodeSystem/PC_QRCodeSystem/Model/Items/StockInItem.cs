using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace PC_QRCodeSystem.Model
{
    public class StockInItem
    {
        #region INFOMATIONS OF STOCK IN ITEMS
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
        #endregion

        /// <summary>
        /// Cut lot from PREMAC items and create STOCK IN items
        /// </summary>
        /// <param name="listpreitem"></param>
        /// <returns></returns>
        public BindingList<StockInItem> GetStockInItem(List<PremacIn> listpreitem)
        {
            BindingList<StockInItem> list = new BindingList<StockInItem>();
            GetData gData = new GetData();
            double qtymod = 0;
            double unit = 1;
            int qty = 1;
            //Get PREMAC item from PREMAC items list
            foreach (PremacIn item in listpreitem)
            {
                //Get qty per unit of PREMAC item
                unit = gData.GetUnitQty(item.Item_Number);
                //If unit qty = 0 then no cut lot
                if (unit == 0) unit = item.Delivery_Qty;
                //Qty of packing = lot in / qty of unit
                qty = (int)(item.Delivery_Qty / unit);
                //Add STOCK IN item into list
                for (int i = 0; i < qty; i++)
                {
                    list.Add(new StockInItem
                    {
                        Packing_Code = item.PO_No + "-" + i.ToString(),
                        Item_Number = item.Item_Number,
                        Item_Name = item.Item_Name,
                        Supplier_Name = item.Supplier_Name,
                        Supplier_Invoice = item.Supplier_Invoice,
                        PO_No = item.PO_No,
                        Delivery_Qty = unit,
                        StockIn_Date = item.Delivery_Date,
                        Stock_Qty = unit,
                        Incharge = UserData.username,
                        Registrator_Date = DateTime.Now,
                    });
                }
                //If have a packing with qty < qty of unit
                if (qty * unit < item.Delivery_Qty)
                {
                    qtymod = item.Delivery_Qty - (qty * unit);
                    list.Add(new StockInItem
                    {
                        Packing_Code = item.PO_No + "-" + qty.ToString(),
                        Item_Number = item.Item_Number,
                        Item_Name = item.Item_Name,
                        Supplier_Name = item.Supplier_Name,
                        Supplier_Invoice = item.Supplier_Invoice,
                        PO_No = item.PO_No,
                        Delivery_Qty = qtymod,
                        StockIn_Date = item.Delivery_Date,
                        Stock_Qty = qtymod,
                        Incharge = UserData.username,
                        Registrator_Date = DateTime.Now,
                    });
                }
            }
            return list;
        }

        /// <summary>
        /// Cut lot with a custom qty
        /// </summary>
        /// <param name="preitem"></param>
        /// <param name="unit_qty"></param>
        /// <returns></returns>
        public BindingList<StockInItem> GetPackingItem(PremacIn preitem, double unit_qty)
        {
            BindingList<StockInItem> list = new BindingList<StockInItem>();
            GetData gData = new GetData();
            double qtymod = 0;
            double unit = 1;
            int qty = 1;
            //Get qty per unit of PREMAC item
            if (unit_qty <= 0)
                unit = gData.GetUnitQty(preitem.Item_Number);
            else
                unit = unit_qty;
            //If unit qty = 0 then no cut lot
            if (unit == 0) unit = preitem.Delivery_Qty;
            //Qty of packing = lot in / qty of unit
            qty = (int)(preitem.Delivery_Qty / unit);
            //Add STOCK IN item into list
            for (int i = 0; i < qty; i++)
            {
                list.Add(new StockInItem
                {
                    Packing_Code = preitem.PO_No + "-" + i.ToString(),
                    Item_Number = preitem.Item_Number,
                    Item_Name = preitem.Item_Name,
                    Supplier_Name = preitem.Supplier_Name,
                    Supplier_Invoice = preitem.Supplier_Invoice,
                    PO_No = preitem.PO_No,
                    Delivery_Qty = unit,
                    StockIn_Date = preitem.Delivery_Date,
                    Stock_Qty = unit,
                    Incharge = UserData.username,
                    Registrator_Date = DateTime.Now,
                });
            }
            //If have a packing with qty < qty of unit
            if (qty * unit < preitem.Delivery_Qty)
            {
                qtymod = preitem.Delivery_Qty - (qty * unit);
                list.Add(new StockInItem
                {
                    Packing_Code = preitem.PO_No + "-" + qty.ToString(),
                    Item_Number = preitem.Item_Number,
                    Item_Name = preitem.Item_Name,
                    Supplier_Name = preitem.Supplier_Name,
                    Supplier_Invoice = preitem.Supplier_Invoice,
                    PO_No = preitem.PO_No,
                    Delivery_Qty = qtymod,
                    StockIn_Date = preitem.Delivery_Date,
                    Stock_Qty = qtymod,
                    Incharge = UserData.username,
                    Registrator_Date = DateTime.Now,
                });
            }
            return list;
        }
    }
}
