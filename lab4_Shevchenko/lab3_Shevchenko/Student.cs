using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Shevchenko
{
    public class Student : Person
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
            AddToList(this);
        }

        public override string ToString()
        {
            return $"{Name}, Дата рождения: {DateOfBirth.ToShortDateString()}, Курс: {Course}, Группа: {Group}, Факультет: {Faculty}";
        }

        public static IEnumerable<string> GetStudentsByCourse(int course)
        {
            Person current = Head;
            while (current != null)
            {
                if (current is Student student && student.Course == course)
                {
                    yield return student.Name;
                }
                current = current.Next;
            }
        }
    }
}
