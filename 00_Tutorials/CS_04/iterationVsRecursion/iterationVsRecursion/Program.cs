using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationVsRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            int xFactorialRecursive = t.FactorialRecursive(3);
            Console.WriteLine(xFactorialRecursive);

            int xRecursivexFactorialIterative = t.FactorialIterative(3);
            Console.WriteLine(xRecursivexFactorialIterative);

            // Replace Recursion with Iteration
            CountDown c = new CountDown();
            c.countDown(10);

            CountDownIterative c2 = new CountDownIterative();
            c2.countDown(10);
        }
    }

    internal class Tester
    {
        //recursive function calculates n!
        public int FactorialRecursive(int n)
        {
            if (n <= 1) return 1;
            return n * FactorialRecursive(n - 1);
        }

        //iterative function calculates n!
        public int FactorialIterative(int n)
        {
            int sum = 1;
            if (n <= 1) return sum;
            while (n > 1)
            {
                sum *= n;
                n--;
            }
            return sum;
        }
    }
}
