using System;
using System.Collections.Generic;
using System.Text;

class Replace
{
    public static void Main()
    {
        string sentence = Console.ReadLine();
        string oldWord = Console.ReadLine();
        string newWord = Console.ReadLine();

        string result = "";
        int i = 0;

        while (i < sentence.Length)
        {
            bool match = true;

            if (i + oldWord.Length <= sentence.Length)
            {
                for (int j = 0; j < oldWord.Length; j++)
                {
                    if (sentence[i + j] != oldWord[j])
                    {
                        match = false;
                        break;
                    }
                }
            }
            else
                match = false;

            if (match)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }

        Console.WriteLine(result);
    }
}
