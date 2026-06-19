using Microsoft.Data.SqlClient;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Plantillas;
using InmobiliariaClarita.Clientes;
using InmobiliariaClarita.Reservaciones;

namespace InmobiliariaClarita.Menu_Principal
{
    public partial class Menu : Plantilla
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Esto cierra el menú y devuelve el control al Login original
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarClientes agregar = new AgregarClientes();
            agregar.ShowDialog();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservaciones.Reservaciones reserv = new Reservaciones.Reservaciones();
            reserv.ShowDialog();
        }
    }
}
