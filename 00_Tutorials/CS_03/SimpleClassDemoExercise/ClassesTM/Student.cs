using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTM
{
    // This class is a type and we can have as many Students as we want through objects. One Class - many Objects
    class Student
    {
        // enum for student's conduct
        public enum Conduct
        {
            poor,
            good,
            excellent
        }
        // Private member of type Conduct
        private Conduct conduct;

        //Properties. These are the data of this class and with them can interact methods of other classes
        public int Age { get; set; }
        public string Name { get; set; }
        public double Tuition { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        // Fields is members of a class
        // Encapsulation and data hiding indicate that the field Age should be private

        // This piece of code in modern C# has been replaced with the Properties Code above
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        // Methods should represent behavior. MyAge and SetAge aren't behaviors
        // We want something that looks like a field and acts like a method to this Student object
        // And that's when Properties come in...so we replace this commented code with Properties above
        
        //public int MyAge()
        //{
        //    return age;
        //}

        //public void SetAge(int someAge)
        //{
        //    age = someAge;
        //}

        // Constructor is a special method. It must have the name of the class and it doesn't return anything..not even void!
        public Student(int age, string name, double tuition, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Tuition = tuition;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }

        // Default Constructor
        public Student()
        {

        }

        // Method adds a behavior to the student
        public void RaiseTuition(double bonusPercent)
        {
            Tuition += Tuition * bonusPercent;
        }

        // Method to Set Conduct
        public void SetConduct(Conduct conduct)
        {
            // use of this keyword points directly to this class
            this.conduct = conduct;
        }

        // Method to calculate percentage that will raise Tuition based on  conduct
        public void CalculatePercentage()
        {
            switch (conduct)
            {
                case Conduct.poor:
                    RaiseTuition(0.10);
                    break;
                case Conduct.good:
                    RaiseTuition(0.05);
                    break;
                case Conduct.excellent:
                    RaiseTuition(0.01);
                    break;
                default:
                    Console.WriteLine("No Raise");
                    break;
            }
        }

    }
}
