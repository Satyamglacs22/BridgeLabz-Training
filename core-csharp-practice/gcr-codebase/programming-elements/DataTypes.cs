using System;

public class DataTypes
{
    public static void Main()
    {
        // Value Data Types
        int i = 10;
        float f = 10.5f;
        double d = 99.99;
        char c = 'A';
        bool b = true;

        Console.WriteLine("Integer: " + i);
        Console.WriteLine("Float: " + f);
        Console.WriteLine("Double: " + d);
        Console.WriteLine("Character: " + c);
        Console.WriteLine("Boolean: " + b);

        // String (Reference Type)
        string name = "Satyam";
        Console.WriteLine("String: " + name);

        // Object Type
        object obj1 = 100;
        object obj2 = "Hello";

        Console.WriteLine("Object 1: " + obj1);
        Console.WriteLine("Object 2: " + obj2);


        // Type Casting
        double num = 45.67;
        int castNum = (int)num;

        Console.WriteLine("Double value: " + num);
        Console.WriteLine("After Casting to int: " + castNum);

        // is Operator with Data Types
        Console.WriteLine("obj1 is int: " + (obj1 is int));
        Console.WriteLine("obj2 is string: " + (obj2 is string));
    }
}
