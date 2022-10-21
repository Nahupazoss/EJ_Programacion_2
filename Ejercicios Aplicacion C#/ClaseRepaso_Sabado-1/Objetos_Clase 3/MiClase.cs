using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_Clase_3
{
    class MiClase
    {
        public string cadena;
        public Int32 entero;

        public static double doble;


        public void MetodoInstancia()
        {
            Console.WriteLine("Nombre : {0} Edad: {1} Doble: {2}",this.cadena,this.entero,MiClase.doble);
            MiClase.doble++;
        }


        public MiClase(int entero,string cadena)
        {
            this.cadena = cadena;
            this.entero = entero;               
        }

        static MiClase()
        {
            MiClase.doble = 7;
        }


    }
}
