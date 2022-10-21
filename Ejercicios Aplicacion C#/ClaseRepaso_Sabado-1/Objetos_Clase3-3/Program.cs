using System;

namespace Objetos_Clase3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("German");

            Profesor profesor = new Profesor("Curcio");

            Materia LaboII = new Materia("Laboratorio II");
            Materia progII = new Materia("Programacion II");

            Alumno[] alumno2D = new Alumno[]
            {
               alumno1,
               new Alumno("Juan"),
               new Alumno("Julieta")
            };

            Aula aula1 = new Aula("2D",LaboII,profesor,20);

            Aula aula2 = new Aula("2K", progII, profesor,20);
          

        }
    }
}
