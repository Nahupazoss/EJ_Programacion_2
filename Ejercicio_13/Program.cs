using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = 1;
            int num1;
            int num2;
            int suma;
            string mensaje;

            for(int i = 0; i < tam; i++)
            {
                Console.WriteLine("Ingrese el primer numero a sumar:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero a sumar:");
                num2 = int.Parse(Console.ReadLine());

                suma = num1 + num2;
                tam++;
                Console.WriteLine("La suma de los numeros ingresados es: {0}",suma);

                Console.WriteLine("Desea continuar sumando numeros? (si es asi ingrese una s)");
                Console.WriteLine("En caso de querer salir del programa ingrese culquier letra que no sea la s");
                mensaje = Console.ReadLine();

                if (Validador.ValidarRespuesta(mensaje) != true)
                {
                    break;
                }                
              
            }
        }
    }
}
