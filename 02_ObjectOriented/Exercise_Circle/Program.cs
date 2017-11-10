using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            //Console.WriteLine($"radius: {c.Radius}, center: ({c.Center.X},{c.Center.Y}), Fill: {c.Fill}");

            Point p = new Point(5, 2);
            Console.WriteLine(p.Sum);
            Console.WriteLine(p.GetSum());

            Color red = new Color(255, 0, 0);
            c.SetFillColor(red);
            c.SetFillColor(new Color(0, 0, 0));
            c.SetFillColor(0, 0, 0);

            //Circle c1 = new Circle(2);
            //Console.WriteLine($"radius: {c1.Radius}, color: {c1.Color}");

            //Circle c2 = new Circle(5, "black");
            //Console.WriteLine($"radius: {c2.Radius}, color: {c2.Color}");

            //c2.SetRadius(10);
            //c2.SetColor("blue");

            Console.ReadKey();
        }
    }
}
