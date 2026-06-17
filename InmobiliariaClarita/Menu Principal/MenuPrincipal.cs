using Microsoft.Data.SqlClient;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Plantillas;
using InmobiliariaClarita.Clientes;

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
    }
}
