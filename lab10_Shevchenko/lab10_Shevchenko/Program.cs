using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_Shevchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем два массива
                OneDimensionalArray<int> array1 = new OneDimensionalArray<int>(5);
                array1.Initialize(2);

                OneDimensionalArray<int> array2 = new OneDimensionalArray<int>(5);
                array2.Initialize(3);

                // Умножаем массивы
                OneDimensionalArray<int> resultArray = array1 * array2;

                // Отображаем результат
                Console.WriteLine("Result of array multiplication:");
                resultArray.Display();

                // Проверка равенства массивов
                bool areEqual = array1 == array2;
                Console.WriteLine($"Arrays are equal: {areEqual}");

                // Проверка неравенства массивов
                bool areNotEqual = array1 != array2;
                Console.WriteLine($"Arrays are not equal: {areNotEqual}");

                // Проверка сравнения массивов
                bool isLessOrEqual = array1 <= array2;
                Console.WriteLine($"Array1 is less or equal to Array2: {isLessOrEqual}");

                bool isGreaterOrEqual = array1 >= array2;
                Console.WriteLine($"Array1 is greater or equal to Array2: {isGreaterOrEqual}");

                // Работа с ref и out параметрами
                bool success = false;
                array1.GetElement(2, out int element, ref success);
                if (success)
                {
                    Console.WriteLine($"Element at index 2: {element}");
                }
                else
                {
                    Console.WriteLine("Failed to get element at index 2.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

