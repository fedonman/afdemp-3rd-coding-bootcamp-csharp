using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome, " + name);

            Console.WriteLine("How many hours have you studied yesterday?");
            int hoursOfStudy = int.Parse(Console.ReadLine());

            if (hoursOfStudy > 4)
            {
                Console.WriteLine("You studied well!");
            }
            else
            {
                Console.WriteLine("You need to study more!");
            }
        }
    }
}
