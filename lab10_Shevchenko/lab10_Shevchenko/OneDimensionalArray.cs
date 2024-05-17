using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_Shevchenko
{
    public class OneDimensionalArray<T> where T : IComparable<T>
    {
        private T[] data;

        // Статическое поле для отслеживания количества созданных объектов
        private static int objectCount = 0;

        // Индексатор
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= data.Length)
                    throw new IndexOutOfRangeException("Index out of range.");
                return data[index];
            }
            set
            {
                if (index < 0 || index >= data.Length)
                    throw new IndexOutOfRangeException("Index out of range.");
                data[index] = value;
            }
        }

        // Конструктор с параметром
        public OneDimensionalArray(int size)
        {
            if (size < 0)
                throw new ArgumentException("Size cannot be negative.");
            data = new T[size];
            objectCount++;
        }

        // Конструктор без параметров
        public OneDimensionalArray() : this(10) { }

        // Деструктор
        ~OneDimensionalArray()
        {
            // Освобождение ресурсов
            objectCount--;
        }

        // Метод для умножения массивов
        public static OneDimensionalArray<T> operator *(OneDimensionalArray<T> array1, OneDimensionalArray<T> array2)
        {
            if (array1.Length != array2.Length)
                throw new InvalidOperationException("Arrays must be of the same length to multiply.");

            OneDimensionalArray<T> result = new OneDimensionalArray<T>(array1.Length);
            for (int i = 0; i < array1.Length; i++)
            {
                dynamic value1 = array1[i];
                dynamic value2 = array2[i];
                result[i] = value1 * value2;
            }
            return result;
        }

        // Преобразование массива в int (размер массива)
        public static explicit operator int(OneDimensionalArray<T> array) => array.Length;

        // Операторы == и !=
        public static bool operator ==(OneDimensionalArray<T> array1, OneDimensionalArray<T> array2)
        {
            if (ReferenceEquals(array1, null) || ReferenceEquals(array2, null))
                return false;
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i]))
                    return false;
            }
            return true;
        }

        public static bool operator !=(OneDimensionalArray<T> array1, OneDimensionalArray<T> array2)
        {
            return !(array1 == array2);
        }

        // Операторы <= и >=
        public static bool operator <=(OneDimensionalArray<T> array1, OneDimensionalArray<T> array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].CompareTo(array2[i]) > 0)
                    return false;
            }
            return true;
        }

        public static bool operator >=(OneDimensionalArray<T> array1, OneDimensionalArray<T> array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].CompareTo(array2[i]) < 0)
                    return false;
            }
            return true;
        }

        // Свойство длины массива
        public int Length => data.Length;

        // Метод для инициализации массива значениями
        public void Initialize(T value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = value;
            }
        }

        // Метод для работы с ref и out параметрами
        public void GetElement(int index, out T element, ref bool success)
        {
            if (index >= 0 && index < data.Length)
            {
                element = data[index];
                success = true;
            }
            else
            {
                element = default;
                success = false;
            }
        }

        // Метод для вывода массива
        public void Display()
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
