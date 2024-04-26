using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Shevchenko
{
    internal class Professor : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Professor(string name, DateTime dateOfBirth, string position, string department)
            : base(name, dateOfBirth)
        {
            Position = position;
            Department = department;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Должность: {Position}, Кафедра: {Department}";
        }
    }
}
