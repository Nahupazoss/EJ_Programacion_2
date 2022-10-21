using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRepaso_Sabado_1
{
    public class Personaje
    {
        #region comentarios
        //atributos -> como es? Sustantivos

        //constructores -> instanciar en memoria el objeto

        //propiedades ->

        //metodos -> que hace el objeto? son verbos
        #endregion
        private string nombre;
        private int vida;
        private string[] ataques;

        //List<string> lista;
        public Personaje()
        {
            nombre = "Sin nombre";
            vida = 100;
            ataques = new string[3];
        }

        public Personaje(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Personaje(string nomb, int vida) : this(nomb)
        {
            this.vida = vida;
        }

        public Personaje(string nomb, int vida, string[] ataques) : this(nomb,vida)
        {
            nombre = nomb;
            this.vida = vida;
            this.ataques = ataques;
        }

        public string Nombre 
        { 
            get => nombre;  
        }
        public int Vida 
        { 
            get => vida;
        }

        public string[] Ataques
        {
            get => ataques;
        }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre es {nombre}");
            sb.AppendLine($"La vida es {vida}");

            return sb.ToString();
        }

        //propfull genera el private id con su public id get


    }
}
