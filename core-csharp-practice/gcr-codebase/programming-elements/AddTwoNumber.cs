using System;

class AddTwoNumber
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
    }
}
