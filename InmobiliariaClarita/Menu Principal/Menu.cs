using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InmobiliariaClarita.Login;
using InmobiliariaClarita.Plantillas;

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
            Logincs login = new Logincs();
            login.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
