using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string Variable
            string myString = "Hello";

            // How to use var. Let the compiler identify the type. Hover over var to see..
            var place = "World";

            // string or String? string is an alias of class String
            string greet = String.Format(myString + " {0}", place);

            //adding strings
            var addStrings = myString + " " + place;

            Console.WriteLine(greet);
            Console.WriteLine(addStrings);

            // Whitespace
            var testingWhitespace       =       
                "olala";
            // When Whitespaces matters or not?
            Console.WriteLine(testingWhitespace);

            // Variables for numbers
            int myFirstValue = 43;
            double mySecondValue = 76.23;

            // What if i add an integer and a double? The integer is implicitly converted to be a double (43 -> 43.0)
            var sum = myFirstValue + mySecondValue;

            // Different versions of Console.Writeline
            Console.WriteLine(sum);
            Console.WriteLine(sum.ToString());

            // Mix and Match variables
            string myName = "John";
            int multiplier = 3;
            double myIncome = 1200.00;
            var myAge = 33;
            // String Interpolation
            Console.WriteLine($"my Age: {myAge}, multiplier: {multiplier}, my Income: {myIncome}, my Name: {myName}");

            // Variables can change values
            myName = "Bill";
            multiplier =63;
            myIncome = 400.00;
            myAge = 39;
            // True the can. Watch them side by side
            Console.WriteLine($"my Age: {myAge}, multiplier: {multiplier}, my Income: {myIncome}, my Name: {myName}");

            // Booleans is all about Truth. 3 + 2 == 5 will evaluate as true
            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine(myFirstBoolean);

            bool mySecondBoolean = 3 + 7 > 11;
            Console.WriteLine(mySecondBoolean);

            // Boolean Operators. && is the AND Operator, || is the OR operator
            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            bool oneIsTrue = myFirstBoolean || mySecondBoolean;

            // How to use substitution parameters, start counting from zero!
            Console.WriteLine("myFirstBoolean is {0}, mySecondBoolean is {1}", myFirstBoolean, mySecondBoolean);
            
            // The NOT Operator
            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine(reverseMyFirstBoolean);
        }
    }
}
