using System;
using MySql.Data.MySqlClient;
namespace JefeServiciosDataAcces
{
    public abstract class MariaDBConexion
    {
        private MySqlConnection connection;

        public MariaDBConexion()
        {
            // Cadena de conexión a MariaDB
            string connectionString = "Server=localhost;Database=AIOParking;User ID=JefeServicios;Password=qwerty1234;";
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
}
