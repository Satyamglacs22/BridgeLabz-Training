using System;
using System.Collections.Generic;
using System.Text;


class MathUtility
{
    // Factorial Method
    public long Factorial(int n)
    {
        if (n < 0)
            return -1;

        long fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;

        return fact;
    }

    // Prime Check Method
    public bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i*i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    // GCD Method
    public int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Fibonacci Method
    public int Fibonacci(int n)
    {
        if (n < 0)
            return -1;
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        //int a = 0, b = 1, c = 0;
        //for (int i = 2; i <= n; i++)
        //{
        //    c = a + b;
        //    a = b;
        //    b = c;
        //}
        //return c;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

class Program
{
    static void Main()
    {
        MathUtility util = new MathUtility(); 

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- MATHEMATICAL UTILITY MENU ---");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD of Two Numbers");
            Console.WriteLine("4. Nth Fibonacci Number");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number: ");
                    int n = int.Parse(Console.ReadLine());

                    long fact = util.Factorial(n); 
                    if (fact == -1)
                        Console.WriteLine("Factorial not defined for negative numbers.");
                    else
                        Console.WriteLine("Factorial = " + fact);
                    break;

                case 2:
                    Console.Write("Enter number: ");
                    int p = int.Parse(Console.ReadLine());

                    if (util.IsPrime(p)) 
                        Console.WriteLine("Prime Number");
                    else
                        Console.WriteLine("Not a Prime Number");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("GCD = " + util.GCD(a, b)); 
                    break;

                case 4:
                    Console.Write("Enter n: ");
                    int f = int.Parse(Console.ReadLine());

                    int fib = util.Fibonacci(f); 
                    if (fib == -1)
                        Console.WriteLine("Fibonacci not defined for negative numbers.");
                    else
                        Console.WriteLine("Fibonacci number = " + fib);
                    break;

                case 5:
                    exit = true;
                    Console.WriteLine("Program Terminated.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}
