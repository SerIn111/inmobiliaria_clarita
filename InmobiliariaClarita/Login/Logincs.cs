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
            tpUsuario.SetToolTip(txtUsuario, "Ingrese el usuario");
            tpContraseña.SetToolTip(txtContra, "Ingrese el la contraseña");
            tpAceptar.SetToolTip(btnAceptar, "Validar credenciales e iniciar sesion");
        }
    }
}
