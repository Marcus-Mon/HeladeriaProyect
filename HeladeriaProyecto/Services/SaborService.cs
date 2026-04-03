using HeladeriaProyect.Data;
using HeladeriaProyecto.Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

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

        public List<SaborHelado> ObtenerTodos()
        {
            List<SaborHelado> lista = new List<SaborHelado>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Sabores";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new SaborHelado
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Precio = (decimal)reader["Precio"]
                    });
                }
            }

            return lista;
        }

        public void Actualizar(SaborHelado sabor)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "UPDATE Sabores SET Nombre=@n, Descripcion=@d, Precio=@p WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", sabor.Nombre);
                cmd.Parameters.AddWithValue("@d", sabor.Descripcion);
                cmd.Parameters.AddWithValue("@p", sabor.Precio);
                cmd.Parameters.AddWithValue("@id", sabor.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

