using System;
using System.Drawing;
using System.Windows.Forms;
using CamarasYRespaldosDomain;

namespace CamarasYRespaldosPresentacion
{
    public partial class FormCamarasYRespaldos : Form
    {
        private CamarasYRespaldosClas camarasManager;

        public FormCamarasYRespaldos()
        {
            InitializeComponent();
            camarasManager = new CamarasYRespaldosClas();
            camarasManager.NewFrameReceived += OnNewFrameReceived;
            LoadCameraList();
        }

        private void LoadCameraList()
        {
            // Lista de nombres de cámaras
            string[] cameraNames = new string[]
            {
                "CamaraEntrada1",
                "CamaraEntrada2",
                "CamaraGerencia",
                "CamaraLavadero",
                "CamaraTaller",
                "CamaraDeposito",
                "CamaraMotos",
                "CamaraRampaPrimerPiso",
                "CamaraAfueraSalaDeMaquinas",
                "CamaraPrimerPiso",
                "CamaraRampaSegundoPiso",
                "CamaraSegundoPiso1",
                "CamaraSegundoPiso2"
            };

            // Generar URLs de cámaras IP con nombres amigables
            for (int i = 0; i < cameraNames.Length; i++)
            {
                string cameraName = cameraNames[i];
                string cameraIP = $"192.168.3.{30 + i}";
                string cameraURL = $"rtsp://{cameraIP}/stream";

                // Añadir un objeto anónimo con nombre y URL al ComboBox
                comboBox1.Items.Add(new CameraItem { Name = cameraName, URL = cameraURL });
            }

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "URL";

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la URL de la cámara seleccionada
            CameraItem selectedCamera = (CameraItem)comboBox1.SelectedItem;
            string cameraURL = selectedCamera.URL;

            camarasManager.StartCamera(cameraURL);
        }

        private void OnNewFrameReceived(Bitmap bitmap)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => pictureBox1.Image = bitmap));
            }
            else
            {
                pictureBox1.Image = bitmap;
            }
        }
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                camarasManager.StopCamera();
            }
            base.Dispose(disposing);
        }
*/
        // Clase auxiliar para almacenar la información de la cámara
        private class CameraItem
        {
            public string Name { get; set; }
            public string URL { get; set; }

            // Sobrescribir ToString para mostrar el nombre en el ComboBox
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
