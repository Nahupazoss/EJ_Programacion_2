using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AClassAppGuerrero;


namespace AplicacionGuerrero
{
    public partial class FrmGuerreroApp: Form
    {
        private Guerrero guerrero;
        private Espada espada;
        private Hacha hacha;
        private Arco arco;
        System.Media.SoundPlayer sonidoEspada;
        System.Media.SoundPlayer sonidoArco;
        System.Media.SoundPlayer sonidoHacha;
        System.Media.SoundPlayer sonidoVendaje;
        System.Media.SoundPlayer sonidoKnife;
        System.Media.SoundPlayer sonidoMap;

        public FrmGuerreroApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OcultarUtilidades();
           this.pictureBox1.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\Pazos.Nahuel\AplicacionGuerrero\Imagenes\gifGuerrero.gif");

            System.IO.Stream audio = Properties.Resources.Espadaa;
            sonidoEspada = new System.Media.SoundPlayer(audio);

            System.IO.Stream audio2 = Properties.Resources.Arcoo;
            sonidoArco = new System.Media.SoundPlayer(audio2);

            System.IO.Stream audio3 = Properties.Resources.Hachaa;
            sonidoHacha = new System.Media.SoundPlayer(audio3);

            System.IO.Stream audio4 = Properties.Resources.Vendajee;
            sonidoVendaje = new System.Media.SoundPlayer(audio4);

            System.IO.Stream audio5 = Properties.Resources.Knife;
            sonidoKnife = new System.Media.SoundPlayer(audio5);

            System.IO.Stream audio6 = Properties.Resources.Map;
            sonidoMap = new System.Media.SoundPlayer(audio6);

            guerrero = new Guerrero();
            espada = new Espada(10, 20);
            hacha = new Hacha(1, 15);
            arco = new Arco(20, 30);
        }

        private void OcultarUtilidades()
        {
            ocultarInventario();
            this.lbl_Mensaje.Visible = false;
            ocultarItems();
        }

        private void ocultarInventario()
        {
            this.picture_Espada.Visible = false;
            this.picture_Arco.Visible = false;
            this.picture_Hacha.Visible = false;
        }

        private void ocultarItems()
        {
            this.pic_venda.Visible = false;
            this.pic_cuchillo.Visible = false;
            this.pic_mapa.Visible = false;
        }

        private void btn_Atacar_Click(object sender, EventArgs e)
        {
            if(picture_Arco.Visible == false && picture_Espada.Visible == false && picture_Hacha.Visible == false)
            {
                this.lbl_Mensaje.Visible = true;
            }
            else
            {
                if (picture_Arco.Visible == false && picture_Espada.Visible == true && picture_Hacha.Visible == false)
                {
                    sonidoEspada.Play();
                    this.lbl_Mensaje.Text = guerrero.AtacarConArma();
                    this.lbl_Mensaje.Visible = true;
                }
                else
                {
                    if (picture_Arco.Visible == true && picture_Espada.Visible == false && picture_Hacha.Visible == false)
                    {
                        sonidoArco.Play();
                        this.lbl_Mensaje.Text = guerrero.AtacarConArma();
                        this.lbl_Mensaje.Visible = true;
                    }
                    else
                    {
                        if (picture_Arco.Visible == false && picture_Espada.Visible == false && picture_Hacha.Visible == true)
                        {
                            sonidoHacha.Play();
                            this.lbl_Mensaje.Text = guerrero.AtacarConArma();
                            this.lbl_Mensaje.Visible = true;
                        }
                    }
                }        
            }
        }

        private void btn_Espada_Click(object sender, EventArgs e)
        {
            guerrero.CambiarArma(espada);
            this.picture_Espada.Visible = true;
            this.picture_Arco.Visible = false;
            this.picture_Hacha.Visible = false;
            ocultarItems();
            this.button1.Visible = false;
            this.btn_Atacar.Visible = true;
        }

        private void btn_Hacha_Click(object sender, EventArgs e)
        {
            guerrero.CambiarArma(hacha);
            this.picture_Espada.Visible = false;
            this.picture_Arco.Visible = false;
            this.picture_Hacha.Visible = true;
            ocultarItems();
            this.button1.Visible = false;
            this.btn_Atacar.Visible = true;
        }

        private void btn_Arco_Click(object sender, EventArgs e)
        {
            guerrero.CambiarArma(arco);
            this.picture_Espada.Visible = false;
            this.picture_Arco.Visible = true;
            this.picture_Hacha.Visible = false;
            ocultarItems();
            this.button1.Visible = false;
            this.btn_Atacar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
                if(pic_venda.Visible == false && pic_cuchillo.Visible == false && pic_mapa.Visible == false)
                {
                    this.lbl_Mensaje.Visible = true;
                }
                else
                {
                    if(pic_venda.Visible == true && pic_cuchillo.Visible == false && pic_mapa.Visible == false)
                    {
                        sonidoVendaje.Play();
                        this.lbl_Mensaje.Text = guerrero.UsarItem();
                        this.lbl_Mensaje.Visible = true;
                    }
                    else
                    {
                        if(pic_venda.Visible == false && pic_cuchillo.Visible == true && pic_mapa.Visible == false)
                        {
                            sonidoKnife.Play();
                            this.lbl_Mensaje.Text = guerrero.UsarItem();
                            this.lbl_Mensaje.Visible = true;
                        }
                        else
                        {
                            if(pic_venda.Visible == false && pic_cuchillo.Visible == false && pic_mapa.Visible == true)
                            {
                                sonidoMap.Play();
                                this.lbl_Mensaje.Text = guerrero.UsarItem();
                                this.lbl_Mensaje.Visible = true;
                            }
                        }
                    }
                }
            }
           catch(Exception ex)
           {
               this.lbl_Mensaje.Text = ex.Message;
               this.lbl_Mensaje.ForeColor = Color.Red;
               this.lbl_Mensaje.Visible = true;
           }
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            guerrero.Item = new Venda(20,"Venda");
            this.pic_venda.Visible = true;
            this.pic_cuchillo.Visible = false;
            this.pic_mapa.Visible = false;
            ocultarInventario();
            this.btn_Atacar.Visible = false;
            this.button1.Visible = true;
        }

        private void btn_Cuchillo_Click(object sender, EventArgs e)
        {
            guerrero.Item = new Cuchillo(20);
            this.pic_venda.Visible = false;
            this.pic_cuchillo.Visible = true;
            this.pic_mapa.Visible = false;
            ocultarInventario();
            this.btn_Atacar.Visible = false;
            this.button1.Visible = true;
        }

        private void btn_Mapa_Click(object sender, EventArgs e)
        {
            guerrero.Item = new Mapa(true,"Mapita");
            this.pic_venda.Visible = false;
            this.pic_cuchillo.Visible = false;
            this.pic_mapa.Visible = true;
            ocultarInventario();
            this.btn_Atacar.Visible = false;
            this.button1.Visible = true;
        }
    }
}
