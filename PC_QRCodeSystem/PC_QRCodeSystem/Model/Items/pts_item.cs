using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// ITEM IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_item
    {
        #region FIELDS OF ITEM
        public int item_id { get; set; }
        public int type_id { get; set; }
        public string item_cd { get; set; }
        public string item_name { get; set; }
        public string unit_cd { get; set; }
        public double unit_qty { get; set; }
        public double stock_qty { get; set; }
        public string item_location_no { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_item> listItems { get; set; }
        #endregion

        public pts_item()
        {
            listItems = new BindingList<pts_item>();
        }

        /// <summary>
        /// Get infomation of an item with item id
        /// </summary>
        /// <param name="itemID">item id</param>
        /// <returns></returns>
        public pts_item GetItem(int itemID)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_item where 1=1 ";
            query += "and item_id = '" + itemID + "' ";
            query += "order by item_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            //Get an item
            pts_item outItem = new pts_item
            {
                item_id = (int)reader["item_id"],
                type_id = (int)reader["type_id"],
                item_cd = reader["item_cd"].ToString(),
                item_name = reader["item_name"].ToString(),
                unit_cd = reader["unit_cd"].ToString(),
                unit_qty = (double)reader["unit_qty"],
                stock_qty = (double)reader["stock_qty"],
                item_location_no = reader["item_location_no"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString()
            };
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Get infomation of an item with item code
        /// </summary>
        /// <param name="itemCD">item code</param>
        /// <returns></returns>
        public pts_item GetItem(string itemCD)
        {
            try
            {
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = "select * from pts_item where 1=1 ";
                query += "and item_cd = '" + itemCD + "' ";
                query += "order by item_id";
                //Execute reader for read database
                IDataReader reader = SQL.Command(query).ExecuteReader();
                query = string.Empty;
                //Get an item
                pts_item outItem = new pts_item
                {
                    item_id = (int)reader["item_id"],
                    type_id = (int)reader["type_id"],
                    item_cd = reader["item_cd"].ToString(),
                    item_name = reader["item_name"].ToString(),
                    unit_cd = reader["unit_cd"].ToString(),
                    unit_qty = (double)reader["unit_qty"],
                    stock_qty = (double)reader["stock_qty"],
                    item_location_no = reader["item_location_no"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                reader.Close();
                //Close SQL connection
                SQL.Close();
                return outItem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get list item
        /// </summary>
        /// <param name="item_code">string.empty if get list without item code</param>
        /// <param name="unit_code">string.empty if get list without unit type</param>
        /// <param name="location_code">string.empty if get list without location type</param>
        /// <param name="typeID">item type id</param>
        public void GetListItems(string item_code, string unit_code, string location_code, int typeID)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listItems = new BindingList<pts_item>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_item where 1=1 ";
            query += "and type_id = '" + typeID + "' ";
            query += "order by item_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_item outItem = new pts_item
                {
                    item_id = (int)reader["item_id"],
                    type_id = (int)reader["type_id"],
                    item_cd = reader["item_cd"].ToString(),
                    item_name = reader["item_name"].ToString(),
                    unit_cd = reader["unit_cd"].ToString(),
                    unit_qty = (double)reader["unit_qty"],
                    stock_qty = (double)reader["stock_qty"],
                    item_location_no = reader["item_location_no"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listItems.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        /// <summary>
        /// Get list item
        /// </summary>
        /// <param name="item_code">string.empty if get list without item code</param>
        /// <param name="unit_code">string.empty if get list without unit type</param>
        /// <param name="location_code">string.empty if get list without location type</param>
        public void GetListItems(string item_code, string unit_code, string location_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listItems = new BindingList<pts_item>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_item where 1=1 ";
            if (string.IsNullOrEmpty(item_code))
                query += "and item_cd = '" + item_code + "' ";
            if (string.IsNullOrEmpty(unit_code))
                query += "and unit_cd = '" + unit_code + "' ";
            if (string.IsNullOrEmpty(location_code))
                query += "and item_location_no='" + location_code + "' ";
            query += "order by item_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_item outItem = new pts_item
                {
                    item_id = (int)reader["item_id"],
                    type_id = (int)reader["type_id"],
                    item_cd = reader["item_cd"].ToString(),
                    item_name = reader["item_name"].ToString(),
                    unit_cd = reader["unit_cd"].ToString(),
                    unit_qty = (double)reader["unit_qty"],
                    stock_qty = (double)reader["stock_qty"],
                    item_location_no = reader["item_location_no"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listItems.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        /// <summary>
        /// Get all unit code
        /// </summary>
        /// <returns></returns>
        public BindingList<pts_item> GetListUnit()
        {
            try
            {
                //SQL library
                PSQL SQL = new PSQL();
                string query = string.Empty;
                listItems = new BindingList<pts_item>();
                //Open SQL connection
                SQL.Open();
                //SQL query string
                query = "select distinct unit_cd from pts_item where 1=1 ";
                query += "order by unit_cd";
                //Execute reader for read database
                IDataReader reader = SQL.Command(query).ExecuteReader();
                query = string.Empty;
                while (reader.Read())
                {
                    //Get an item
                    pts_item outItem = new pts_item
                    {
                        unit_cd = reader["unit_cd"].ToString(),
                    };
                    listItems.Add(outItem);
                }
                reader.Close();
                //Close SQL connection
                SQL.Close();
                return listItems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Add an item into database
        /// </summary>
        /// <param name="inItem"></param>
        /// <returns></returns>
        public int AddItem(pts_item inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_item(type_id, item_cd, item_name, unit_cd, unit_qty, stock_qty, item_location_no, registration_user_cd)";
            query += "VALUES ('" + inItem.type_id + "','" + inItem.item_cd + "','" + inItem.item_name + "','" + inItem.unit_cd + "','";
            query += inItem.unit_qty + "','" + inItem.stock_qty + "','" + inItem.item_location_no + "','";
            query += inItem.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        /// <summary>
        /// Update an item
        /// </summary>
        /// <param name="inItem"></param>
        /// <returns></returns>
        public int Update(pts_item inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_item SET type_id='" + inItem.type_id + "', item_cd='" + inItem.item_cd + "', item_name='" + inItem.item_name;
            query += "', unit_cd='" + inItem.unit_cd + "', unit_qty='" + inItem.unit_qty + "', stock_qty ='" + inItem.stock_qty;
            query += "', item_location_no ='" + inItem.item_location_no + "', registration_user_cd ='" + inItem.registration_user_cd;
            query += "', registration_date_time = now() where item_id ='" + inItem.item_id;
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
    }
}
