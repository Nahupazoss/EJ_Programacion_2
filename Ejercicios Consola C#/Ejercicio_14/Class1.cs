using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Class1
    {
        public static long ConvertirDecimalABinario(int numeroEntero)
        {
            long binario = 0;

            const int DIVISOR = 2;
            long digito = 0;
             
            for(int i = numeroEntero % DIVISOR, j = 0; numeroEntero > 0; numeroEntero /= DIVISOR , i = numeroEntero % DIVISOR , j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }

            return binario;
        }
    }

    /*public static int BinarioDecimal(long binario)
    {
        int numero = 0;
        int digito = 0;
        const int DIVISOR = 10;

        for(long i = binario, j = 0; i > 0; i /= DIVISOR,j++)
        {
            digito = (int)i % DIVISOR;

            if(digito != 1 && digito != 0)
            {
                return -1;
            }
            numero += digito * (int)Math.Pow(2, j);
        }
        return numero;
     }*/


}
