using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Hacha : Arma , IUtilidad
    {
        private int cantidadHojas;

        public Hacha(int cantidadHojas,int daño) : base(daño)
        {
            this.cantidadHojas = cantidadHojas;
        }

        public int CantidadHojas { get => cantidadHojas; }

        public override string AtacarConArma()
        {
            return $"Zaaaaaaazzzzz con {base.Daño} de damage!!!!";
        }

        public string UsarItem()
        {
            return "Estoy usando el hacha como item";
        }
    }
}
