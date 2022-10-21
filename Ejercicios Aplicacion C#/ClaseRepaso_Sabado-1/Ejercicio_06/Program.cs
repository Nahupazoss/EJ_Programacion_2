using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            int counter = 0;
            int i = 2;

            while(counter != 4)
            {
                int cheker = 0;

                for(int j = 1;j < i; j++)
                {
                    if(i % j == 0)
                    {
                        cheker += j;
                    }           
                }

                if (i == cheker)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                i++;
            }                   
        }
    }
}
