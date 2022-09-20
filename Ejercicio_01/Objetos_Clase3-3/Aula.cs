using System;

namespace Objetos_Clase3_3
{
    public class Aula
    {
        public string comision;
        public Materia materia;
        public Profesor docentes;
        public Alumno[] alumnos;

        private Aula(string comision, Materia materia, Profesor docentes)
        {
            this.comision = comision;
            this.materia = materia;
            this.docentes = docentes;
        }

        public Aula(string comision, Materia materia, Profesor docentes,int capacidad) : this(comision,materia,docentes)
        {
            this.alumnos = new Alumno[capacidad];
        }

        public Aula(string comision, Materia materia, Profesor docentes, Alumno[] alumnos) : this(comision, materia, docentes)
        {
            this.alumnos = alumnos;
        }

        public void AgregarAlumno(Alumno alumno1)
        {
           
        }
    }
}