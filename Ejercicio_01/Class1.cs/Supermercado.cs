using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.cs
{
    public static class Supermercado
    {
       static string nombre;
       static List<Empleado> empleados;

        static Supermercado()
        {
            nombre = "SuperSABADOS";
            empleados = new List<Empleado>();
            HardcodearEmpleados();
        }
        
        private static void HardcodearEmpleados()
        {
            empleados.Add(new Empleado(1,"Nahuel","rufruf","asd123")); 
            empleados.Add(new Empleado(2, "Pepe", "Romeo", "gatusso123"));
        }

        public static bool LoguearEmpleado(string usuario,string pass)
        {
            bool resultado = false;

            foreach(Empleado auxEmpleado in empleados)
            {
                if(auxEmpleado.Usuario == usuario)
                {
                    resultado = auxEmpleado.CheckearPassword(pass);
                }
            }

            return resultado;
        }

        public static void ResgistrarEmpleados(string nombre,string usuario,string pass)
        {
            for(int i = 2; i < 100; i++)
            {
                empleados.Add(new Empleado(i,nombre, usuario, pass));
            }
        }

    }
}
