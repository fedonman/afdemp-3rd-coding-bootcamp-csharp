using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is my simple implementation, which can only store integers
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(2);
            list.Add(10);
            Console.WriteLine(list.Print());

            int? a = list.RemoveLast();
            Console.WriteLine(list.Print());
            Console.WriteLine(a);

            // this is my generic implementation, which can store any type of data
            LinkedListGeneric<string> list2= new LinkedListGeneric<string>();
            list2.Add("first");
            list2.Add("second");
            Console.WriteLine(list2.Print());


            // this is the implementation of .NET Framework in System.Collections.Generic
            List<int> mylist = new List<int>();
            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(6);
            // it has various useful methods
            Console.WriteLine(mylist.Contains(4));
            Console.WriteLine(mylist.IndexOf(6));
            // access a single element using [index]
            // read
            Console.WriteLine(mylist[0]);
            // or write
            mylist[0] = 10;
            // but always index < Count or else
            // it will throw Exception
            // Console.WriteLine(mylist[5]);


            Console.ReadKey();
        }
    }
}
