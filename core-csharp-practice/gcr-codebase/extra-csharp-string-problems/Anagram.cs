using System;
using System.Collections.Generic;
using System.Text;

class Anagram
{
    public static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] count = new int[256];

        for (int i = 0; i < s1.Length; i++)
        {
            count[s1[i]]++;
            count[s2[i]]--;
        }

        bool isAnagram = true;

        for (int i = 0; i < 256; i++)
        {
            if (count[i] != 0)
            {
                isAnagram = false;
                break;
            }
        }

        if (isAnagram)
            Console.WriteLine("Anagrams");
        else
            Console.WriteLine("Not Anagrams");
    }
}
