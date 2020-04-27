using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    public class pts_noplan
    {
        #region ALL FIELDS
        public int noplan_id { get; set; }
        public string noplan_cd { get; set; }
        public string destination_cd { get; set; }
        public string item_cd { get; set; }
        public double noplan_qty { get; set; }
        public string noplan_usercd { get; set; }
        public DateTime noplan_date { get; set; }
        public BindingList<pts_noplan> listNoPlan;
        public pts_noplan()
        {
            listNoPlan = new BindingList<pts_noplan>();
        }
        #endregion

        #region QUERY
        public void Search(pts_noplan inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "SELECT noplan_id, noplan_cd, destination_cd, item_cd, noplan_qty, noplan_usercd, noplan_date ";
            query += "FROM pts_noplan WHERE 1=1 ";
            if (!string.IsNullOrEmpty(inItem.noplan_cd))
                query += "AND noplan_cd ='" + inItem.noplan_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.destination_cd))
                query += "AND destination_cd ='" + inItem.destination_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.item_cd))
                query += "AND item_cd ='" + inItem.item_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.noplan_usercd))
                query += "AND noplan_usercd ='" + inItem.noplan_usercd + "' ";
            query += "ORDER BY noplan_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            //Clear query
            query = string.Empty;
            //Read data into list
            while (reader.Read())
            {
                pts_noplan outItem = new pts_noplan
                {
                    noplan_id = (int)reader["noplan_id"],
                    noplan_cd = reader["noplan_cd"].ToString(),
                    destination_cd = reader["destination_cd"].ToString(),
                    item_cd = reader["item_cd"].ToString(),
                    noplan_qty = (double)reader["noplan_qty"],
                    noplan_usercd = reader["noplan_usercd"].ToString(),
                    noplan_date = (DateTime)reader["noplan_date"],
                };
                listNoPlan.Add(outItem);
            }
            //Close reader and connection
            reader.Close();
            SQL.Close();
        }

        public int AddItem(pts_noplan inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_noplan(noplan_cd, destination_cd, item_cd, noplan_qty, noplan_usercd, noplan_date) VALUES ";
            query += "('" + inItem.noplan_cd + "','" + inItem.destination_cd + "','" + inItem.item_cd + "','";
            query += inItem.noplan_qty + "','" + inItem.noplan_usercd + "','" + inItem.noplan_date + "')";
            //Execute non query SQL
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }

        public int AddMultiItem(List<pts_noplan> inList)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_noplan(noplan_cd, destination_cd, item_cd, noplan_qty, noplan_usercd, noplan_date) VALUES ";
            foreach (pts_noplan inItem in inList)
            {
                query += "('" + inItem.noplan_cd + "','" + inItem.destination_cd + "','" + inItem.item_cd + "','";
                query += inItem.noplan_qty + "','" + inItem.noplan_usercd + "','" + inItem.noplan_date + "'),";
            }
            query = query.Remove(query.Length - 1);
            //Execute non query SQL
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            SQL.Close();
            return result;
        }
        #endregion

    }
}
