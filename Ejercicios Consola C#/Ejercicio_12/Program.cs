using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola Mundo!";

            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();

            Sello.Borrar();

            Console.ReadKey();

            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "HOLAAAA!";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());
        }
    }
}
