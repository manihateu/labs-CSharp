using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Shevchenko
{
    internal class OneDimensionalArray
    {
        private int[] data;

        public OneDimensionalArray(int size)
        {
            data = new int[size];
        }

        public int Length => data.Length;

        public int this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }

        public static OneDimensionalArray operator *(OneDimensionalArray a, OneDimensionalArray b)
        {
            if (a.Length != b.Length)
                throw new InvalidOperationException("Arrays must be of the same length to multiply.");

            OneDimensionalArray result = new OneDimensionalArray(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] * b[i];
            }
            return result;
        }

        public static bool operator ==(OneDimensionalArray a, OneDimensionalArray b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        public static bool operator !=(OneDimensionalArray a, OneDimensionalArray b)
        {
            return !(a == b);
        }

        public static bool operator <=(OneDimensionalArray a, OneDimensionalArray b)
        {
            return a.Sum() <= b.Sum();
        }

        public static bool operator >=(OneDimensionalArray a, OneDimensionalArray b)
        {
            return a.Sum() >= b.Sum();
        }

        public static explicit operator int(OneDimensionalArray a)
        {
            return a.Length;
        }

        private int Sum()
        {
            int sum = 0;
            foreach (int i in data)
            {
                sum += i;
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            return obj is OneDimensionalArray array && this == array;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            foreach (int value in data)
            {
                hash = hash * 23 + value.GetHashCode();
            }
            return hash;
        }

        ~OneDimensionalArray()
        {
            Console.WriteLine("Array destroyed");
        }
    }
}
