using System;

class SimpleInterest
{
    static void Main()
    {
        int principal = int.Parse(Console.ReadLine());
        int rate = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100.0;

        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}
