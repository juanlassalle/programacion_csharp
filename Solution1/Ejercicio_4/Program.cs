using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        //El dueño de un estacionamiento requiere determinar cuánto debe cobrar por el uso del estacionamiento a sus
        //clientes.Las tarifas son las siguientes:
        //Las dos primeras horas a $5 c/u
        //Las siguientes tres a $4 c/u
        //Las cincos siguientes a $3 c/u
        //Después de diez horas el costo por cada una es de dos pesos.
        static void Main(string[] args)
        {
            decimal costo = 0m;
            double horas = 0d;

            Console.Write("Ingrese la cantidad de horas estacionado: ");
            horas = Convert.ToDouble(Console.ReadLine());

            if(horas <= 2)
            {
                costo = (decimal)horas * 5m;
            }
            else if(horas <= 5)
            {
                costo = (decimal)2 * 5m + (decimal)(horas - 2) * 4m;
            }
            else if (horas <= 10)
            {
                costo = (decimal)2 * 5m + (decimal)3 * 4m + (decimal)(horas - 5) * 3m;
            }
            else
            {
                costo = (decimal)2 * 5m + (decimal)3 * 4m + (decimal)5 * 3m + (decimal)(horas - 10) * 2m;
            }

            Console.WriteLine();
            Console.Write($"El total a pagar es: ${costo}");
        }
    }
}
