using HeladeriaProyect.Data;
using HeladeriaProyecto.Entities;
using Microsoft.Data.SqlClient;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> d3bc144af7f4e8864a17c79480989d96b080cfbc

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
<<<<<<< HEAD

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
=======
>>>>>>> d3bc144af7f4e8864a17c79480989d96b080cfbc
    }
}

