using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory
{
    class Program
    {
        // How we define an enum
        enum Colors
        {
            Transparent = 0,
            White = 100,
            Black = 502,
            Red,
            Green,
            Blue
        }

        enum Gender
        {
            Male,
            Female,
            NotDefined
        }

        enum HttpError
        {
            NotFound = 404,
            ServerError = 500
        }

        static void Main(string[] args)
        {
            // How we declare a variable of enum type
            Colors myColor = Colors.Black;

            // Enums can be printed as string
            Console.WriteLine(myColor);

            // or as number
            Console.WriteLine((int)myColor);

            // What color is selected?
            // What we know: using if-else
            if (myColor == Colors.Transparent)
            {
                Console.WriteLine("No color");
            }
            else if (myColor == Colors.Black || myColor == Colors.White)
            {
                Console.WriteLine("Black & White");
            }
            else
            {
                Console.WriteLine("Colored");
            }


            // New way: switch
            switch (myColor)
            {
                case Colors.Transparent:
                    Console.WriteLine("No color");
                    break;
                case Colors.Black:
                case Colors.White:
                    Console.WriteLine("Black & White");
                    break;
                default:
                    Console.WriteLine("Colored");
                    break;
            }

            // How to declare constants
            const double PI = 3.14;

            // This produces error
            //PI = 4.2;

            Console.ReadKey();
        }
    }
}
