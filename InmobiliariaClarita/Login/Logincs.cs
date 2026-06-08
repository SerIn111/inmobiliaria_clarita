using InmobiliariaClarita.Menu_Principal;
using InmobiliariaClarita.Plantillas;

namespace InmobiliariaClarita.Login
{
    public partial class Logincs : Plantilla
    {
        public Logincs()
        {
            InitializeComponent();
        }

        private void Logincs_Load(object sender, EventArgs e)
        {
            //Son los textos que se ven al poner el cursos encima
            tpUsuario.SetToolTip(txtUsuario, "Ingrese el usuario");
            tpContra.SetToolTip(txtContra, "Ingrese el la contraseña");
            tpAceptar.SetToolTip(btnAceptar, "Validar credenciales e iniciar sesion");
            tpSalir.SetToolTip(btnSalir, "Salir del sistema");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void iniciarSesion()
        {
            try
            {
                if (txtUsuario.Text == String.Empty || txtContra.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Los campos no deben de estar vacios",
                        "Campos vacios", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    if (txtContra.Text.Length <= 4)
                    {
                        MessageBox.Show("La contraseña debe tener mas de 4 caracteres",
                            "Contraseña no segura",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.ShowDialog();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Para salir del sistema
        }

        //Evento que se utiliza para cuando se presiona Enter en un Textbox
        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            //Va junto con este condicional
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion();
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Escriba el usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
    }
}
