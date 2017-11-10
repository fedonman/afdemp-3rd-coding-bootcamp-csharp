using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointersDemoTM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal pointer to an object.  
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            // Must be in unsafe code to use interior pointers. 
            // Open Properties window, select build tab and check allow unsafe code 
            unsafe
            {
                // Must pin object on heap so that it doesn't move while using interior pointers.  
                fixed (int* p = &a[0])
                {
                    // p is pinned as well as object, so create another pointer to show incrementing it.  
                    int* p2 = p;
                    Console.WriteLine(*p2);
                    // Incrementing p2 bumps the pointer by four bytes due to its type ...  
                    p2 += 1;
                    Console.WriteLine(*p2);
                    p2 += 1;
                    Console.WriteLine(*p2);
                    Console.WriteLine("--------");
                    Console.WriteLine(*p);
                    // Deferencing p and incrementing changes the value of a[0] ...  
                    *p += 1;
                    Console.WriteLine(*p);
                    *p += 1;
                    Console.WriteLine(*p);
                }
            }

            Console.WriteLine("--------");
            Console.WriteLine(a[0]);
            Console.ReadLine();

            // Output:  
            //10  
            //20  
            //30  
            //--------  
            //10  
            //11  
            //12  
            //--------  
            //12
        }
    }
}
