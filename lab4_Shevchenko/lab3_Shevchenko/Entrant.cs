using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Shevchenko
{
    public class Entrant : Person
    {
        public int ExamScores { get; set; }

        public Entrant(string name, DateTime dateOfBirth, int examScores)
            : base(name, dateOfBirth)
        {
            ExamScores = examScores;
            AddToList(this);
        }

        public override string ToString()
        {
            return $"{Name}, Дата рождения: {DateOfBirth.ToShortDateString()}, Баллы экзаменов: {ExamScores}";
        }
    }
}
