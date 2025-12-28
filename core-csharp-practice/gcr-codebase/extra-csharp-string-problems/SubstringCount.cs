using System;
using System.Collections.Generic;
using System.Text;

class SubstringCount
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string sub = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            bool match = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (text[i + j] != sub[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                count++;
        }

        Console.WriteLine(count);
    }
}
