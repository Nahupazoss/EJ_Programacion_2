using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                cuadrado = Math.Pow(numero,2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("El cuadrado es: {0}", cuadrado);
                Console.WriteLine("El cubo es: {0}", cubo);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
