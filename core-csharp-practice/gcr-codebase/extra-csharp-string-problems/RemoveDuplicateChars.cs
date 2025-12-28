using System;
using System.Collections.Generic;
using System.Text;
class RemoveDuplicateChars
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (text[i] == result[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                result += text[i];
        }

        Console.WriteLine(result);
    }
}
