using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemoTM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string selection menu for the user
            string selection = String.Empty;

            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)arenheit to Celsius or Q)uit:");

                selection = Console.ReadLine();
                double farenheit, celsius = 0;

                switch (selection)
                {
                    // check if user inputs lower or uppercase
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temperature: ");
                        // the call to the static method without instantiating an object
                        farenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {farenheit:f2}");
                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;

                    case "q":
                    case "Q":
                        break;
                    // Always a good programming practice to have the default case
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}
