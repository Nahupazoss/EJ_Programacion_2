using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGuerrero
{
    class Espada : ClaseArma
    {
        int longitudHoja;

        public Espada(int longitudHoja)
        {
            this.longitudHoja = longitudHoja;
        }
    }
}
