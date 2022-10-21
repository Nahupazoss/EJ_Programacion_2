using System;

namespace Objetos_Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase(27, "Nahuel");

            obj.MetodoInstancia();

            MiClase obj2 = new MiClase(13,"Pazos");

            obj2.MetodoInstancia();
        }
    }
}
