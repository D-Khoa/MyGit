using System.Data;
using System.Data.SqlClient;

namespace ImportDataToDatabase.Common
{
    public class SQLCommon
    {
        public SqlConnection ConnectionDB;
        public string ConnectionString = @"Data Source=Shin;Initial Catalog = mtest; Integrated Security = True";

        public void InsertDatatableToDB(ref DataTable dt)
        {
            ConnectionDB = new SqlConnection(ConnectionString);
            ConnectionDB.Open();
            using (var adapte = new SqlDataAdapter("select * from m_pqmdata", ConnectionDB))
            using (var builder = new SqlCommandBuilder(adapte))
            {
                adapte.InsertCommand = builder.GetInsertCommand();
                adapte.Update(dt);
            }
            ConnectionDB.Close();
        }
    }
}
