using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PC_QRCodeSystem.Model
{
    /// <summary>
    /// SUPPLIER IN PRODUCTION TRACEBILITY SYSTEM
    /// </summary>
    public class pts_supplier
    {
        #region ALL FIELDS
        public int supplier_id { get; set; }
        public string supplier_cd { get; set; }
        public string supplier_name { get; set; }
        public string supplier_tel { get; set; }
        public string supplier_fax { get; set; }
        public string supplier_address { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public List<pts_supplier> listSupplier { get; set; }
        public pts_supplier()
        {
            listSupplier = new List<pts_supplier>();
        }
        #endregion

        #region QUERY
        /// <summary>
        /// Get a supplier
        /// </summary>
        /// <param name="inItem">input info supplier to search</param>
        /// <returns></returns>
        public pts_supplier GetSupplier(pts_supplier inItem)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "select supplier_id, supplier_cd, supplier_name, supplier_tel, supplier_fax, supplier_address, registration_date_time,registration_user_cd ";
            query += "from pts_supplier where 1=1 ";
            if (inItem.supplier_id > 0)
                query += "and supplier_id ='" + inItem.supplier_id + "' ";
            if (!string.IsNullOrEmpty(inItem.supplier_cd))
                query += "and supplier_cd ='" + inItem.supplier_cd + "' ";
            if (!string.IsNullOrEmpty(inItem.supplier_name))
                query += "and supplier_name ='" + inItem.supplier_name + "' ";
            //Execute reader for read database
            IDataReader reader = SQL.Command(query).ExecuteReader();
            reader.Read();
            pts_supplier outItem = new pts_supplier
            {
                supplier_id = (int)reader["supplier_id"],
                supplier_cd = reader["supplier_cd"].ToString(),
                supplier_name = reader["supplier_name"].ToString(),
                supplier_tel = reader["supplier_tel"].ToString(),
                supplier_fax = reader["supplier_fax"].ToString(),
                supplier_address = reader["supplier_address"].ToString(),
                registration_date_time = (DateTime)reader["registration_date_time"],
                registration_user_cd = reader["registration_user_cd"].ToString()
            };
            reader.Close();
            query = string.Empty;
            //Close SQL connection
            SQL.Close();
            return outItem;
        }

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
            query = "select supplier_id, supplier_cd, supplier_name, supplier_tel, supplier_fax, supplier_address, registration_date_time,registration_user_cd ";
            query += "from pts_supplier where 1=1 ";
            if (!string.IsNullOrEmpty(supplier_code))
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
                    supplier_id = (int)reader["supplier_id"],
                    supplier_cd = reader["supplier_cd"].ToString(),
                    supplier_name = reader["supplier_name"].ToString(),
                    supplier_tel = reader["supplier_tel"].ToString(),
                    supplier_fax = reader["supplier_fax"].ToString(),
                    supplier_address = reader["supplier_address"].ToString(),
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

        /// <summary>
        /// Add supplier item
        /// </summary>
        /// <param name="addptssupplier"></param>
        /// <returns></returns>
        public int AddSupplier(pts_supplier addptssupplier)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "INSERT INTO pts_supplier(supplier_cd, supplier_name, supplier_tel, supplier_fax, supplier_address, registration_user_cd)";
            query += "VALUES ('" + addptssupplier.supplier_cd + "','" + addptssupplier.supplier_name + "','";
            query += addptssupplier.supplier_tel + "','" + addptssupplier.supplier_fax + "','" + addptssupplier.supplier_address + "','";
            query += addptssupplier.registration_user_cd + "')";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        /// <summary>
        /// Update supplier
        /// </summary>
        /// <param name="UpSupplier"></param>
        /// <returns></returns>
        public int UpdateSuplier(pts_supplier UpSupplier)
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "UPDATE pts_supplier SET supplier_cd='" + UpSupplier.supplier_cd + "', supplier_name='" + UpSupplier.supplier_name;
            query += "', supplier_tel ='" + UpSupplier.supplier_tel + "', supplier_fax ='" + UpSupplier.supplier_fax;
            query += "', supplier_address ='" + UpSupplier.supplier_address + "',registration_user_cd ='" + UpSupplier.registration_user_cd;
            query += "', registration_date_time = now() where supplier_cd ='" + UpSupplier.supplier_cd + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;
        }

        /// <summary>
        /// Delete current supplier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete()
        {
            //SQL library
            PSQL SQL = new PSQL();
            string query = string.Empty;
            //Open SQL connection
            SQL.Open();
            //SQL query string
            query = "DELETE FROM pts_supplier WHERE supplier_id ='" + supplier_id + "'";
            //Execute non query for read database
            int result = SQL.Command(query).ExecuteNonQuery();
            query = string.Empty;
            return result;

        }
        #endregion
    }
}
