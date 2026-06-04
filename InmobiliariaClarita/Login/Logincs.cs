using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InmobiliariaClarita.Plantillas;
using InmobiliariaClarita.Menu_Principal;
using Microsoft.VisualBasic;

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
                if (txtUsuario.Text.Equals(String.Empty) || txtContra.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Los campos no deben de estar vacios");
                }
                else
                {
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Hide();
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
    }
}
