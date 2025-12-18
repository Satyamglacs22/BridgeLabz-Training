using System;

class Average
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int sum = n1 + n2 + n3;
        double avg = (double)sum / 3;

        Console.WriteLine(avg);
    }
}
