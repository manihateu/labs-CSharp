using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Shevchenko
{
    internal class Employee
    {
        
            public int EmployeeNumber { get; set; }
            public float Salary { get; set; }

            public void InputData()
            {
                Console.Write("Введите номер сотрудника: ");
                EmployeeNumber = int.Parse(Console.ReadLine());
                Console.Write("Введите оклад сотрудника: ");
                Salary = float.Parse(Console.ReadLine());
            }

            public void DisplayData()
            {
                Console.WriteLine($"Номер сотрудника: {EmployeeNumber}, Оклад: {Salary:F2}");
            }
        
    }
}
