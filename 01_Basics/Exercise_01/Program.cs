using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration of variables
            int x, y, sum = 0;

            // input of first integer
            Console.WriteLine("Give me first number: ");
            x = int.Parse(Console.ReadLine());
            while (x < 0)
            {
                Console.WriteLine("Numbers must be positive! Give me first number: ");
                x = int.Parse(Console.ReadLine());
            }

            // input of second integer
            Console.WriteLine("Give me second number: ");
            y = int.Parse(Console.ReadLine());
            while (y < 0)
            {
                Console.WriteLine("Numbers must be positive! Give me second number: ");
                y = int.Parse(Console.ReadLine());
            }

            // find min and max
            int min = Math.Min(x, y);
            int max = Math.Max(x, y);

            // main loop
            for (int i = min; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }

            // print sum
            Console.WriteLine($"Sum of multiples of 3 between {min} and {max} is {sum}");
            Console.ReadKey();
        }
    }
}
