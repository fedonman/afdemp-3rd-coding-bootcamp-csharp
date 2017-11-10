using System;

namespace Theory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Student s1 = new Student("Paul", 45);
            s1.Name = "Paul";
            s1.Age = 35;
            s1.AddGrade(3);
            Console.WriteLine($"{s1.Name}, Age: {s1.Age}, Grade: {s1.Grade}");

            Teacher t1 = new Teacher();
            t1.AddGradeToStudent(s1, 3);

            Console.WriteLine($"{s1.Name}, Age: {s1.Age}, Grade: {s1.Grade}");

            Console.WriteLine(s1.Age);

            Student s2 = new Student();

            //int n = int.Parse(Console.ReadLine());

            

            s2.Name = "Mary";
            Console.WriteLine(s2.Name);
            Console.WriteLine(s2.Age);

            Console.ReadKey();
        }
    }
}
