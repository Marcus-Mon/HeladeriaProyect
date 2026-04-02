using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HeladeriaProyect.Data
{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            connectionString = configuration.GetConnectionString("HeladeriaDB");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("No se encontró la cadena de conexión.");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}