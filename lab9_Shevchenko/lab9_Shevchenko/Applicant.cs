using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_Shevchenko
{
    public class Applicant : Person
    {
        // Дополнительное поле
        private int examScores;

        // Свойство
        public int ExamScores
        {
            get { return examScores; }
            set { examScores = value; }
        }

        // Конструкторы
        public Applicant(string name, DateTime dateOfBirth, int examScores) : base(name, dateOfBirth)
        {
            ExamScores = examScores;
        }

        // Переопределение метода базового класса
        public override void DisplayInfo()
        {
            Console.WriteLine($"Applicant: Name - {Name}, Date of Birth - {DateOfBirth}, Exam Scores - {ExamScores}");
        }
    }

}
