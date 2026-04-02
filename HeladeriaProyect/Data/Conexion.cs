using Microsoft.Data.SqlClient;

namespace HeladeriaProyect.Data
{
    public class Conexion
    {
        private string connectionString;

        public Conexion()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            connectionString = configuration.GetConnectionString("HeladeriaDB");
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
