using System;
using MySql.Data.MySqlClient;

namespace LoginDataAcces
{
    public abstract class MariaDBConexion
    {
        private MySqlConnection connection;

        public MariaDBConexion()
        {
            // Cadena de conexión a MariaDB
            string connectionString = "Server=localhost;Database=AIOParking;User ID=Gerente;Password=qwerty1234;";
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

    }

    
    public class UserDAL : MariaDBConexion
    {
        public bool VerificarUsuario(string username, string password)
        {
            MySqlConnection connection = AbrirConexion(); // Usa la conexión de MariaDBConexion
            try
            {
                // Consulta SQL para verificar si el usuario y la contraseña coinciden
                string query = "SELECT COUNT(1) FROM Usuario WHERE NombreUsuario = @Username AND Contrasenia = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);  // Aquí comparamos directamente la contraseña

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Devuelve true si hay exactamente un usuario con esas credenciales
                return count == 1;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al verificar el usuario", ex);
            }
            finally
            {
                CerrarConexion();  // Cierra la conexión después de la operación
            }
        }
        public int ObtenerTipoDeUsuario(string username)
        {
            MySqlConnection connection = AbrirConexion();
            try
            {
                // Consulta SQL para obtener el tipo de usuario (IDTipoDeUsuario)
                string query = "SELECT IDTipoDeUsuarioUsu FROM Usuario WHERE NombreUsuario = @Username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("Usuario no encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el tipo de usuario", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}


