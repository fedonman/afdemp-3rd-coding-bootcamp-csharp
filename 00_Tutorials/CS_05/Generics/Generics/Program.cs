using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // By using a generic type parameter T you can write a single class that other client code can use 
        // without incurring the cost or risk of runtime casts or boxing operations
        private class ExampleClass { }
        static void Main(string[] args)
        {
            
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();

            // Part 2 Example with GenericList2
            // The following code example shows how client code uses the generic GenericList2<T> class to create a list of integers. Simply by changing the type argument, the following code could easily be modified to create lists of strings or any other custom type
            // int is the type argument
            GenericList2<int> list = new GenericList2<int>();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");
        }
    }
}
