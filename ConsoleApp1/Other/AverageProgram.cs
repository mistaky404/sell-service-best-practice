using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Other
{
    public class AverageProgram
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to AverageProgram");

            Console.WriteLine("Inserte 4 Calificaciones");

            decimal calification1 = Convert.ToDecimal(Console.ReadLine());
            decimal calification2 = Convert.ToDecimal(Console.ReadLine());
            decimal calification3 = Convert.ToDecimal(Console.ReadLine());
            decimal calification4 = Convert.ToDecimal(Console.ReadLine());

            decimal average = (calification1 + calification2 + calification3 + calification4) / 4;

            if (average >= 90 && average <= 100)
            {
                Console.WriteLine("Promedio de Calificación es A");
            }
            else if (average >= 80 && average <= 89)
            {
                Console.WriteLine("Promedio de Calificación es B");
            }
            else if (average >= 70 && average <= 79)
            {
                Console.WriteLine("Promedio de Calificación es C");
            }
            else if (average >= 60 && average <= 69)
            {
                Console.WriteLine("Promedio de Calificación es D");
            }
            else if (average >= 0 && average <= 59)
            {
                Console.WriteLine("Promedio de Calificación es F");
            }
            else
            {
                Console.WriteLine("No Aplica");
            }
        }

    }
}
