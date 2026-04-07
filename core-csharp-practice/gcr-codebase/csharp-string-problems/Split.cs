using System;
using System.Collections.Generic;
using System.Text;

class Split
{
    static void Main()
    {
        string s = Console.ReadLine();

        string[,] result = SplitAndCount(s);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + " " + result[i, 1]);
        }
    }

    static string[,] SplitAndCount(string s)
    {
        int wordCount = 1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                wordCount++;
        }

        string[,] arr = new string[wordCount, 2];

        int row = 0;
        string word = "";

        for (int i = 0; i <= s.Length; i++)
        {
            if (i == s.Length || s[i] == ' ')
            {
                arr[row, 0] = word;
                arr[row, 1] = GetLength(word).ToString();
                row++;
                word = "";
            }
            else
            {
                word += s[i];
            }
        }

        return arr;
    }

    static int GetLength(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            count++;
        }
        return count;
    }
}
