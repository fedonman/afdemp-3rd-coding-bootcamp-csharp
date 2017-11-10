using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // To implement abstraction let's take an example of a car. We knows a car, Car is made of name of car, color of car, steering, 
    // gear, rear view mirror, brakes, silencer, exhaust system, diesal engine, car battery, car engine and other internal machine details etc.
    // Now lets think in terms of Car rider or a person who is riding a car. So to drive a car what a car rider should know from above category before he starts a car driving.

    // Necessary things means compulsary to know before starting a car
    // 1. Name of Car
    // 2. Color of Car
    // 3. Steering

    // Unnecessary things means  not that compulsary to know for a Car rider
    // 1. Internal Details of a Car
    // 2. Car Engine
    class Car
    {
        private string _nameofcar = "My Car";
        private string _colorofcar = "Red";

        public string NameofCar
        {
            get
            {
                return _nameofcar;
            }
            set
            {
                _nameofcar = value;
            }
        }

        public string ColorofCar
        {
            get
            {
                return _colorofcar;
            }
            set
            {
                _colorofcar = value;
            }
        }

        public void Steering()
        {
            Console.WriteLine("Streering of Car");
        }

        private void InternalDetailsofCar()
        {
            Console.WriteLine("InternalDetailsofCar of Car");
        }

        private void CarEngine()
        {
            Console.WriteLine("CarEngine of Car");
        }
    }
    // As you can see from above code that necessary methods and properties exposed by using "public" access modifier 
    // and unnecessary methods and properties (not compulsary) hidden by using "private" access modifier.
    // To achieve abstraction we used access modifier "public" to expose some methods and properties to outside the class or world
    // To achieve abstraction we used access modifier "private" to hide some methods and properties from outside the class or world
}
