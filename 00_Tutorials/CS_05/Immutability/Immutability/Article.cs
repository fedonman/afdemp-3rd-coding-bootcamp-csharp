using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    // C# supports immutability thanks to 2 keywords: const and readonly. 
    // They are used by the C# compiler to ensure that the state of a field won’t be changed once an object is created. 
    // Why 2 keywords? Because the readonly keyword allows state modification within constructor(s) while the const keyword doesn’t.
    class Article
    {
        const string m_Name = "Ballon";
        readonly int m_Price;

        Article(string name, int price)
        {
            //m_Name = name; // <- Compilation error
            m_Price = price;
        }
        
    }
}
