using System;

namespace Objetos_Clase3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Nahuel", "Pazos", "12345");
            alumno1.SetNotaPrimerParcial(10);
            alumno1.SetNotaSegundoParcial(8);

            Alumno alumno2 = new Alumno("Juan", "Visini", "54321");
            alumno2.SetNotaPrimerParcial(7);
            alumno2.SetNotaSegundoParcial(8);

            Alumno alumno3 = new Alumno("Mateo", "Zarza", "21541");
            alumno3.SetNotaPrimerParcial(7);
            alumno3.SetNotaSegundoParcial(4);

            Alumno alumno4 = new Alumno("Agustin", "Scali", "03912");
            alumno4.SetNotaPrimerParcial(2);
            alumno4.SetNotaSegundoParcial(4);

            Alumno alumno5 = new Alumno("Carlos", "Camusso", "23157");
            alumno5.SetNotaPrimerParcial(4);
            alumno5.SetNotaSegundoParcial(4);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.WriteLine(alumno4.Mostrar());
            Console.WriteLine(alumno5.Mostrar());
        }
    }
}
