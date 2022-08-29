using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            long binario;

            Console.WriteLine("Ingrese un numero:");
            numeroEntero = int.Parse(Console.ReadLine());

            binario = Class1.ConvertirDecimalABinario(numeroEntero);

            Console.WriteLine("\nEl numero decimal {0} en binario es {1} ",numeroEntero,binario);

        }
    }
}
