using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_Shevchenko
{
    public sealed class DepartmentHead : Person
    {
        // Дополнительные поля
        private string department;

        // Свойство
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // Статическое поле для отслеживания количества созданных объектов
        private static int count = 0;

        // Статический конструктор для инициализации статических членов класса
        static DepartmentHead()
        {
            count = 0;
        }

        // Конструкторы
        public DepartmentHead(string name, DateTime dateOfBirth, string department) : base(name, dateOfBirth)
        {
            Department = department;
            count++; // Увеличиваем счетчик при создании нового объекта
        }

        // Метод для вывода количества созданных объектов
        public static void DisplayCount()
        {
            Console.WriteLine($"Total number of DepartmentHead objects: {count}");
        }

        // Переопределение метода базового класса
        public override void DisplayInfo()
        {
            Console.WriteLine($"Department Head: Name - {Name}, Date of Birth - {DateOfBirth}, Department - {Department}");
        }
    }
}
