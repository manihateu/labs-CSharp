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
            // Testing with int
            OneDimensionalArray<int> intArray = new OneDimensionalArray<int>(3);
            intArray[0] = 10; intArray[1] = 20; intArray[2] = 30;
            Console.WriteLine("Average of intArray: " + ArrayOperations.Average(intArray));

            // Testing with double
            OneDimensionalArray<double> doubleArray = new OneDimensionalArray<double>(3);
            doubleArray[0] = 10.5; doubleArray[1] = 20.5; doubleArray[2] = 30.5;
            Console.WriteLine("Average of doubleArray: " + ArrayOperations.Average(doubleArray));

            // Testing with a custom type (let's assume it's a type with an `int Value` property)
            OneDimensionalArray<MyValue> customArray = new OneDimensionalArray<MyValue>(3);
            customArray[0] = new MyValue(10);
            customArray[1] = new MyValue(20);
            customArray[2] = new MyValue(30);
            Console.WriteLine("Average of customArray: " + ArrayOperations.Average(customArray));
        }
    }
}

public class MyValue
{
    public int Value { get; }

    public MyValue(int value)
    {
        Value = value;
    }

    public static implicit operator int(MyValue v)
    {
        return v.Value;
    }
}
