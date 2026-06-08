using Microsoft.Data.SqlClient;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Plantillas;

namespace InmobiliariaClarita.Menu_Principal
{
    public partial class MenuPrincipal : Plantilla
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            mostrarIntegrantes();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Dispose();
        }

        private void mostrarIntegrantes()
        {
            //Esta funcion solo es de prueba, es para que vean cómo se usarán las consultas.
            try
            {
                string queryprueba = "select * from Integrantes;";
                using (SqlConnection conectar = Conexion.ObtenerConexion())
                {
                    conectar.Open();
                    SqlCommand cmdqueryprueba = new SqlCommand(queryprueba, conectar);
                    SqlDataReader readerqueryprueba = cmdqueryprueba.ExecuteReader();
                    while (readerqueryprueba.Read())
                    {
                        MessageBox.Show(readerqueryprueba["Nombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "F",
                    "Algo salió mal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
