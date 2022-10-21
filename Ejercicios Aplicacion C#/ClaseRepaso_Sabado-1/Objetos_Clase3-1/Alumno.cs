using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_Clase3_1
{
    class Alumno
    {
        private string legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public void SetNotaPrimerParcial(int nota1)
        {
            this.notaPrimerParcial = nota1;
        }

        public void SetNotaSegundoParcial(int nota2)
        {
            this.notaSegundoParcial = nota2;
        }

        public Alumno(string nombreIngresado,string apellidoIngresado,string legajoIngresado)
        {
            this.nombre = nombreIngresado;
            this.apellido = apellidoIngresado;
            this.legajo = legajoIngresado;
        }

        static Alumno()
        {
            Alumno.random = new Random();
        }

        private double CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            int retorno = -1;

            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                retorno = Alumno.random.Next(6, 10);
            }


            return retorno;
        }

        public string Mostrar()
        {
            int notaFinal = this.CalcularNotaFinal();
            double promedio = this.CalcularPromedio();
            string stringNotaFinal = "";

            if(notaFinal == -1)
            {
                stringNotaFinal = "Alumno desaprobado";
            }
            else
            {
                stringNotaFinal = notaFinal.ToString();
            }

            StringBuilder informacionAlumno = new StringBuilder();

            informacionAlumno.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} Legajo: {this.legajo}");
            informacionAlumno.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} \nNota segundo parcial: {this.notaSegundoParcial}");
            informacionAlumno.AppendLine($"Promedio: {promedio}");
            informacionAlumno.AppendLine($"Nota final: {stringNotaFinal}");

            return informacionAlumno.ToString();
        }
    }
}
