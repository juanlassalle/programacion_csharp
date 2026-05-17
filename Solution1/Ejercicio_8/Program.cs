using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        //Cierta empresa proporciona un bono mensual a sus trabajadores, el cual puede ser por su antigüedad o bien por 
        //el monto de su sueldo (el que sea mayor), de la siguiente forma: Cuando la antigüedad es mayor a 2 años pero 
        //menor a 5, se otorga 20 % de su sueldo; cuando es de 5 años o más, 30 %. Ahora bien, el bono por concepto de sueldo, 
        //si éste es menor a $1000, se da 25 % de éste, cuando éste es mayor a $1000, pero menor o igual a $3500, se otorga 15% 
        //de su sueldo, para más de $3500. 10%. Realice el algoritmo correspondiente para calcular los dos tipos de bono, asignando 
        //el mayor
        static void Main(string[] args)
        {
            int antiguedad;
            decimal sueldo;
            decimal bonoAntiguedad;
            decimal bonoSueldo;
            decimal mayorBono;

            Console.Write("Ingrese antiguedad del trabajador: ");
            antiguedad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese sueldo del trabajador: ");
            sueldo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("==========BONO ANTIGUEDAD==========");

            if(antiguedad >= 5)
            {
                bonoAntiguedad = sueldo * 0.30m;
            }
            else
            {
                if (antiguedad > 2 && antiguedad < 5)
                {
                    bonoAntiguedad = sueldo * 0.20m;
                }
                else
                {
                    bonoAntiguedad = 0;
                }
            }
        Console.WriteLine($"El bono por antiguedad es ${bonoAntiguedad}");
            Console.WriteLine("==========BONO SUELDO==========");

            if (sueldo > 3500m)
            {
                bonoSueldo = sueldo * 0.10m;
            }
            else
            {
                if( sueldo > 1000m)
                {
                    bonoSueldo = sueldo * 0.15m;
                }
                else
                {
                    bonoSueldo = sueldo * 0.25m;
                }
            }
            Console.Write($"El bono sueldo es ${bonoSueldo}");

            if(bonoAntiguedad > bonoSueldo)
            {
                mayorBono = bonoAntiguedad;
            }
            else
            {
                mayorBono = bonoSueldo;
            }

            Console.WriteLine($"\nEl mayor bono es ${mayorBono}");
            Console.WriteLine();
        }
    }
}
