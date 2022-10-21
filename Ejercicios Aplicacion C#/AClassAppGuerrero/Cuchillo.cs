using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Cuchillo : item
    {
        int largoHoja;

        public Cuchillo(int largoHoja) : base("Cuchillo")//le harcodeo el nombre
        {
            this.largoHoja = largoHoja;
        }

        public override string UsarItem()
        {
            return $"Soy un cuchillo de {largoHoja} cm";
        }
    }
}
