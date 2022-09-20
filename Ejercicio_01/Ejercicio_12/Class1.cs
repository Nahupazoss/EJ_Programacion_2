using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            string mensajeALeer;
            mensajeALeer = ArmarFormatoMensaje();
            return mensajeALeer;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        static string ArmarFormatoMensaje()
        {
            int largo = Sello.mensaje.Length;
            string formato = "";
            string textoFormato = "";

            if (largo != 0)
            {
                for (int i = 0; i < (largo + 2); i++)
                {
                    formato = formato + "*";

                }

                textoFormato = formato + "\n*" + Sello.mensaje + "*\n" + formato;
            }

            return textoFormato;
        }
    }
}
