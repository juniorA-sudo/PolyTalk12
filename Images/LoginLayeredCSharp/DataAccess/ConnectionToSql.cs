using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        public ConnectionToSQL()
        {
            connectionString = "Server=JUNIOR;Database=BasePrueba3;Trusted_Connection=True;TrustServerCertificate=True";
        }
       // protected SqlConnection GetConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}

    }
}
