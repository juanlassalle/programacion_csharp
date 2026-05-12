using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_1
{
    //Realice un algoritmo para determinar si una persona puede votar con base
    //en su edad en las próximas elecciones
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese edad de la persona: ");
            int edad = Convert.ToInt32(Console.ReadLine());


            if ( edad >= 18) 
            { 
                Console.Write("La persona puede votar en las próximas elecciones");
            }
            else if (edad >= 0)
            {
                Console.Write($"La persona le faltan {18 - edad} años para votar");
            }
            else
            {
                Console.Write("Edad no válida");
            }

            Console.ReadKey();

        }
    }
}
