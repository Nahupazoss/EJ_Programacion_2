using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_programaVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLOW WORDL!!!!","Hola",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);//al clickear el boton muestra un mensaje con ciertos agregados

            this.button1.BackColor = Color.Gray;//al clickear el boton este cambia de color

            string texto = this.textBox1.Text;//agarro lo escrito en el text box al clickear

            //this.Text += texto;

            this.LISTA.Items.Add(this.textBox1.Text);//al clickear agrego a la lista el texto agregado al textbox
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Cambiando el Load";//cambia el texto de la aplicacion(ventana)

            this.BackColor = Color.SteelBlue;//vuelve al fondo de la aplicacion azul o de determinado color
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;//al estar sobre el boton el texto del mismo se vuelve rojo
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LISTA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)//si la tecla que toco coincide
            {
                this.MiMetodo("algo");//hago algo (en este caso le agrego opacidad a mi aplicacion con la funcion que cree)
            }
            MessageBox.Show(e.KeyChar.ToString());
        }

        public void MiMetodo(string algo)
        {
            this.Opacity = 0.3;//agrego opacidad
        }

    }
}
