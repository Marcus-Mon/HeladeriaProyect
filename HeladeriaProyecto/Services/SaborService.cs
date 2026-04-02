using HeladeriaProyect.Data;
using HeladeriaProyecto.Entities;
using Microsoft.Data.SqlClient;

namespace HeladeriaProyecto.Services
{
    public class SaborService
    {
        private Conexion conexion = new Conexion();

        public void Crear(SaborHelado sabor)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Sabores (Nombre, Descripcion, Precio) VALUES (@n, @d, @p)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", sabor.Nombre);
                cmd.Parameters.AddWithValue("@d", sabor.Descripcion);
                cmd.Parameters.AddWithValue("@p", sabor.Precio);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

