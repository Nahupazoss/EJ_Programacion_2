using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class1.cs;

namespace ClaseSabado_Vista
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomb = this.txt_Nombre.Text;
            string usuario = this.textBox2.Text;
            string pass = this.txt_Contraseña.Text;

            if (ValidarInformacionRegistro(nomb, usuario, pass))
            {
                Supermercado.ResgistrarEmpleados(nomb, usuario, pass);
                MessageBox.Show($"{nomb} Se ha registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error,los datos ingresados son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ValidarInformacionRegistro(string nomb, string usuario, string pass)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
