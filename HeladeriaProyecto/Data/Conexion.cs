using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
namespace HeladeriaProyect.Data

{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Cambiado para usar Directory.GetCurrentDirectory()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            connectionString = configuration.GetConnectionString("HeladeriaDB");

            // Validación para evitar errores silenciosos
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
}
