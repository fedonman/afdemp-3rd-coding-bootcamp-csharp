using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    class MyMutableType
    {
        public double x;
        public MyMutableType(double _x) { x = _x; }
        public void Square() { x = x * x; }

        public static double BadFunc(MyMutableType t)
        {
            t.Square();
            return t.x;
        }
    }
}
