using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public abstract class Arma
    {
        private int daño;

        public Arma(int daño)
        {
            this.daño = daño;
        }

        public int Daño { get => daño; }

        public abstract string Ataque();//lo asigna cada una de las clases que hereden de arma
    }
}
