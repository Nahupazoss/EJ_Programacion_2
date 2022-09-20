using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_PorgramaVentana
{
    public partial class Form1 : Form
    {
        public float precio;
        public float descuento;
        public float valorDescuento;
        public float ValorTotal;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            precio = float.Parse(textBox1.Text);
            descuento = 1;

            if (precio > 2999)
            {
                descuento = 0.20F;

                if (precio > 4999)
                {
                    descuento = 0.30F;
                }
            }

            valorDescuento = precio * descuento;

            ValorTotal = precio - valorDescuento;

            textBox2.Text = $"{valorDescuento}";
            textBox3.Text = $"{ValorTotal}";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
