using System;
using System.Collections.Generic;
using System.Data;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// SUPPLIER IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_supplier
    {
        #region FIELDS OF SUPPLIER
        public string supplier_cd { get; set; }
        public string supplier_name { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<pts_supplier> listSupplier { get; set; }
        #endregion

        /// <summary>
        /// Get list supplier from database with supplier code
        /// </summary>
        /// <param name="supplier_code">string.empty if get all supplier in database</param>
        public void GetListSupplier(string supplier_code)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            listSupplier = new List<pts_supplier>();
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select * from pts_supplier where 1=1 ";
            if (string.IsNullOrEmpty(supplier_code))
                query += "and supplier_cd = '" + supplier_code + "' ";
            query += "order by supplier_cd";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            query = string.Empty;
            while (reader.Read())
            {
                //Get an item
                pts_supplier outItem = new pts_supplier
                {
                    supplier_cd = reader["supplier_cd"].ToString(),
                    supplier_name = reader["supplier_name"].ToString(),
                    registration_date_time = (DateTime)reader["registration_date_time"],
                    registration_user_cd = reader["registration_user_cd"].ToString()
                };
                //Add item into list
                listSupplier.Add(outItem);
            }
            reader.Close();
            //Close SQL connection
            SQL.Close();
        }
    }
}
