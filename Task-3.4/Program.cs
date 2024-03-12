using System;
using System.Linq;
using Task_3._4;
using Task_3_4;
using static System.Runtime.InteropServices.JavaScript.JSType;

class HelloWorld
{
    static void Main()
    {
        IntValue intVal = new IntValue();
        StringValue stringtVal = new StringValue();
        BoolValue boolVal = new BoolValue();
        DoubleValue doubleVal = new DoubleValue();
        Console.WriteLine("Одномерные массивы");
        OneDimentionalArray<int> intoneDimentionalArray = new OneDimentionalArray<int>(intVal, 10);
        intoneDimentionalArray.Print();
        OneDimentionalArray<string> stringoneDimentionalArray = new OneDimentionalArray<string>(stringtVal, 10);
        stringoneDimentionalArray.Print();
        OneDimentionalArray<bool> booloneDimentionalArray = new OneDimentionalArray<bool>(boolVal, 10);
        booloneDimentionalArray.Print();
        OneDimentionalArray<double> doubleoneDimentionalArray = new OneDimentionalArray<double>(doubleVal, 10);
        doubleoneDimentionalArray.Print();
        Console.WriteLine();
        Console.WriteLine("двумерные массивы");
        RectangleArray<int> inttwoDimentionalArray = new RectangleArray<int>(intVal, 10, 10);
        inttwoDimentionalArray.Print();
        RectangleArray<string> stringtwoDimentionalArray = new RectangleArray<string>(stringtVal, 10, 10);
        stringtwoDimentionalArray.Print();
        RectangleArray<bool> booltwoDimentionalArray = new RectangleArray<bool>(boolVal, 10, 10);
        booltwoDimentionalArray.Print();
        RectangleArray<double> doubletwoDimentionalArray = new RectangleArray<double>(doubleVal, 10, 10);
        doubletwoDimentionalArray.Print();

    }
}

