using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Shevchenko
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static Person Head { get; set; }
        public Person Next { get; set; }

        protected Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Next = null;
        }

        public static void AddToList(Person person)
        {
            if (Head == null)
                Head = person;
            else
            {
                Person current = Head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = person;
            }
        }

        public static void PrintList()
        {
            Person current = Head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }

        public abstract override string ToString();
    }
}
