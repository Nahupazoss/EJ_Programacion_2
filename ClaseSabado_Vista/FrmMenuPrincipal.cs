using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSabado_Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lb_Mensaje_Click(object sender, EventArgs e)
        {

        }

        public FrmMenuPrincipal (string mensaje) : this()
        {
            this.lb_Mensaje.Text = mensaje;
        }

        public string Mensaje
        {
            set { this.lb_Mensaje.Text = value;  }
        }
    }
}
