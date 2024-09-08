using LoginDataAcces;
using MySql.Data.MySqlClient;
using System.Data.Common;
namespace LoginDomain
{
    public class UserBL
    {
        private UserDAL userDAL;

        public UserBL()
        {
            userDAL = new UserDAL();
        }

        // Método de login que verifica el usuario
        public bool Login(string username, string password)
        {
            return userDAL.VerificarUsuario(username, password);
        }
        public int ObtenerTipoDeUsuario(string username)
        {
            return userDAL.ObtenerTipoDeUsuario(username);
        }
    }
}
