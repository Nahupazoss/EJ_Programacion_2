using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangoMin = -100;
            int rangoMax = 100;
            int numeroIngresado;
            int min = 0;
            int max = 0;

            for(int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeroIngresado = int.Parse(Console.ReadLine());

                if(Class1.Validar(numeroIngresado, rangoMin, rangoMax) == true)
                {
                    max = numeroIngresado;
                    min = numeroIngresado;
                }

                if(numeroIngresado > max)
                {
                    max = numeroIngresado;
                }
                else
                {
                    if(numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }
                }
            }
            Console.WriteLine("El numero maximo ingresado fue: {0}", max);
            Console.WriteLine("El numero minimo ingresado fue: {0}", min);
        }
    }
}
