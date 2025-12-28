using System;
using System.Collections.Generic;
using System.Text;

class Toggle
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch >= 'a' && ch <= 'z')
                result += (char)(ch - 32);
            else if (ch >= 'A' && ch <= 'Z')
                result += (char)(ch + 32);
            else
                result += ch;
        }

        Console.WriteLine(result);
    }
}
