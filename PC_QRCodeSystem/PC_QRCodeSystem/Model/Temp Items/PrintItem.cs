using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;

namespace PC_QRCodeSystem.Model
{
    public class PrintItem
    {
        #region ALL FIELDS
        public string Item_Number { get; set; }
        public string Item_Name { get; set; }
        public string SupplierName { get; set; }
        public string Invoice { get; set; }
        public DateTime Delivery_Date { get; set; }
        public double Delivery_Qty { get; set; }
        public string SupplierCD { get; set; }
        //public string OrderNo { get; set; }
        public string Remark { get; set; }
        public int Label_Qty { get; set; }
        public bool isRec { get; set; }
        public BindingList<PrintItem> ListPrintItem;
        public PrintItem()
        {
            ListPrintItem = new BindingList<PrintItem>();
            TfPrint.printerName = SettingItem.printerSName;
        }
        #endregion

        #region PRINTER
        /// <summary>
        /// Check status of printer
        /// </summary>
        /// <param name="printer">Printer name</param>
        /// <returns>TRUE: OFFLINE, FALSE: ONLINE</returns>
        public bool CheckPrinterIsOffline(string printer)
        {
            ManagementObjectSearcher printerSearch = new ManagementObjectSearcher("Select Name, WorkOffline from Win32_Printer");
            var status = printerSearch.Get().OfType<ManagementBaseObject>()
                .Where(x => x["Name"].ToString() == printer).Select(x => x).FirstOrDefault();
            return (Boolean)status["WorkOffline"];
            throw new Exception("Printer is not install");
        }

        /// <summary>
        /// Print pc stock items
        /// </summary>
        /// <param name="listPrintItem"></param>
        /// <param name="printOneCoppy">true: print 1 label</param>
        /// <returns></returns>
        public bool PrintItems(List<PrintItem> listPrintItem, bool printOneCoppy)
        {
            for (int i = 0; i < listPrintItem.Count; i++)
            {
                if (printOneCoppy)
                {
                    TfPrint.printBarCodeNew(listPrintItem[i].Item_Number, listPrintItem[i].Item_Name, listPrintItem[i].SupplierName, listPrintItem[i].Invoice, listPrintItem[i].Delivery_Date.ToString("yyyy/MM/dd"), listPrintItem[i].Delivery_Qty.ToString(), listPrintItem[i].SupplierCD, listPrintItem[i].Remark, listPrintItem[i].isRec);
                }
                else
                {
                    for (int j = 0; j < listPrintItem[i].Label_Qty; j++)
                    {
                        TfPrint.printBarCodeNew(listPrintItem[i].Item_Number, listPrintItem[i].Item_Name, listPrintItem[i].SupplierName, listPrintItem[i].Invoice, listPrintItem[i].Delivery_Date.ToString("yyyy/MM/dd"), listPrintItem[i].Delivery_Qty.ToString(), listPrintItem[i].SupplierCD, listPrintItem[i].Remark, listPrintItem[i].isRec);
                    }
                }
            }
            return true;
        }

        public bool PrintAnItem(PrintItem inItem, bool printOneCoppy)
        {
            if (printOneCoppy)
            {
                TfPrint.printBarCodeNew(inItem.Item_Number, inItem.Item_Name, inItem.SupplierName, inItem.Invoice, inItem.Delivery_Date.ToString("yyyy/MM/dd"), inItem.Delivery_Qty.ToString(), inItem.SupplierCD, inItem.Remark, inItem.isRec);
            }
            else
            {
                for (int j = 0; j < inItem.Label_Qty; j++)
                {
                    TfPrint.printBarCodeNew(inItem.Item_Number, inItem.Item_Name, inItem.SupplierName, inItem.Invoice, inItem.Delivery_Date.ToString("yyyy/MM/dd"), inItem.Delivery_Qty.ToString(), inItem.SupplierCD, inItem.Remark, inItem.isRec);
                }
            }
            return true;
        }
        #endregion
    }
}
