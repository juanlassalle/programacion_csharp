using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        //Se tiene el nombre y la edad de tres personas. Se desea saber el nombre y la edad de 
        //la persona de menor edad
        static void Main(string[] args)
        {
            string nombreA, nombreB, nombreC, nombreMenor;
            int edadA, edadB, edadC,edadMenor;

            Console.Write("Ingrese el nombre de la primera persona: ");
            nombreA = Console.ReadLine();
            Console.Write("Ingrese la edad de la primera persona: ");
            edadA = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre de la segunda persona: ");
            nombreB = Console.ReadLine();
            Console.Write("Ingrese la edad de la segunda persona: ");
            edadB = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre de la tercera persona: ");
            nombreC = Console.ReadLine();
            Console.Write("Ingrese la edad de la tercera persona: ");
            edadC = int.Parse(Console.ReadLine());


            if (edadA < edadB && edadA < edadC)
            {
                edadMenor = edadA;
                nombreMenor = nombreA;
            }
            else if (edadB < edadA && edadB < edadC) 
            {
                edadMenor = edadB;
                nombreMenor = nombreB;
            }
            else
            {
                edadMenor = edadC;
                nombreMenor = nombreC;
            }

            Console.WriteLine();
            Console.Write($"La persona de menor edad es {nombreMenor},y su edad es {edadMenor}");

            //Console.ReadKey();
        }
    }
}
