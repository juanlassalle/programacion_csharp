using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        //Determinar el costo y el descuento que tendrá un artículo. Considere que si su precio
        //es mayor o igual a $200 se le aplica un descuento del 15%, y su precio es mayor a $100
        //pero menor a $200, el decuento es de 12%, y si es menor a $100, sólo 10%
        static void Main(string[] args)
        {
            Decimal precio;
            Decimal descuento;
            decimal costo;

            Console.Write("Ingrese el precio del producto: ");
            precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            if (precio >= 200)
            {
                descuento = precio * 0.15m;
                costo = precio - descuento;
            }
            else if(precio > 100 && precio < 200)
            {
                descuento = precio * 0.12m;
                costo = precio - descuento;
            }
            else
            {
                descuento = precio * 0.10m;
                costo = precio - descuento;
            }

            Console.Write("=========RESULTADOS=========\n");
            Console.Write($"El descuento del artículo es {descuento}\n");
            Console.Write($"El precio final del artículo es {costo}");
            Console.WriteLine();
        }
    }
}
