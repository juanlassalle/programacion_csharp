using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        //El 14 de febrero una persona desea comprarle un regalo al ser querido que más aprecia en ese
        //momento, su dilema radica en qué regalo puede hacerle, las alternativas que tiene son las siguientes
        //Regalo			Costo
        //Tarjeta			$10.00 o menos
        //Chocolates		$11.00 a $100.00
        //Flores			$101.00 a $250.00
        //Anillo			Más de $251.00
        //Se requiere determinar qué regalo se le puede comprar a ese ser tan especial por el día
        //del amor y la amistad.
        static void Main(string[] args)
        {
            decimal dineroDisponible;
            string regalo = "";

            Console.Write("Ingrese el dinero disponible para comprar el regalo: ");
            dineroDisponible = decimal.Parse(Console.ReadLine());

            if (dineroDisponible > 251.00m)
            {
                regalo = "Se puede regalar un anillo";
            }
            else if (dineroDisponible > 101.00m)
            {
                regalo = "Se pueden regalar flores";
            }
            else if (dineroDisponible > 11.00m)
            {
                regalo = "Se pueden regalar chocolates";
            }
            else
            {
                regalo = "Se puede regalar una tarjeta";
            }

            Console.WriteLine();
            Console.Write($"Con el dinero disponible de ${dineroDisponible}. {regalo}");

            Console.ReadKey();
        }
     }
}
