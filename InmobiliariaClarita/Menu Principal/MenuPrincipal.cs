using Microsoft.Data.SqlClient;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Plantillas;

namespace InmobiliariaClarita.Menu_Principal
{
    public partial class MenuPrincipal : Plantilla
    {
        public string EmpleadoID { get; set; }
        public MenuPrincipal(string id)
        {
            InitializeComponent();
            EmpleadoID = id;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            mostrarIntegrantes();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Esto cierra el menú y devuelve el control al Login original
        }

        private void mostrarIntegrantes()
        {
            //Esta funcion solo es de prueba, es para que vean cómo se usarán las consultas.
            try
            {
                string queryPrueba = "select * from Empleados where Empleado_ID = @empleadoid;";
                using (SqlConnection conectar = Conexion.ObtenerConexion())
                {
                    conectar.Open();
                    SqlCommand cmdQueryPrueba = new SqlCommand(queryPrueba, conectar);
                    cmdQueryPrueba.Parameters.AddWithValue("@empleadoid", EmpleadoID);
                    SqlDataReader readerQueryPrueba = cmdQueryPrueba.ExecuteReader();
                    if (readerQueryPrueba.Read())
                    {
                        string nombreCompleto = readerQueryPrueba["Nombre"].ToString();
                        string[] nombrePartes = nombreCompleto.Split(" ");
                        string nombre3 = "";

                        for(int i = 0; i <= 2; i++)
                        {
                            nombre3 += nombrePartes[i];
                            if(i < 2)
                            {
                                nombre3 += " ";
                            }
                        }
                        MessageBox.Show("Hola " + nombre3);

                        //Para ver el texto en la consola
                        System.Diagnostics.Debug.WriteLine("Hola " + nombre3);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Algo salió mal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
