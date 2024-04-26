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
            OneDimensionalArray array1 = new OneDimensionalArray(3);
            array1[0] = 1; array1[1] = 2; array1[2] = 3;
            OneDimensionalArray array2 = new OneDimensionalArray(3);
            array2[0] = 4; array2[1] = 5; array2[2] = 6;

            // Проверка умножения
            OneDimensionalArray multiplied = array1 * array2;
            Console.WriteLine("Multiplied array:");
            for (int i = 0; i < (int)multiplied; i++)
            {
                Console.WriteLine(multiplied[i]);
            }

            // Проверка равенства
            Console.WriteLine("Arrays are equal: " + (array1 == array2));

            // Проверка размера массива
            Console.WriteLine("Size of array1: " + (int)array1);

            // Проверка оператора сравнения <=
            Console.WriteLine("array1 <= array2: " + (array1 <= array2));
        }
    }
}
