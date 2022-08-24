using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Class1
    {
        public static bool Validar(int valor,int min,int max)
        {
            Boolean validado = false;

            while(valor < -100 || valor > 100)
            {
                Console.WriteLine("Porfavor reingrese su numero: (debe estar en el rango de mayor a -100 o menor a 100)");
                valor = int.Parse(Console.ReadLine());

                if (valor > -100 || valor < 101)
                {
                    validado = true;
                   
                    
                }               
            }
            return validado;
        }
    }
}

