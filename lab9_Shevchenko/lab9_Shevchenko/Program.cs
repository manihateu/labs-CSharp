using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем объекты различных классов
                Person person1 = new Applicant("Alice", new DateTime(2000, 1, 1), 95);
                Person person2 = new Student("Bob", new DateTime(1999, 2, 2), 3, "CS-101", "Computer Science");
                Person person3 = new Teacher("Charlie", new DateTime(1985, 3, 3), "Professor", "Computer Science");
                DepartmentHead person4 = new DepartmentHead("David", new DateTime(1970, 4, 4), "Information Systems and Technologies");

                // Добавляем объекты в коллекцию
                ArrayList people = new ArrayList { person1, person2, person3, person4 };

                // Просматриваем объекты в коллекции
                foreach (Person person in people)
                {
                    person.DisplayInfo();
                }

                // Вызываем статический метод для вывода количества созданных объектов
                DepartmentHead.DisplayCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
