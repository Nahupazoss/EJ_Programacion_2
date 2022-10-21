using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Hacha : Arma
    {
        private int cantidadHojas;

        public Hacha(int cantidadHojas,int daño) : base(daño)
        {
            this.cantidadHojas = cantidadHojas;
        }

        public int CantidadHojas { get => cantidadHojas; }

        public override string Ataque()
        {
            return $"Zaaaaaaazzzzz con {base.Daño} de damage!!!!";
        }
    }
}
