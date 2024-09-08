using LoginDataAcces;
using LoginDomain;
using GerentePresentacion;
using JefeServiciosPresentacion;
using CamarasYRespaldosPresentacion;
using CajeroPresentacion;
using EjecutivosPresentacion;


namespace LoginPresentacion
{
    public partial class FormLogin : Form
    {
        private UserBL userBL;

        public FormLogin()
        {
            InitializeComponent();
            userBL = new UserBL();
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            string username = TBNomUsu.Text;
            string password = TBPass.Text;

            if (userBL.Login(username, password))
            {
                int tipoDeUsuario = userBL.ObtenerTipoDeUsuario(username);

                switch (tipoDeUsuario)
                {
                    case 1:
                        FormGerente gerenteUI = new FormGerente();
                        gerenteUI.Show();
                        break;
                    case 2:
                        FormJefeServicios jefeUI = new FormJefeServicios();
                        jefeUI.Show();
                        break;
                    case 3:
                        FormCamarasYRespaldos camarasUI = new FormCamarasYRespaldos();
                        camarasUI.Show();
                        break;
                    case 4:
                        FormCajero cajeroUI = new FormCajero();
                        cajeroUI.Show();
                        break;
                    case 5:
                        FormEjecutivos ejecutivosUI = new FormEjecutivos();
                        ejecutivosUI.Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no válido.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
