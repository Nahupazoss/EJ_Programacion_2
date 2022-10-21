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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lbl_Mensaje_Error.Visible = false;
            lbl_Mensaje_Error.Text = "ERROR, REINGRESE DATOS";
            
        }

        
        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_Aceptar_Click_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text;
            string pass = this.txt_password.Text;

            if (ValidarInformacionTexto(usuario, pass))
            {
                if(Supermercado.LoguearEmpleado(usuario,pass))
                {
                    FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal($"Bienvenido {usuario}");

                    menuPrincipal.Show();
                    Hide();

                    lbl_Mensaje_Error.Visible = false;
                }
                else
                {
                    lbl_Mensaje_Error.Visible = true;
                }
            }
            else
            {
                lbl_Mensaje_Error.Text = "ERROR, REINGRESE DATOS";
                lbl_Mensaje_Error.Visible = true;
            }
        } 
        //dadwadawdawdawdawd//shift alt truco
        //dadwadawdawdawdawd
        private static bool ValidarInformacionTexto(string usuario, string pass)
        {
            return Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void btn_RegistrarUsuario_Click_Click(object sender, EventArgs e)
        {
            FrmRegistro menuRegistro = new FrmRegistro();

            menuRegistro.Show();

            lbl_Mensaje_Error.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
