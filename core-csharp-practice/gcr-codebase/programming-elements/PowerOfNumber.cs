using System;

class PowerOfNumber
{
    static void Main()
    {
        double baseNum = double.Parse(Console.ReadLine());
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine(result);
    }
}
