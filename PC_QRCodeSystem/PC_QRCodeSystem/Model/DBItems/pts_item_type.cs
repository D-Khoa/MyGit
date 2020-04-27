using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// TYPE OF ITEM IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_item_type
    {
        #region FIELDS OF ITEM TYPE
        public int type_id { get; set; }
        public string type_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_item_type> listItemType { get; set; }
        #endregion

        public pts_item_type()
        {
            listItemType = new BindingList<pts_item_type>();
        }

        /// <summary>
        /// Get infomation of an item type
        /// </summary>
        /// <param name="typeID">type id</param>
        /// <returns></returns>
        public pts_item_type GetItemType(int typeID)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_item_type where 1=1 ";
            query += "and type_id = '" + typeID + "' ";
            query += "order by type_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            //Get an item
            reader.Read();
            pts_item_type outItem = new pts_item_type
            {
                type_id = (int)reader["type_id"],
                type_name = reader["type_name"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString()
            };
            reader.Close();
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

        /// <summary>
        /// Get list of all item type
        /// </summary>
        public void GetListItemType()
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listItemType = new BindingList<pts_item_type>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select type_id, type_name, registration_user_cd, registration_date_time from pts_item_type where 1=1 ";
            query += "order by type_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_item_type outItem = new pts_item_type
                {
                    type_id = (int)reader["type_id"],
                    type_name = reader["type_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listItemType.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        /// <summary>
        /// Add an item type
        /// </summary>
        /// <param name="inItem">new item type</param>
        /// <returns></returns>
        public int AddItemType(pts_item_type inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_item_type(type_id, type_name, registration_user_cd)";
            query += "VALUES ('" + inItem.type_id + "','" + inItem.type_name + "','" + inItem.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        /// <summary>
        /// Update an item type
        /// </summary>
        /// <param name="inItem">input item type</param>
        /// <returns></returns>
        public int Update(pts_item_type inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_item_type SET type_id='" + inItem.type_id + "', type_name='" + inItem.type_name;
            query += "', registration_user_cd ='" + inItem.registration_user_cd;
            query += "', registration_date_time = now() where type_id ='" + inItem.type_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        /// <summary>
        /// Delete an item type
        /// </summary>
        /// <param name="id">item type id</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM pts_item_type WHERE type_id ='" + id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;

        }
    }
}
