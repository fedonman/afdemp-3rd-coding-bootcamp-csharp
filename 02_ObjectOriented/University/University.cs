using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class University
    {
        public string Info { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<StudentCourse> StudentsCourses { get; set; }

        public void RegisterStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException();
            }

            Students.Add(student);
        }

        public void RegisterCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException();
            }

            Courses.Add(course);
        }

        public bool RegisterStudentToCourse(string student, string course)
        {
            Student s = CheckIfStudentExists(student);
            Course c = CheckIfCourseExists(course);

            if (s == null || c == null)
            {
                return false;
            }

            int courses = CountStudentCourses(s);

            if (courses == 5)
            {
                return false;
            }

            StudentsCourses.Add(new StudentCourse
            {
                Student = s,
                Course = c,
            });

            return true;

        }

        private Student CheckIfStudentExists(string student)
        {
            foreach (Student item in Students)
            {
                if (item.Name == student)
                {
                    return item;
                }
            }

            return null;
        }

        private Course CheckIfCourseExists(string course)
        {
            foreach (Course item in Courses)
            {
                if (item.CourseName == course)
                {
                    return item;
                }
            }

            return null;
        }

        private int CountStudentCourses(Student student)
        {
            int count = 0;

            foreach (StudentCourse sc in StudentsCourses)
            {
                if (sc.Student.Name == student.Name)
                {
                    count++;
                }
            }

            return count;
        }

        public University()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            StudentsCourses = new List<StudentCourse>();
        }
    }
}
