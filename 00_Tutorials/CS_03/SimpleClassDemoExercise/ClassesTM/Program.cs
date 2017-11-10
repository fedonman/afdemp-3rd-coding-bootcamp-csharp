using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTM
{
    class Program
    {
        static void Main(string[] args)
        {
            // An instance of a Student or an Object. These are Synonyms
            Student Peri = new Student();
            // 1.Simple assign data to the object 
            Peri.Age = 22;
            Peri.Name = "Aidinopoulos";
            Console.WriteLine("Peri's Age is {0} and his Name is {1}", Peri.Age, Peri.Name);

            // 2. Initialization. When we create the object we also initialize one or more of it's properties
            Student Kostas = new Student()
            {
                Age = 44,
                Tuition = 560.00,
                Name = "Papadopoulos",
                StartingDate = new DateTime(2012, 3, 31),
                PhoneNumber = "210-2222222"
            };

            Console.WriteLine("Kostas's Age is {0} and his Name is {1}, he pays {2} and started studying in {3}", Kostas.Age, Kostas.Name, Kostas.Tuition, Kostas.StartingDate);
            Kostas.RaiseTuition(0.05);
            Console.WriteLine("Kostas's Age is {0} and his Name is {1}, he pays {2} and started studying in {3}", Kostas.Age, Kostas.Name, Kostas.Tuition, Kostas.StartingDate);
            // 3. Constructor adds or creates data to the object
            Student Eirini = new Student(19, "Eirini", 655.00, new DateTime(2013, 3, 23), "545454");

            Eirini.SetConduct(Student.Conduct.good);
            Eirini.CalculatePercentage();
            Console.WriteLine("Eirin's Tuition is {0} after Calculation", Eirini.Tuition);
        }
    }
}
