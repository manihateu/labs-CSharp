using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Введите данные для сотрудника {i + 1}:");
                employees[i] = new Employee();
                employees[i].InputData();
            }

            Console.WriteLine("\nИнформация о сотрудниках:");
            foreach (var employee in employees)
            {
                employee.DisplayData();
            }
        }
    }
}
