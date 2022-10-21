using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGuerrero
{
    class Arco : ClaseArma
    {
        int distanciaMaxima;

        public Arco(int distanciaMaxima)
        {
            this.distanciaMaxima = distanciaMaxima;
        }
    }
}
