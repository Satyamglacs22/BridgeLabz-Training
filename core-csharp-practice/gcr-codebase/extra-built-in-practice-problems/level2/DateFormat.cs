using System;
using System.Collections.Generic;
using System.Text;

class DateFormat
{
    public static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine(now.ToString("dd/MM/yyyy"));
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
        Console.WriteLine(now.ToString("ddd, MMM dd, yyyy"));
    }
}
