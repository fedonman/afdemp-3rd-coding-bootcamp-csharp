using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory
{
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void AddGradeToStudent(Student student, int amount)
        {
            student.AddGrade(amount);
        }
    }
}
