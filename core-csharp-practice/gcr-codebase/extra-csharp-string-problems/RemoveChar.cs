using System;
using System.Collections.Generic;
using System.Text;

class RemoveChar
{
    public static void Main()
    {
        string text = Console.ReadLine();
        char removeChar = Console.ReadLine()[0];
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != removeChar)
                result += text[i];
        }

        Console.WriteLine(result);
    }
}
