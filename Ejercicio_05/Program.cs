using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            int numero;

            while(int.TryParse(Console.ReadLine(), out numero))
            {
                for(int centro = 1; centro < numero; centro++)
                {
                    int sumaAntes = 0;
                    for(int i = 0; i<centro; i++)
                    {
                        sumaAntes += i;
                    }

                    int sumaDespues = 0;
                    for(int j = centro + 1; j <= sumaAntes; j++ )
                    {
                        if((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                        {
                            break;
                        }
                        sumaDespues += j;
                    }

                    if(sumaAntes == sumaDespues)
                    {
                        Console.WriteLine("Es un centro numerico : {0}",centro);
                    }
                }
            }
            Console.WriteLine("No es un numero");
        }
    }
}
