using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to University!");

            // Creates a new instance of University
            University university = new University();

            // Registers some students
            university.RegisterStudent(new Student
            {
                Name = "Michalis Nikolaidis",
                Age = 28
            });

            university.RegisterStudent(new Student
            {
                Name = "Antonis Markogiannakis",
                Age = 25
            });

            // Registers some courses
            university.RegisterCourse(new Course
            {
                CourseName = "Introduction to Computer Science",
                ECTS = 5
            });

            university.RegisterCourse(new Course
            {
                CourseName = "Programming in C#",
                ECTS = 8
            });

            // 
            bool success = university
                .RegisterStudentToCourse("Antonis Markogiannakis", "Programming in C#");
        }
    }
}
