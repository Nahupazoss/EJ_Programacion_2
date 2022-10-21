using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHoras = 0;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            int importeACobrar = 0;
            int tamanio = 1;
            int respuesta;
            int importeTotal = 0;

            for(int i=0;i<tamanio;i++)
            {
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su valor de horas:");
                valorHoras = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su antiguedad:");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su cantidad de horas trabajadas:");
                horasTrabajadas = int.Parse(Console.ReadLine());

                importeACobrar = (valorHoras * horasTrabajadas) + antiguedad * 150;
                importeTotal = importeACobrar * tamanio;

                Console.WriteLine("El empleado {0} con la antiguedad de {1} tiene un valor de hora de {2} y tiene un total a cobrar bruto de ${3}", nombre, antiguedad, valorHoras, importeACobrar);
                Console.WriteLine("El pago total a todos los empleados es de: ${0}",importeTotal);

                Console.WriteLine("Desea continuar? 1-si 2-no");
                respuesta = int.Parse(Console.ReadLine());

                if(respuesta != 1)
                {
                    break;
                }
                tamanio++;
            }                             
        }
    }
}
