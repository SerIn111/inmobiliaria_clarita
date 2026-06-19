//Esta ventana solo es de prueba
using InmobiliariaClarita.Plantillas;
using Microsoft.Data.SqlClient;

namespace InmobiliariaClarita.Reservaciones
{
    public partial class Reservaciones : Plantilla
    {
        public Reservaciones()
        {
            InitializeComponent();
            cmbLugares.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Casas_Load(object sender, EventArgs e)
        {
            cmbLugares.Items.Clear();
            consultarLugares();
            cmbLugares.SelectedIndex = -1;


            if (cmbLugares.SelectedIndex == -1)
            {
                inhabilitarCampos();
            }
        }

        private void consultarLugares()
        {
            try
            {
                string queryConsultarLugares = "select * from Sucursales where Disponible = 1;";
                using (SqlConnection conectar = Conexion.ObtenerConexion())
                {
                    conectar.Open();
                    SqlCommand cmdConsultarLugares = new SqlCommand(queryConsultarLugares, conectar);
                    SqlDataReader readerConsultarLugares = cmdConsultarLugares.ExecuteReader();
                    while (readerConsultarLugares.Read())
                    {
                        cmbLugares.Items.Add(readerConsultarLugares["Nombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cmbLugares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLugares.SelectedIndex == -1)
            {
                inhabilitarCampos();
            }
            else
            {
                habilitarCampos();
                txtNombreCompleto.Focus();
            }
        }

        /// <summary>
        /// Para deshabilitar los campos si no ha seleccionado un lugar a reservar
        /// </summary>
        private void inhabilitarCampos()
        {
            foreach (Control control in pnlInformacion.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = false;
                }
            }
        }

        private void habilitarCampos()
        {
            foreach (Control control in pnlInformacion.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = true;
                }
            }
        }
    }
}
