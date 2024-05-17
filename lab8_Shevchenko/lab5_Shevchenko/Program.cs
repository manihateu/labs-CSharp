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
                OneDimensionalArray<int> intArray = new OneDimensionalArray<int>();
                intArray.Add(10);
                intArray.Add(20);
                intArray.Add(30);
                intArray.Add(40);
                intArray.Add(50);

                Console.WriteLine("Исходный список целых чисел:");
                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }

                intArray.RemoveAt(2);
                Console.WriteLine("\nУдаляем элемент по индексу 2:");

                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }
                
                intArray.ReplaceAt(1, 99);
                Console.WriteLine("\nЗаменяем элемент по индексу 1 на 99:");

                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }

                intArray.RemoveNAfterIndex(1, 2);
                Console.WriteLine("\nУдаляем 2 элемента после индекса 1:");

                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }

                intArray.SortDescending();
                Console.WriteLine("\nСортируем список по убыванию элементов:");

                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }

                // Заданный элемент для поиска
                int searchItem = 99;

                bool found = intArray == searchItem;
                if (found)
                    Console.WriteLine($"Элемент '{searchItem}' найден в контейнере.");
                else
                    Console.WriteLine($"Элемент '{searchItem}' не найден в контейнере.");

                Console.WriteLine();

                int count = intArray.CountWithCallback(item => item == 99);
                Console.WriteLine($"Количество элементов: {count}");

                Console.WriteLine("Data processed successfully.");
            }
            catch (ArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    }