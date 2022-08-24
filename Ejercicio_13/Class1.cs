using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Validador
    {
        public static string mensaje2;
       

        public static bool ValidarRespuesta(string mensaje)
        {
            Boolean validor = false;

            if(mensaje == "s")
            {
                validor = true;
            }
            else
            {
                if(mensaje != "s")
                {
                    validor = false;
                }
            }

            return validor;
        }
    }
  
}
