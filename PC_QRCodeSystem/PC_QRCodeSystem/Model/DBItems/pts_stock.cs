using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    ///STOCK ITEM IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_stock
    {
        #region ALL FIELDS
        public int stock_id { get; set; }
        public string packing_cd { get; set; }
        public string item_cd { get; set; }
        public string supplier_cd { get; set; }
        public string order_no { get; set; }
        public string invoice { get; set; }
        public DateTime stockin_date { get; set; }
        public string stockin_user_cd { get; set; }
        public double stockin_qty { get; set; }
        public double packing_qty { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_stock> listStockItems;
        public pts_stock()
        {
            listStockItems = new BindingList<pts_stock>();
        }
        #endregion

        #region QUERY
        /// <summary>
        /// Get an stock item
        /// </summary>
        /// <param name="inItem">input info stock item search</param>
        /// <param name="checkDate">check stock in date</param>
        /// <returns></returns>
        public pts_stock GetItem(pts_stock inItem, bool checkDate)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice, stockin_date, stockin_user_cd, ";
            query += "stockin_qty, packing_qty, registration_user_cd, registration_date_time FROM pts_stock WHERE 1=1 ";
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
            pts_stock outItem = new pts_stock
            {
                stock_id = (int)reader["stock_id"],
                packing_cd = reader["packing_cd"].ToString(),
                item_cd = reader["item_cd"].ToString(),
                supplier_cd = reader["supplier_cd"].ToString(),
                order_no = reader["order_no"].ToString(),
                invoice = reader["invoice"].ToString(),
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
        /// <returns></returns>
        public bool SearchItem(pts_stock inItem)
        {
            try
            {
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                listStockItems = new BindingList<pts_stock>();
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = "SELECT stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice, stockin_date, stockin_user_cd, ";
                query += "stockin_qty, packing_qty, registration_user_cd, registration_date_time FROM pts_stock WHERE 1=1 ";
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
                if (!string.IsNullOrEmpty(inItem.stockin_user_cd))
                    query += "AND stockin_user_cd ='" + inItem.stockin_user_cd + "' ";
                query += "ORDER BY stock_id";
                //Execute reader for read database
                IDataReader reader = SQL.Command(query).ExecuteReader();
                while (reader.Read())
                {
                    pts_stock outItem = new pts_stock
                    {
                        stock_id = (int)reader["stock_id"],
                        packing_cd = reader["packing_cd"].ToString(),
                        item_cd = reader["item_cd"].ToString(),
                        supplier_cd = reader["supplier_cd"].ToString(),
                        order_no = reader["order_no"].ToString(),
                        invoice = reader["invoice"].ToString(),
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
        /// Search list stock
        /// </summary>
        /// <param name="inItem">input info stock search</param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="checkDate">check stock in date</param>
        public bool SearchItem(pts_stock inItem, DateTime fromDate, DateTime toDate, bool checkDate)
        {
            try
            {
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                listStockItems = new BindingList<pts_stock>();
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = "SELECT stock_id, packing_cd, item_cd, supplier_cd, order_no, invoice, stockin_date, stockin_user_cd, ";
                query += "stockin_qty, packing_qty, registration_user_cd, registration_date_time FROM pts_stock WHERE 1=1 ";
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
                    pts_stock outItem = new pts_stock
                    {
                        stock_id = (int)reader["stock_id"],
                        packing_cd = reader["packing_cd"].ToString(),
                        item_cd = reader["item_cd"].ToString(),
                        supplier_cd = reader["supplier_cd"].ToString(),
                        order_no = reader["order_no"].ToString(),
                        invoice = reader["invoice"].ToString(),
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
            query = "INSERT INTO pts_stock(packing_cd, item_cd, supplier_cd, order_no, invoice, stockin_date,";
            query += "stockin_user_cd, stockin_qty, packing_qty, registration_user_cd) VALUES ";
            query += "('" + inItem.packing_cd + "','" + inItem.item_cd + "','" + inItem.supplier_cd + "','" + inItem.order_no;
            query += "','" + inItem.invoice + "','" + inItem.stockin_date + "','" + inItem.stockin_user_cd + "','";
            query += inItem.stockin_qty + "','" + inItem.packing_qty + "','" + inItem.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Update stock item
        /// </summary>
        /// <param name="inItem">stock item after change</param>
        /// <returns></returns>
        public int UpdateItem(pts_stock inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_stock SET packing_cd ='" + inItem.packing_cd + "', item_cd ='" + inItem.item_cd + "', supplier_cd ='";
            query += inItem.supplier_cd + "', order_no ='" + inItem.order_no + "', invoice ='" + inItem.invoice;
            query += "', stockin_date ='" + inItem.stockin_date + "', stockin_user_cd ='" + inItem.stockin_user_cd;
            query += "', stockin_qty ='" + inItem.stockin_qty + "', packing_qty ='" + inItem.packing_qty + "', registration_user_cd ='";
            query += inItem.registration_user_cd + "' WHERE stock_id ='" + inItem.stock_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }

        /// <summary>
        /// Delete current stock item
        /// </summary>
        /// <returns></returns>
        public int DeleteItem()
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM pts_stock WHERE stock_id ='" + stock_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }
        #endregion

        #region IN/OUT
        /// <summary>
        /// Export list stock item into CSV file
        /// </summary>
        /// <param name="inList">input list item</param>
        /// <param name="fileName">file path</param>
        public void ExportToCSV(List<pts_stock> inList, string fileName)
        {
            var properties = inList[0].GetType().GetProperties();
            using (StreamWriter sw = new StreamWriter(fileName))
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
        #endregion
    }
}
