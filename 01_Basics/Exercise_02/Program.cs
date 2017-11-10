using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input
            Console.Write("Give me a positive number: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Numbers must be positive! Give me second number: ");
                n = int.Parse(Console.ReadLine());
            }

            // Write caption
            Console.WriteLine($"List of primes until {n}");

            // for each number until n
            for (int i = 1; i <= n; i++)
            {
                // assume it is prime
                bool prime = true;
                // for the range [2, i-1]
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    // check if divisable
                    if (i % y == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                // if prime print number
                if (prime)
                {
                    Console.Write($"{i}\t");
                }
            }
            Console.ReadKey();
        }
    }
}
