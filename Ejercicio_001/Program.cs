using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            int acumulador = 0;

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                    acumulador = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;     
                        }
                    }
                }
                acumulador += numero;
            }
            promedio = (float)acumulador / 5;

            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El numero promedio es: {0}", promedio);
        }
    }
}
