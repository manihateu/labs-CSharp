using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Entrant("Алиса Иванова", new DateTime(2003, 8, 15), 89);
            new Student("Борис Смирнов", new DateTime(2002, 3, 5), 2, "B2", "Экономика");
            new Student("Сергей Петров", new DateTime(2001, 10, 10), 3, "C1", "Филология");
            new Professor("Доктор Елена Петрова", new DateTime(1975, 1, 12), "Доцент", "Компьютерные науки");
            new Professor("Доктор Иван Иванов", new DateTime(1968, 5, 22), "Профессор", "Филология");

            Console.WriteLine("Студенты 2 курса:");
            foreach (var name in Student.GetStudentsByCourse(2))
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nПреподаватели кафедры 'Филология':");
            foreach (var detail in Professor.GetProfessorsByDepartment("Филология"))
            {
                Console.WriteLine(detail);
            }
        }
    }
}
