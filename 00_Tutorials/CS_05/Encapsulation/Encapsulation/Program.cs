using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // public Rectangle
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            // In the preceding example, the member variables length and width are declared public, so they can be accessed 
            // from the function Main() using an instance of the Rectangle class, named r
            // The member function Display() and GetArea() can also access these variables directly without using any instance of the class.
            // The member functions Display() is also declared public, so it can also be accessed from Main() using an instance of the Rectangle class, named r.

            // private Rectangle
            RectanglePrivate rPrive = new RectanglePrivate();
            rPrive.Acceptdetails();
            rPrive.Display();
            Console.ReadLine();
            // In the preceding example, the member variables length and width are declared private, so they cannot be accessed from the function Main(). 
            // The member functions AcceptDetails() and Display() can access these variables. Since the member functions AcceptDetails() and Display() are declared public, 
            // they can be accessed from Main() using an instance of the Rectangle class, named r.
        }
    }
}
