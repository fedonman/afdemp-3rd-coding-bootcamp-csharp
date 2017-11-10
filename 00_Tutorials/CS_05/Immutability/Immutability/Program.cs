using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    // The important difference between a value type (like int or double) and a reference type (a class or struct) is that when a value type is passed to a function, a copy of the data is made. But when passing a reference type to a function, 
    // only a copy of the reference is made, but not of the underlying data.
    class Program
    {
        static void Main(string[] args)
        {
            MyMutableType mut = new MyMutableType(2);
            double d = MyMutableType.BadFunc(mut);
            Console.WriteLine(mut.x);
            //The console will print out '4' instead of '2', which was the value of x before the call to BadFunc.
            // Our object's data has changed, and we wouldn't even know it, if we didn't write BadFunc ourselves.
            // The reason is, that when we pass m to BadFunc, we do not create a copy of the object m, but only of the reference to the object m. 
            // Now m and the local copy t both reference the same object, and inside BadFunc, we can manipulate this object, 
            // and the changes are visible globally, as we can see when printing the value of x after the call to BadFunc

            MyImmutableType m = new MyImmutableType(2);
            MyImmutableType.TriesToBeBadFunc(m);
            Console.WriteLine(m.x);
            // The console will print out '2'.
            // There are no methods anymore in MyImmutableType which could change its state or data, 
            // so m cannot be manipulated through t anymore, and the assignment t = t.Square() inside the method simply assigns the new instance created by t.Square() to t, 
            // but because t is a copy of the reference m, this assignment only changes the reference t, and m stays unchanged.
        }
    }
}
