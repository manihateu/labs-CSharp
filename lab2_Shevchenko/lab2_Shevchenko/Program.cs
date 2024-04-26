using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", new DateTime(1980, 5, 25));
            Entrant entrant = new Entrant("Alice Johnson", new DateTime(2003, 8, 15), 89);
            Student student = new Student("Bob Smith", new DateTime(2002, 3, 5), 2, "B2", "Economics");
            Professor professor = new Professor("Dr. Emily Clark", new DateTime(1975, 1, 12), "Associate Professor", "Computer Science");

            Console.WriteLine(person);
            Console.WriteLine(entrant);
            Console.WriteLine(student);
            Console.WriteLine(professor);
        }
    }
}
