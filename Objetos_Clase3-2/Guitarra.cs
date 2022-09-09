using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_Clase3_2
{
    public class Guitarra
    {
        //atributos SUSTANTIVOS
        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;


        public Guitarra(string marca,int precio)
        {
            this.marca = marca;
            this.precio = precio;
            material = "NO CARGADO";//hardcodeado por defecto
        }

        public Guitarra(string marca, int precio, string material) : this(marca,precio)
        {
            this.material = material;
        }

        public Guitarra(string marca, int precio, string material, bool estaAfinada, int cantidadCuerdas) : this(marca,precio,material)
        {
            this.estaAfinada = estaAfinada;
            this.cantidadCuerdas = cantidadCuerdas;
        }

        public Guitarra(string marca,int precio,bool estaAfinada) : this(marca,precio)
        {
            this.estaAfinada = estaAfinada; 
        }

        //cntrl . resume el codigo
        // comportamientos 
        public bool AfinarGuitarra()
        {
            estaAfinada = true;
            return estaAfinada;
        }
         
        public void SubirDePrecio(string marca, int aumento, string material)
        {
            if (marca == "Gibson" || marca == "Fender" || material != "Roble")
            {
                precio *= aumento;
            }
        }

        public void SubirDePrecio(int aumento, int numeroCuerdas = 6)
        {
            if (numeroCuerdas == cantidadCuerdas)
            {
                precio *= aumento;
            }
        }


    }
}
