using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanio = 5;
            int crear = 0;
            string triangulo = "*";

            while(crear < 7)
            {
                Console.WriteLine("");
                triangulo = "*" + triangulo + "*";
                tamanio--;
            }


        }
    }
}
