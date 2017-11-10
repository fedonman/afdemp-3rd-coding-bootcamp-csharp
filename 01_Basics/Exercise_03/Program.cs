using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.Write($"{y} x {i} = {i * y}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
