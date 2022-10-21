using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Guerrero
    {
        private Arma armaElegida;
        private item itemElegido;

        public void CambiarArma(Arma arma)
        {
            this.armaElegida = arma;
        }

        public item Item
        {
            set { this.itemElegido = value; }
        }

        public string AtacarConArma()
        {
            if(armaElegida is null)
            {
                throw new Exception("No tenes Arma!!!!!");
            }
            return armaElegida.Ataque();
        }

        public string UsarItem()
        {
            if (itemElegido is null)
            {
                throw new Exception("No tenes el item!!!!!");
            }
            return itemElegido.UsarItem();
        }
    }
}
