using System;

namespace Theory
{
    class Student
    {
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Grade { get; private set; }

        public Student()
        {
            Grade = 0;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Grade = 0;
        }

        public void AddGrade(double x)
        {
            Grade += x;
            if (Grade > 10)
            {
                Grade = 10;
            }
        }
    }
}
