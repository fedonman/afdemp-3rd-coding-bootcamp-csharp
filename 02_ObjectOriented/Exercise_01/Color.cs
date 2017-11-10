using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int Luminocity()
        {
            // calculate luminosity
            return 1;
        }
    }
}
