using HeladeriaProyect.Data;
using Microsoft.Data.SqlClient;

namespace HeladeriaProyect.Services
{
    public class UsuarioService
    {
        private Conexion conexion = new Conexion();

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Username = @user AND Password = @pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username.Trim());
                cmd.Parameters.AddWithValue("@pass", password.Trim());

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en login: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
