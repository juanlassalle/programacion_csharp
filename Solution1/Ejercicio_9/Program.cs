using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        //Una compañía de seguros para autos ofrece dos tipos de póliza: cobertura amplia (A) y daños a terceros (B). 
        //Para el plan A, la cuota base es de $1,200, y para el B, de $950. A ambos planes se les carga
        //10% del costo si la persona que conduce tiene por hábito beber alcohol, 5% si utiliza lentes, 
        //5% si padece alguna enfermedad como deficiencia ardiaca o diabetes, y si tiene más de 40 años, se le carga
        //20%, de lo contrario sólo 10%. Todos estos cargos se realizan sobre el costo base. Determinar cuánto le cuesta 
        //a una persona contratar una póliza.
        static void Main(string[] args)
        {
            string tipoPoliza;
            string respuesta;
            decimal cuotaBase = 0m;
            decimal recargo = 0;
            decimal cuotaFinal;
            int edad;
            bool bebeAlcohol = false;
            bool usaLentes = false;
            bool padeceEnfermedad = false;
            bool edadValida = false;
            bool respuestaValida = false;

            

            do
            {
                Console.Write("Ingrese tipo de póliza (A o B): ");
                tipoPoliza = Console.ReadLine().ToUpper();

                if (tipoPoliza == "A")
                {
                    cuotaBase = 1200m;
                }
                else if (tipoPoliza == "B")
                {
                    cuotaBase = 950m;
                }
                else
                {
                    Console.WriteLine("Tipo de poliza no valida.");
                    
                }
               
            }
            while (tipoPoliza != "A" && tipoPoliza != "B");

            do
            {
                Console.Write("¿El conductor tiene por hábito beber alcohol? (S/N): ");
                respuesta = Console.ReadLine().ToUpper();

                respuestaValida = respuesta == "S" || respuesta == "N";

                if (respuestaValida)
                {
                    bebeAlcohol = (respuesta == "S");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese S o N.");
                }
            }
            while (!respuestaValida);

            do
            {
                Console.Write("¿Usa lentes? (S/N)");
                respuesta = Console.ReadLine().ToUpper();

                respuestaValida = respuesta == "S" || respuesta == "N";

                if( respuestaValida)
                {
                    usaLentes = (respuesta == "S");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese S o N.");
                }
            }
            while (!respuestaValida);

            do
            {
                Console.Write("¿Padece alguna enfermendad?: (S/N): ");
                respuesta = Console.ReadLine().ToUpper();
                respuestaValida = respuesta == "S" || respuesta == "N";

                if (respuestaValida)
                {
                    padeceEnfermedad = (respuesta == "S");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese S o N.");
                }
            }
            while (!respuestaValida);

            if (bebeAlcohol) recargo += cuotaBase * 0.10m;
            if (usaLentes) recargo += cuotaBase * 0.05m;
            if (padeceEnfermedad) recargo += cuotaBase * 0.05m;

            do
            {
                Console.Write("Ingrese edad del conductor: ");
                bool esNumero = int.TryParse(Console.ReadLine(), out edad);

                edadValida = esNumero && edad > 0;

                if (edadValida)
                {
                    if (edad > 40)
                    {
                        recargo += cuotaBase * 0.20m;
                    }
                    else
                    {
                        recargo += cuotaBase * 0.10m;
                    }
                }
                else
                {
                    Console.WriteLine("Edad no válida. Por favor, ingrese un número entero positivo.");
                }
            }
            while (!edadValida);

            cuotaFinal = cuotaBase + recargo;
            Console.WriteLine("\n--- RESUMEN ---");
            Console.WriteLine($"Cuota Base:  ${cuotaBase}");
            Console.WriteLine($"Recargos:    ${recargo}");
            Console.WriteLine($"El costo total de la póliza es: ${cuotaFinal}");
        }
    }
}
