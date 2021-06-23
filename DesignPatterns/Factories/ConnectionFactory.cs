using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection
            {
                ConnectionString = "User Id=root;Password=;Server=localhost;Database=DB"
            };
            connection.Open();
            return connection;
        }
    }
}
