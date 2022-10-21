using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int tam = 1;
            int numeroPrimo = 0;
            int opcion = 0;
            string salida;
    

            do
            {
                Console.WriteLine("1)Ejercicio \n2)Salir");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        for (int i = 0; i < tam; i++)
                        {
                            Console.WriteLine("Ingrese un numero:");
                            numero = int.Parse(Console.ReadLine());
                            tam++;


                            if (numero / tam == 0)
                            {
                                numeroPrimo = numero;
                                Console.WriteLine("El numero es primo {0}", numeroPrimo);
                            }
                            else
                            {
                                Console.WriteLine("El numero no es primo");
                            }
                            Console.WriteLine("Desea salir del ejercicio?si ese es el caso ingrese salir,de lo contrario ingrese cualquier letra");
                            salida = Console.ReadLine();
                            if(salida == "salir")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    break;
                    case 2:
                    break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                    break;
                }
              
            } while(opcion != 2);

                



          

        
        }
    }
}
