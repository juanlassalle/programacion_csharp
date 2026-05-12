using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    //Realice un Algoritmo para determinar el sueldo semanal de un trabajador
    //con base en la horas trabajadas y el pago por hora, considerando que
    //después de las 40 horas cada hora se considera como excedente y se
    //paga el doble
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            decimal pagoPorHora;
            int horasExtras;
            decimal sueldoTotal = 0m;

            Console.Write("Ingrese las horas trabajadas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el pago por hora: ");
            pagoPorHora = Convert.ToDecimal(Console.ReadLine());

            if (horasTrabajadas >= 40)
            {
                horasExtras = 40 - horasTrabajadas;

                sueldoTotal = (40 * pagoPorHora) + (horasExtras * pagoPorHora * 2);
                Console.Write($"El sueldo semanal del trabajador es: {sueldoTotal}");
            }
            else
            {
                sueldoTotal = horasTrabajadas * pagoPorHora;
                Console.Write($"El sueldo semanal del trabajador es: {sueldoTotal}");
            }
        }
    }
}
