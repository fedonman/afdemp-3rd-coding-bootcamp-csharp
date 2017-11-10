using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    class MyImmutableType
    {
        public readonly double x;
        public MyImmutableType(double _x)
        {
            x = _x;
        }
        public MyImmutableType Square()
        {
            return new MyImmutableType(x * x);
        }


        public static double TriesToBeBadFunc(MyImmutableType t)
        {
            t = t.Square();
            return t.x;
        }
    }
}
