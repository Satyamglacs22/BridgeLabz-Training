using System;
using System.Collections.Generic;
using System.Text;

class DateCompare
{
    public static void Main()
    {
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(date1, date2);

        if (result < 0)
            Console.WriteLine("First date is before second date");
        else if (result > 0)
            Console.WriteLine("First date is after second date");
        else
            Console.WriteLine("Both dates are same");
    }
}
