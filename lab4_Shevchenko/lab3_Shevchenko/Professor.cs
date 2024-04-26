using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Shevchenko
{
    public class Professor : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Professor(string name, DateTime dateOfBirth, string position, string department)
            : base(name, dateOfBirth)
        {
            Position = position;
            Department = department;
            AddToList(this);
        }

        public override string ToString()
        {
            return $"{Name}, Дата рождения: {DateOfBirth.ToShortDateString()}, Должность: {Position}, Кафедра: {Department}";
        }

        public static IEnumerable<string> GetProfessorsByDepartment(string department)
        {
            Person current = Head;
            while (current != null)
            {
                if (current is Professor professor && professor.Department == department)
                {
                    yield return $"{professor.Name} - {professor.Position}";
                }
                current = current.Next;
            }
        }
    }
}
