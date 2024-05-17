using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_Shevchenko
{
    public class Teacher : Person
    {
        // Дополнительные поля
        private string position;
        private string department;

        // Свойства
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // Конструкторы
        public Teacher(string name, DateTime dateOfBirth, string position, string department) : base(name, dateOfBirth)
        {
            Position = position;
            Department = department;
        }

        // Переопределение метода базового класса
        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher: Name - {Name}, Date of Birth - {DateOfBirth}, Position - {Position}, Department - {Department}");
        }
    }
}
