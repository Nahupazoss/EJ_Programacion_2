﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassAppGuerrero
{
    public abstract class item : IUtilidad
    {
        string nombre;

        protected item(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract string UsarItem();
   
    }
}
