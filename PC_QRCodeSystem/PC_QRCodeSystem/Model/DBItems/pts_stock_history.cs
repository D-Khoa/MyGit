using System;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    ///STOCK ITEM IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_stock_history
    {
        #region ALL FIELDS
        public int stock_history_id { get; set; }
        public int stock_id { get; set; }
        public string packing_cd { get; set; }
        public string item_cd { get; set; }
        public string supplier_cd { get; set; }
        public string order_no { get; set; }
        public string invoice { get; set; }
        public string po_no { get; set; }
        public DateTime stockin_date { get; set; }
        public string stockin_user_cd { get; set; }
        public double stockin_qty { get; set; }
        public double packing_qty { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_stock_history> listStockItems { get; set; }
        public pts_stock_history()
        {
            listStockItems = new BindingList<pts_stock_history>();
        }
        #endregion

        #region QUERY
        /// <summary>
        /// Get an stock item
        /// </summary>
        /// <param name="inItem">input info stock item search</param>
        /// <param name="checkDate">check stock in date</param>
        /// <returns></returns>
        public pts_stock_history GetItem(pts_stock_history inItem, bool checkDate)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT stock_history_id, stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice,po_no, stockin_date, ";
            query += "stockin_user_cd, stockin_qty, packing_qty, registration_user_cd, registration_date_time FROM pts_stock_history ";
            query += "WHERE 1=1 ";
            if (!string.IsNullOrEmpty(inItem.packing_cd))
                query += "AND packing_cd ='" + inItem.packing_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.item_cd))
                query += "AND item_cd ='" + inItem.item_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.supplier_cd))
                query += "AND supplier_cd ='" + inItem.supplier_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.order_no))
                query += "AND order_no ='" + inItem.order_no + "' ";
            if (!string.IsNullOrEmpty(inItem.invoice))
                query += "AND invoice ='" + inItem.invoice + "' ";
            if (!string.IsNullOrEmpty(inItem.po_no))
                query += "AND po_no ='" + inItem.po_no + "' ";
            if (checkDate)
            {
                query += "AND stockin_date = '" + inItem.stockin_date.ToString("yyyy-MM-dd") + "' ";
            }
            if (!string.IsNullOrEmpty(inItem.stockin_user_cd))
                query += "AND stockin_user_cd ='" + inItem.stockin_user_cd + "' ";
            query += "ORDER BY stock_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            reader.Read();
            pts_stock_history outItem = new pts_stock_history
            {
                stock_history_id = (int)reader["stock_history_id"],
                stock_id = (int)reader["stock_id"],
                packing_cd = reader["packing_cd"].ToString(),
                item_cd = reader["item_cd"].ToString(),
                supplier_cd = reader["supplier_cd"].ToString(),
                order_no = reader["order_no"].ToString(),
                invoice = reader["invoice"].ToString(),
                po_no = reader["po_no"].ToString(),
                stockin_date = (DateTime)reader["stockin_date"],
                stockin_user_cd = reader["stockin_user_cd"].ToString(),
                stockin_qty = (double)reader["stockin_qty"],
                packing_qty = (double)reader["packing_qty"],
                registration_user_cd = reader["registration_user_cd"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
            };
            reader.Close();
            query = string.Empty;
            //Close connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Search list stock
        /// </summary>
        /// <param name="inItem">input info stock search</param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="checkDate">check stock in date</param>
        public bool SearchItem(pts_stock_history inItem, DateTime fromDate, DateTime toDate, bool checkDate)
        {
            try
            {
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                listStockItems = new BindingList<pts_stock_history>();
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = "SELECT stock_history_id, stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice,po_no, stockin_date, ";
                query += "stockin_user_cd, stockin_qty, packing_qty, registration_user_cd, registration_date_time FROM pts_stock_history ";
                query += "WHERE 1=1 ";
                if (!string.IsNullOrEmpty(inItem.packing_cd))
                    query += "AND packing_cd ='" + inItem.packing_cd + "' ";
                if (!string.IsNullOrEmpty(inItem.item_cd))
                    query += "AND item_cd ='" + inItem.item_cd + "' ";
                if (!string.IsNullOrEmpty(inItem.supplier_cd))
                    query += "AND supplier_cd ='" + inItem.supplier_cd + "' ";
                if (!string.IsNullOrEmpty(inItem.order_no))
                    query += "AND order_no ='" + inItem.order_no + "' ";
                if (!string.IsNullOrEmpty(inItem.invoice))
                    query += "AND invoice ='" + inItem.invoice + "' ";
                if (!string.IsNullOrEmpty(inItem.po_no))
                    query += "AND po_no ='" + inItem.po_no + "' ";
                if (checkDate)
                {
                    query += "AND stockin_date >= '" + fromDate.ToString("yyyy-MM-dd") + "' ";
                    query += "AND stockin_date <= '" + toDate.ToString("yyyy-MM-dd") + "' ";
                }
                if (!string.IsNullOrEmpty(inItem.stockin_user_cd))
                    query += "AND stockin_user_cd ='" + inItem.stockin_user_cd + "' ";
                query += "ORDER BY stock_id";
                //Execute reader for read database
                IDataReader reader = SQL.Command(query).ExecuteReader();
                while (reader.Read())
                {
                    pts_stock_history outItem = new pts_stock_history
                    {
                        stock_history_id = (int)reader["stock_history_id"],
                        stock_id = (int)reader["stock_id"],
                        packing_cd = reader["packing_cd"].ToString(),
                        item_cd = reader["item_cd"].ToString(),
                        supplier_cd = reader["supplier_cd"].ToString(),
                        order_no = reader["order_no"].ToString(),
                        invoice = reader["invoice"].ToString(),
                        po_no = reader["po_no"].ToString(),
                        stockin_date = (DateTime)reader["stockin_date"],
                        stockin_user_cd = reader["stockin_user_cd"].ToString(),
                        stockin_qty = (double)reader["stockin_qty"],
                        packing_qty = (double)reader["packing_qty"],
                        registration_user_cd = reader["registration_user_cd"].ToString(),
                        registration_date_time = (DateTime)reader["registration_date_time"],
                    };
                    listStockItems.Add(outItem);
                }
                reader.Close();
                query = string.Empty;
                //Close connection
                SQL.Close();
                if (listStockItems.Count > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Add new stock item
        /// </summary>
        /// <param name="inItem">input stock item</param>
        /// <returns></returns>
        public int AddItem(pts_stock inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_stock_history(stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice, po_no, stockin_date,";
            query += "stockin_user_cd, stockin_qty, packing_qty, registration_user_cd) VALUES ";
            query += "('" + inItem.packing_cd + "','" + inItem.item_cd + "','" + inItem.supplier_cd + "','" + inItem.order_no;
            query += "','" + inItem.invoice + "','" + inItem.po_no + "','" + inItem.stockin_date + "','" + inItem.stockin_user_cd;
            query += "','" + inItem.stockin_qty + "','" + inItem.packing_qty + "','" + inItem.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Sum stock qty
        /// </summary>
        /// <param name="inItem">input info stock for search</param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="checkDate">check date stockin for search</param>
        /// <param name="isStockIn">true: stock in qty, false: packing qty</param>
        /// <returns></returns>
        public double SumStockQty(pts_stock inItem, DateTime fromDate, DateTime toDate, bool checkDate, bool isStockIn)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            if (isStockIn)
                query = "SELECT SUM(stockin_qty) FROM pts_stock WHERE 1=1 ";
            else
                query = "SELECT SUM(packing_qty) FROM pts_stock WHERE 1=1 ";
            if (!string.IsNullOrEmpty(inItem.packing_cd))
                query += "AND packing_cd ='" + inItem.packing_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.item_cd))
                query += "AND item_cd ='" + inItem.item_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.supplier_cd))
                query += "AND supplier_cd ='" + inItem.supplier_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.order_no))
                query += "AND order_no ='" + inItem.order_no + "' ";
            if (!string.IsNullOrEmpty(inItem.invoice))
                query += "AND invoice ='" + inItem.invoice + "' ";
            if (!string.IsNullOrEmpty(inItem.po_no))
                query += "AND po_no ='" + inItem.po_no + "' ";
            if (checkDate)
            {
                query += "AND stockin_date >= '" + fromDate.ToString("yyyy-MM-dd") + "' ";
                query += "AND stockin_date <= '" + toDate.ToString("yyyy-MM-dd") + "' ";
            }
            if (!string.IsNullOrEmpty(inItem.stockin_user_cd))
                query += "AND stockin_user_cd ='" + inItem.stockin_user_cd + "' ";
            //Execute non query for read database
            double result = (double)SQL.Command(query).ExecuteScalar();
            query = string.Empty;
            SQL.Close();
            return result;
        }
        #endregion
    }
}
