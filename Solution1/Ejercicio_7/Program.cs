using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        //El presidente de la república ha decidido estimular a todos los estudiantes de una universidad mediante 
        //la asignación de becas mensuales, para esto se tomarán en consideración los siguientes criterios: 
        //Para alumnos mayores de 18 años con promedio mayor o igual a 9, la beca será de $2000.00; con promedio mayor o igual a 7.5, beca
        //de 1000.00; para los promedios menores de 7.5 pero mayores o iguales a 6.0, de $500.00; a los demás se les enviará una carta 
        //de invitación incitándolos a que estudien más en el próximo ciclo escolar. A los alumnos de 18 años o menores de esta edad, 
        //con promedios mayores o iguales a 9, se les dará $3000; con promedios menores a 9 pero mayores o iguales a 8, $2000; 
        //para los alumnos con promedios menores a 8 pero mayores o iguales a 6, se les dará $100, y a los alumnos que tengan promedios 
        //menores a 6 se les enviará carta de invitación. 
        static void Main(string[] args)
        {
            int edad;
            decimal promedio;
            string carta = "";
            decimal beca = 0;

            Console.Write("Ingrese la edad del estudiante: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio del estudiante: ");
            promedio = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            if(edad > 18)
            {
                if(promedio >= 9m)
                {
                    beca = 2000.00m;
                }
                else if(promedio >= 7.5m)
                {
                    beca = 1000.00m;
                }
                else if(promedio >= 6.0m)
                {
                    beca = 500.00m;
                }
                else
                {
                    carta = "Se le invita a estudiar más en el próximo ciclo escolar";
                }
            }
            else
            {
                if(promedio >= 9)
                {
                    beca = 3000m;
                }
                else if(promedio >= 8)
                {
                    beca = 2000m;
                }
                else if(promedio >= 6)
                {
                    beca = 100m;
                }
                else
                {
                    carta = "Se le invita a participar";
                }
            }

            if(beca > 0)
            {
                Console.Write($"Alumno cuyo promedio es {promedio} y su edad es {edad}, recibe una beca de {beca}");
            }
            else
            {
                Console.Write($"Alumno cuyo promedio es {promedio} y su edad es {edad}, {carta}");
            }


            Console.WriteLine();
        }
    }
}
