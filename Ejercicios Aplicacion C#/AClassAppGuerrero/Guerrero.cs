using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Guerrero
    {
        private IArma armaElegida;
        private IUtilidad itemElegido;

        public void CambiarArma(IArma arma)
        {
            this.armaElegida = arma;
        }

        public IUtilidad Item
        {
            set { this.itemElegido = value; }
        }

        public string AtacarConArma()
        {
            if(armaElegida is null)
            {
                throw new Exception("No tenes Arma!!!!!");
            }
            return armaElegida.AtacarConArma();
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
