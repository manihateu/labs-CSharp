using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_Shevchenko
{
    public class Student : Person
    {
        // Дополнительные поля
        private int course;
        private string group;
        private string faculty;
        
        // Свойства
        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        // Конструкторы
        public Student(string name, DateTime dateOfBirth, int course, string group, string faculty) : base(name, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
        }

        // Переопределение метода базового класса
        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: Name - {Name}, Date of Birth - {DateOfBirth}, Course - {Course}, Group - {Group}, Faculty - {Faculty}");
        }
    }
}
