using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// ITEM LOCATION IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_item_location
    {
        #region FIELDS OF ITEM LOCATION
        public string item_location_no { get; set; }
        public string item_location_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public BindingList<pts_item_location> listItemLocation { get; set; }
        #endregion

        public pts_item_location()
        {
            listItemLocation = new BindingList<pts_item_location>();
        }

        /// <summary>
        /// Get list item location
        /// </summary>
        /// <param name="location_cd">string.empty if get all item location</param>
        public void GetListItemLocation(string location_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listItemLocation = new BindingList<pts_item_location>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_item_location where 1=1 ";
            if (!string.IsNullOrEmpty(location_code))
                query += "and item_location_no = '" + location_code + "' ";
            query += "order by item_location_no";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_item_location outItem = new pts_item_location
                {
                    item_location_no = reader["item_location_no"].ToString(),
                    item_location_name = reader["item_location_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listItemLocation.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }

        /// <summary>
        /// Add an item location
        /// </summary>
        /// <param name="inItem">new item location</param>
        /// <returns></returns>
        public int AddItemLocation(pts_item_location inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_item_location(item_location_no, item_location_name, registration_user_cd)";
            query += "VALUES ('" + inItem.item_location_no + "','" + inItem.item_location_name + "','" + inItem.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }
    }
}
