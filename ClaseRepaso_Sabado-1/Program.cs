using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRepaso_Sabado_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARA DEBUGEAR PARAS SOBRE LINEA F9 Y CON F11 ENTRAS A CADA CAMPO O F10 RAPIDO
            List<Personaje> listaPersonajes = new List<Personaje>();

            string[] ataquesBasicos = new string[3]
            {
                "fuego","Ataque matrices","c#"
            };

            Personaje p1 = new Personaje(); //primero recerva espacio en memoria //crea ese espacio de memoria y asigna a esa variable personaje
            Personaje p2 = new Personaje("Nahuel", 40);
            Personaje p3 = new Personaje("Martina");
            Personaje p4 = new Personaje("Alan",10,GenerarArrayDeAtaques());

            listaPersonajes.Add(p1);
            listaPersonajes.Add(p2);
            listaPersonajes.Add(p3);
            listaPersonajes.Add(p4);
            listaPersonajes.Add(new Personaje("Juanchi", 50));

            foreach(Personaje auxPersonaje in listaPersonajes) //variable = Personaje item = auxPersonaje collection = listaPersonajes
            {
                 Console.WriteLine(auxPersonaje.MostrarInformacion());         
            }

            //MostrarPersonaje(p1, "Info Personaje 1");
            //MostrarPersonaje(p2, "Info Personaje 2");
            //MostrarPersonaje(p3, "Info Personaje 3");
            //Console.WriteLine(p4.Ataques[0]);

            //personaje.nombre = "pepe"; //SETTER

            //string nombrePersonaje = personaje.Nombre; //GETTER
        }

        private static string[] GenerarArrayDeAtaques()
        {
            return new string[3] {"Ataque Fuego","Ataque Agua","Ataque Tierra"};
        }
        private static void MostrarPersonaje(Personaje personaje,string info)
        {
            Console.WriteLine(info);
            Console.WriteLine(personaje.MostrarInformacion());
        }
    }
}
