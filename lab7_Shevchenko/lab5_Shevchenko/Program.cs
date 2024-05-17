using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OneDimensionalArray<int> array = OneDimensionalArray<int>.LoadFromFile("input.txt");
                OneDimensionalArray<int>.SaveToFile(array, "output.txt");
                Console.WriteLine("Data processed successfully.");
            }
            catch (ArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}