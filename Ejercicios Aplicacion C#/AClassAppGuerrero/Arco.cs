using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Arco : Arma
    {
        private int distanciaMaxima;

        public Arco(int distanciaMaxima, int daño) : base(daño)
        {
            this.distanciaMaxima = distanciaMaxima;
        }

        public override string Ataque()
        {
            return $"Piuum piuum piuum con {base.Daño} de damage!!!!";
        }
    }
}
