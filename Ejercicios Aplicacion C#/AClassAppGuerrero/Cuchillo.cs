using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Cuchillo : item , IArma
    {
        int largoHoja;

        public Cuchillo(int largoHoja) : base("Cuchillo")//le harcodeo el nombre
        {
            this.largoHoja = largoHoja;
        }

        public override string UsarItem()
        {
            return $"El cuchillo con un largo de hoja de {largoHoja}";
        }
        public string AtacarConArma()
        {
            return "Estoy usando el cuchillo como arma";
        }

    }
}
