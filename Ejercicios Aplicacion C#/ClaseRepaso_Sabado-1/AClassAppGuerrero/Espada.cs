using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Espada : Arma
    {
        private int longitudHoja;

        public Espada(int longitudHoja,int daño) : base(daño) 
        {
            this.longitudHoja = longitudHoja;
        }

        public int LongitudHoja { get => longitudHoja; }

        public override string Ataque()
        {
            return $"Espadazooo con {base.Daño} de damage!!!!";
        }
    }
}
