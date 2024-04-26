using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Shevchenko
{
    internal class Entrant : Person
    {
        public int ExamScores { get; set; }

        public Entrant(string name, DateTime dateOfBirth, int examScores)
            : base(name, dateOfBirth)
        {
            ExamScores = examScores;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Количество баллов: {ExamScores}";
        }
    }
}
