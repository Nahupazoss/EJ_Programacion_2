using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tercer_PorgramaVentana
{
    public partial class Form1 : Form
    {
        public int numero;
        public Form1()
        {
            InitializeComponent();
            this.Text = "TABLA MATEMATICA DE 10";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//si la tecla que toco coincide
            {
                this.numero = int.Parse(this.textBox1.Text);//hago algo (en este caso le agrego opacidad a mi aplicacion con la funcion que cree)
                
                for(int i = 0; i < 11; i++)
                {
                    int resultado = this.numero * i;
                    listBox1.Items.Add($"El numero {this.numero} multiplicado por {i} es igual a : {resultado} \n");
                }
            }           
        }
    }
}
