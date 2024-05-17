using System;
using System.Collections.Generic;
using System.IO;

public delegate bool ConditionDelegate<T>(T item);
public class OneDimensionalArray<T>
{
    private readonly List<T> data;

    public OneDimensionalArray()
    {
        data = new List<T>();
    }

    public OneDimensionalArray(int size)
    {
        data = new List<T>(size);
    }

    public void Add(T item)
    {
        data.Add(item);
    }
    public int Length => data.Count;

    public T this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }

    public static explicit operator int(OneDimensionalArray<T> a) => a.Length;

    public static void SaveToFile(OneDimensionalArray<T> array, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in array.data)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }
        catch (IOException ex)
        {
            throw new FileReadException("Failed to write to file: " + ex.Message);
        }
    }

    public static OneDimensionalArray<T> LoadFromFile(string filePath)
    {
        try
        {
            OneDimensionalArray<T> array = new OneDimensionalArray<T>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    array.Add((T)Convert.ChangeType(line, typeof(T)));
                }
            }
            return array;
        }
        catch (FileNotFoundException ex)
        {
            throw new FileReadException("File not found: " + ex.Message);
        }
        catch (FormatException ex)
        {
            throw new InvalidDataException("Invalid data format: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            throw new InvalidDataException("Data overflow error: " + ex.Message);
        }
    }
    // Удаление элемента из списка по индексу
    public void RemoveAt(int index)
    {
        if (index >= 0 && index < Length)
        {
            data.RemoveAt(index);
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }

    // Замена элемента в списке по индексу
    public void ReplaceAt(int index, T newItem)
    {
        if (index >= 0 && index < Length)
        {
            data[index] = newItem;
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }

    // Итератор для просмотра элементов списка
    public IEnumerator<T> GetEnumerator()
    {
        return data.GetEnumerator();
    }

    // Удаление n элементов после заданного индекса
    public void RemoveNAfterIndex(int index, int n)
    {
        if (index >= 0 && index < Length && index + n < Length)
        {
            data.RemoveRange(index + 1, n);
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range or too close to the end of the list.");
        }
    }

    // Сортировка списка по убыванию элементов
    public void SortDescending()
    {
        data.Sort((x, y) => Comparer<T>.Default.Compare(y, x));
    }

    public static bool operator ==(OneDimensionalArray<T> array, T item)
    {
        foreach (var element in array.data)
        {
            if (element.Equals(item))
                return true;
        }
        return false;
    }

    // Перегрузка оператора !=
    public static bool operator !=(OneDimensionalArray<T> array, T item)
    {
        return !(array == item);
    }

    public int CountWithCallback(ConditionDelegate<T> callback)
    {
        int count = 0;
        foreach (var item in data)
        {
            if (callback(item))
                count++;
        }
        return count;
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
