using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        public ConnectionToSQL()
        {
        }
       // protected SqlConnection GetConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}

    }
}
