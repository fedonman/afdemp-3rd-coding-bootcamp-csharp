using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTM
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            int resultIterative = t.FibonacciIterative(12);
            Console.WriteLine(resultIterative);

            int resultNativeRecursive = t.FibonacciRecursive(12);
            Console.WriteLine(resultNativeRecursive);

            int resultOptimizedRecursive = t.FibonacciRecursiveOpt(12);
            Console.WriteLine(resultOptimizedRecursive);
        }
            

        private class Tester
        {
            //--------------- iterative version ---------------------    
            public int FibonacciIterative(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;

                int prevPrev = 0;
                int prev = 1;
                int result = 0;

                for (int i = 2; i <= n; i++)
                {
                    result = prev + prevPrev;
                    prevPrev = prev;
                    prev = result;
                }
                return result;
            }

            //--------------- naive recursive version --------------------- 
            public int FibonacciRecursive(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;

                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }

            //--------------- optimized recursive version ---------------------
            static Dictionary<int, int> resultHistory = new Dictionary<int, int>();

            public int FibonacciRecursiveOpt(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                if (resultHistory.ContainsKey(n))
                    return resultHistory[n];

                int result = FibonacciRecursiveOpt(n - 1) + FibonacciRecursiveOpt(n - 2);
                resultHistory[n] = result;

                return result;
            }
        }
    }
}
