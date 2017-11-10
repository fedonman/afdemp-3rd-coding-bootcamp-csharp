using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new list
            List<int> mylist = new List<int>();
            mylist.Add(5);
            mylist.Add(20);
            mylist.Add(30);

            int prwto_stoixeio = mylist[0];
            Console.WriteLine(prwto_stoixeio);

            mylist[0] = 10;
            Console.WriteLine(mylist[0]);

            mylist[5] = 40;

            Console.ReadKey();
        }
    }
}
