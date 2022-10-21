using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            string trabajo;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());//para trabajar con cualquier otro tipo de dato que no sea string se utiliza el parser!!!!!

            Console.WriteLine("Ingrese su trabajo:");
            trabajo = Console.ReadLine();

            Console.WriteLine("El empleado se llama: {1} y su edad es : {0} su posicion de laboral es : {2}",edad,nombre,trabajo);
          
            //Console.ReadLine();El ingreso de un dato
            //Console.Clear(); Limpiar
        }
    }
}
