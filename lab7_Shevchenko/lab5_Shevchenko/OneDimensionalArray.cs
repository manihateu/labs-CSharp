using System;
using System.IO;

public class OneDimensionalArray<T>
{
    private T[] data;

    public OneDimensionalArray(int size)
    {
        if (size < 0)
            throw new ObjectCreationException("Size of array cannot be negative.");

        data = new T[size];
    }

    public int Length => data.Length;

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
                for (int i = 0; i < array.Length; i++)
                {
                    writer.WriteLine(array[i].ToString());
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
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int count = 0; 
                while ((line = reader.ReadLine()) != null)
                {
                    count ++;
                }
                OneDimensionalArray<T> array = new OneDimensionalArray<T>(count);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                int index = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    array[index] = (T)Convert.ChangeType(line, typeof(T));
                    index++;
                }
                return array;
            }
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
