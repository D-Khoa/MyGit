using System;
using System.Collections.Generic;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// LOG OF ITEM REQUEST IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_request_log
    {
        #region FIELDS OF REQUEST
        public int request_log_id { get; set; }
        public string item_cd { get; set; }
        public string product_cd { get; set; }
        public string destination_cd { get; set; }
        public DateTime use_date { get; set; }
        public DateTime request_date { get; set; }
        public double request_qty { get; set; }
        public string comment { get; set; }
        public string request_user_cd { get; set; }
        public bool m_confirm { get; set; }
        public bool gm_confirm { get; set; }
        public string approve_user_cd { get; set; }
        public bool pc_m_cofirm { get; set; }
        public bool pc_pm_confirm { get; set; }
        public double result_qty { get; set; }
        public DateTime log_reg_date { get; set; }
        public List<pts_request_log> listRequestItem { get; set; }
        #endregion

        /// <summary>
        /// Get list request log from database
        /// </summary>
        /// <param name="inItem">item code, model code, destination code, request user code, approve user code</param>
        public void GetListRequestItem(pts_request_log inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listRequestItem = new List<pts_request_log>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_request_log where 1=1 ";
            if (string.IsNullOrEmpty(inItem.item_cd))
                query += "and item_cd = '" + inItem.item_cd + "' ";
            if (string.IsNullOrEmpty(inItem.product_cd))
                query += "and product_cd = '" + inItem.product_cd + "' ";
            if (string.IsNullOrEmpty(inItem.destination_cd))
                query += "and destination_cd = '" + inItem.destination_cd + "' ";
            if (string.IsNullOrEmpty(inItem.request_user_cd))
                query += "and request_user_cd = '" + inItem.request_user_cd + "' ";
            if (string.IsNullOrEmpty(inItem.approve_user_cd))
                query += "and approve_user_cd = '" + inItem.approve_user_cd + "' ";
            query += "order by request_log_id";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_request_log outItem = new pts_request_log
                {
                    request_log_id = (int)reader["request_log_id"],
                    item_cd = reader["item_cd"].ToString(),
                    product_cd = reader["product_cd"].ToString(),
                    destination_cd = reader["dept_cd"].ToString(),
                    use_date = (DateTime)reader["use_date"],
                    request_date = (DateTime)reader["request_date"],
                    request_qty = (double)reader["request_qty"],
                    comment = reader["comment"].ToString(),
                    request_user_cd = reader["request_user_cd"].ToString(),
                    m_confirm = (bool)reader["m_confirm"],
                    gm_confirm = (bool)reader["gm_confirm"],
                    approve_user_cd = reader["approve_user_cd"].ToString(),
                    pc_m_cofirm = (bool)reader["pc_m_cofirm"],
                    pc_pm_confirm = (bool)reader["pc_pm_confirm"],
                    result_qty = (double)reader["result_qty"],
                    log_reg_date = (DateTime)reader["log_reg_date"]
                };
                //Add item into list
                listRequestItem.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
    }
}
