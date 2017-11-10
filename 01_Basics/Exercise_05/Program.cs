using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read cost of purchase
            Console.Write("Give the cost of purchase: ");
            int cost = int.Parse(Console.ReadLine());
            while (cost <= 0)
            {
                Console.Write("Give a positive cost: ");
                cost = int.Parse(Console.ReadLine());
            }

            // Read amount paid by customer
            Console.Write("Give the amound paid: ");
            int paid = int.Parse(Console.ReadLine());
            while (paid < cost)
            {
                Console.Write("Give a sufficient amount: ");
                paid = int.Parse(Console.ReadLine());
            }

            // Calculate change
            int change = paid - cost;

            // If change is 0, then exit
            if (change == 0)
            {
                Console.WriteLine("No change needed");
                Console.ReadKey();
                return;
            }

            // Else, calculate number of bills and coins
            Console.WriteLine($"Change of ${change} is given:");
            int n50 = change / 50;
            change = change % 50;

            int n20 = change / 20;
            change = change % 20;

            int n10 = change / 10;
            change = change % 10;

            int n05 = change / 5;
            change = change % 5;

            int n02 = change / 2;
            change = change % 2;

            int n01 = change;

            // Print the results
            Console.WriteLine($"{n50} x $50");
            Console.WriteLine($"{n20} x $20");
            Console.WriteLine($"{n10} x $10");
            Console.WriteLine($"{n05} x $5");
            Console.WriteLine($"{n02} x $2");
            Console.WriteLine($"{n01} x $1");
            Console.ReadKey();
        }
    }
}
