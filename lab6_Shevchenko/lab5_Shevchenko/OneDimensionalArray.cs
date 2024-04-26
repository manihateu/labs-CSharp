using lab5_Shevchenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Shevchenko
{
    using System;

    public class OneDimensionalArray<T>
    {
        private T[] data;

        public OneDimensionalArray(int size)
        {
            data = new T[size];
        }

        public int Length => data.Length;

        public T this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }

        public static explicit operator int(OneDimensionalArray<T> a)
        {
            return a.Length;
        }

        ~OneDimensionalArray()
        {
            Console.WriteLine("Array destroyed");
        }
    }
}


public static class ArrayOperations
{
    public static double Average<T>(OneDimensionalArray<T> array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += (dynamic)array[i];
        }
        return (double)sum / array.Length;
    }
}