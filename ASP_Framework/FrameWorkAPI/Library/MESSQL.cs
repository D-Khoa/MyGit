using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FrameWorkAPI.Library
{
    public class MESSQL
    {
        public string ConnectionString { get; set; }

        /// <summary>
        /// Call and set connectionstring for SQL connection
        /// </summary>
        /// <param name="connectionstring"></param>
        public MESSQL()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
        }

        /// <summary>
        /// Call and set connectionstring for SQL connection
        /// </summary>
        /// <param name="connectionstring">custom connection string</param>
        public MESSQL(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        /// <summary>
        /// Set SQL connection
        /// </summary>
        /// <returns></returns>
        public IDbConnection DbContext()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            return sqlConnection;
        }

        /// <summary>
        /// Set SQL command without transaction
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="dbConnection"></param>
        /// <returns></returns>
        public IDbCommand DbCommand(string cmdText, IDbConnection dbConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(cmdText, (SqlConnection)dbConnection);
            return sqlCommand;
        }

        /// <summary>
        /// Set SQL command with transaction
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="dbConnection"></param>
        /// <param name="dbTransaction"></param>
        /// <returns></returns>
        public IDbCommand DbCommand(string cmdText, IDbConnection dbConnection, IDbTransaction dbTransaction)
        {
            SqlCommand sqlCommand = new SqlCommand(cmdText, (SqlConnection)dbConnection, (SqlTransaction)dbTransaction);
            return sqlCommand;
        }
    }
}