using System;
using System.Collections.Generic;
using System.Text;

class DateArithmetic
{
   public static void Main()
    {
        DateTime date = DateTime.Parse(Console.ReadLine());

        date = date.AddDays(7);
        date = date.AddMonths(1);
        date = date.AddYears(2);
        date = date.AddDays(-21); 

        Console.WriteLine(date);
    }
}
