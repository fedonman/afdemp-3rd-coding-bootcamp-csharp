using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. a)
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before -- a: {a}, b: {b}");
            Utilities.Swap(ref a, ref b);
            Console.WriteLine($"After -- a: {a}, b: {b}");

            // 1. b)
            string x = "xxx";
            string z = "zzz";
            Console.WriteLine($"Before -- x: {x}, z: {z}");
            Utilities.Swap(ref x, ref z);
            Console.WriteLine($"After -- x: {x}, z: {z}");

            // 2. a)
            List<int> listA = new List<int>() { 1, 5, 5, 3, 4, 4, 4, 4, 6, 6, 6, 6, 6 };
            List<int> resultA = Utilities.Subsequence(listA);

            Console.Write("Subsequence of integers: ");
            foreach (int i in resultA)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            // 2. b)
            List<string> listB = new List<string>() { "tree", "tree", "house", "park", "park", "park", "house", "house" };
            List<string> resultB = Utilities.Subsequence<string>(listB);

            Console.Write("Subsequence of generics with T=string: ");
            foreach (string i in resultB)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            List<string> result = listB.GetSubsequence();
            Console.Write("Subsequence of generics with T=string: ");
            foreach (string i in result)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
