using System;
using System.Collections.Generic;
using System.Text;

class Reverse
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string rev = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            rev = rev + text[i];
        }

        Console.WriteLine(rev);
    }
}
