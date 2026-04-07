using System;

class Palindrome
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string rev = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            rev += text[i];
        }

        if (text == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
