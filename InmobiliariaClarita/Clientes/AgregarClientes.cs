using System.Numerics;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Menu_Principal;
using InmobiliariaClarita.Plantillas;
using Microsoft.Data.SqlClient;

namespace InmobiliariaClarita.Clientes
{
    public partial class AgregarClientes : Plantilla
    {
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // e.Handled = true cancela el evento, es decir, el carácter no se escribe
                e.Handled = true;
            }
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // e.Handled = true cancela el evento, es decir, el carácter no se escribe
                e.Handled = true;
            }
        }

        private void limpiarDatos()
        {
            txtRTN.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCiudad.Text = string.Empty;

            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Para verificar si hay campos vacios
            if (
                txtRTN.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                txtTelefono.Text == string.Empty ||
                txtDireccion.Text == string.Empty)
            {
                if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                {
                    MessageBox.Show(
                        "El correo debe tener un formato correcto",
                        "Corregir el correo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                MessageBox.Show(
                    "Los campos obligatorios no deben estar vacios",
                    "Obligatorio llenar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea realizar esta acción?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    if (verificarDuplicado(txtRTN.Text))
                    {
                        MessageBox.Show(
                            "Ese RTN ya sale registrado en el sistema",
                            "Duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        agregarClientes();
                    }
                }
            }
        }

        private bool verificarDuplicado(string rtn)
        {
            bool duplicado = false;
            try
            {
                string queryVerificarDuplicado = "select * from Clientes where RTN = @rtn";
                using (SqlConnection conectar = Conexion.ObtenerConexion())
                {
                    conectar.Open();
                    SqlCommand cmdVerificarDuplicado = new SqlCommand(queryVerificarDuplicado, conectar);
                    cmdVerificarDuplicado.Parameters.AddWithValue("@rtn", rtn);
                    SqlDataReader readerVerificarDuplicado = cmdVerificarDuplicado.ExecuteReader();
                    if (readerVerificarDuplicado.Read())
                    {
                        duplicado = true;
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
            return duplicado;
        }

        private void agregarClientes()
        {
            try
            {
                string queryAgregarClientes = "insert into Clientes values (@rtn, @nombre, @ciudad, @fecha, @telefono, @correo, @direccion)";
                using (SqlConnection conectar = Conexion.ObtenerConexion())
                {
                    conectar.Open();
                    SqlCommand cmdAgregarClientes = new SqlCommand(queryAgregarClientes, conectar);
                    cmdAgregarClientes.Parameters.AddWithValue("@rtn", txtRTN.Text);
                    cmdAgregarClientes.Parameters.AddWithValue("@nombre", txtNombre.Text.ToUpper());
                    cmdAgregarClientes.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                    cmdAgregarClientes.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmdAgregarClientes.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmdAgregarClientes.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmdAgregarClientes.Parameters.AddWithValue("@direccion", txtDireccion.Text.ToUpper());

                    if (cmdAgregarClientes.ExecuteNonQuery() != 0) //Se manda a ejecutar el query y verifica si afectó filas
                    {
                        System.Diagnostics.Debug.WriteLine("Hola " + Logincs.usuarioID);
                        MessageBox.Show(
                            "Cliente agregado con exito",
                            "Exito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        this.Hide();

                        MenuPrincipal menu = new MenuPrincipal();
                        menu.ShowDialog();
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
