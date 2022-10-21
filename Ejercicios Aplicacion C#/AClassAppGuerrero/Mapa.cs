using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Mapa : item
    {
        bool tieneTesoros;

        public Mapa(bool tieneTesoros,string nombre) : base(nombre)
        {
            this.tieneTesoros = tieneTesoros;
        }

        public override string UsarItem()
        {
            string mensaje;
            Random random = new Random();
            int entero = random.Next(0, 100);

            if (entero % 2 == 0)
            {
                mensaje = "Marca muchos tesoros en el mapa";
            }
            else
            {
                mensaje = "Tu eres el tesoro rey/reyna";
            }

            return mensaje;
        }
    }
}
