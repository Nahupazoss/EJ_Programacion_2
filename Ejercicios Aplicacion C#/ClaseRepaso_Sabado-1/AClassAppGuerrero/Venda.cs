using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public class Venda : item
    {
        int cantidadUsosDisp;

        public Venda(int cantidadUsosDisp,string nombre) : base(nombre)
        {
            this.cantidadUsosDisp = cantidadUsosDisp;
        }

        public override string UsarItem()
        {
            cantidadUsosDisp--;
            if(cantidadUsosDisp > 0)
            {
                return $"Me estoy curando,me quedan {cantidadUsosDisp}";
            }
           else
            {
                return "No tienes vendas!";
            }

        }
    }
}
