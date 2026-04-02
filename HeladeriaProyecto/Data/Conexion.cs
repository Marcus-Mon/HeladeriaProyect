using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
<<<<<<< Updated upstream
namespace HeladeriaProyect.Data

=======

namespace HeladeriaProyect.Data
>>>>>>> Stashed changes
{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            IConfiguration configuration = new ConfigurationBuilder()
<<<<<<< Updated upstream
                .SetBasePath(Directory.GetCurrentDirectory()) // Cambiado para usar Directory.GetCurrentDirectory()
=======
                .SetBasePath(Directory.GetCurrentDirectory())
>>>>>>> Stashed changes
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            connectionString = configuration.GetConnectionString("HeladeriaDB");

<<<<<<< Updated upstream
            // Validación para evitar errores silenciosos
=======
>>>>>>> Stashed changes
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("La cadena de conexión 'HeladeriaDB' no fue encontrada en appsettings.json");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
