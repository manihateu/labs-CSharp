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
            new Professor("Доктор Елена Петрова", new DateTime(1975, 1, 12), "Доцент", "Компьютерные науки");

            Person.PrintList();
        }
    }
}
