using System;

class DivisibleByFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {result}");
    }
}
