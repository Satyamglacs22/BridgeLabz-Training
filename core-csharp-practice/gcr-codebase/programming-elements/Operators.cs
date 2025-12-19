using System;

public class Operators
{
    public static void Main()
    {
        int a = 55;
        int b = 40;

        // Arithmetic Operators
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));

        // Logical Operators
        bool x = true;
        bool y = false;

        Console.WriteLine("x && y: " + (x && y));
        Console.WriteLine("x || y: " + (x || y));
        Console.WriteLine("!x: " + (!x));
        Console.WriteLine("!y: " + (!y));

        // Assignment Operators
        a += b;
        Console.WriteLine("a += b: " + a);

        a *= b;
        Console.WriteLine("a *= b: " + a);

        a /= b;
        Console.WriteLine("a /= b: " + a);

        a %= b;
        Console.WriteLine("a %= b: " + a);

        // Unary Operators
        Console.WriteLine("a: " + a);
        Console.WriteLine("++a: " + ++a);
        Console.WriteLine("a++: " + a++);
        Console.WriteLine("a: " + a);
        Console.WriteLine("--a: " + --a);
        Console.WriteLine("a--: " + a--);
        Console.WriteLine("a: " + a);

        // Ternary Operator
        int max = (a > b) ? a : b;
        Console.WriteLine("Max: " + max);

        // is Operator
        Operators op = new Operators();
        Console.WriteLine(op is object);
        Console.WriteLine(op is string);
    }
}
