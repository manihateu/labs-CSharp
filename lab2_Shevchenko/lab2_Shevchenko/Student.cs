using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Shevchenko
{
    internal class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }

        public Student(string name, DateTime dateOfBirth, int course, string group, string faculty)
            : base(name, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Курс: {Course}, Группа: {Group}, Факультет: {Faculty}";
        }
    }
}
