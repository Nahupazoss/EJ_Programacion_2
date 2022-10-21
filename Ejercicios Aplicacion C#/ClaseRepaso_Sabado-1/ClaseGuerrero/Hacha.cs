using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGuerrero
{
    class Hacha : ClaseArma
    {
        int cantidadHojas;

        public Hacha(int cantidadHojas)
        {
            this.cantidadHojas = cantidadHojas;
        }
    }
}
