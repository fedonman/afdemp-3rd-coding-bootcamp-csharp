using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int year = DateTime.Now.Year;
            int wantedLeapYears = 20;
            int counter = 0;

            // Main loop
            Console.WriteLine($"Next {wantedLeapYears} leap years from {year}");
            while (counter < wantedLeapYears)
            {
                // check if leap year
                if (year % 4 == 0)
                {
                    Console.Write($"{year}\t");
                    counter++;
                }
                year++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
