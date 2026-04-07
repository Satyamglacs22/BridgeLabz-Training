using System;
using System.Collections.Generic;
using System.Text;

class VowelConsonantCheck
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int vowels = 0, consonants = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = char.ToLower(text[i]);

            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
