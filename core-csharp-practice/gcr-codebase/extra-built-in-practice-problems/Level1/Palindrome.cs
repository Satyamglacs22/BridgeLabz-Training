using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class Palindrome
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            string t = "";
            PalindromeCheck(s, t);
        }
        public static void PalindromeCheck(string s, string t)
        {
            int k = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                t = t + s[i];
                //k++;
            }
            if (s.Equals(t))
            {
                Console.WriteLine("Palinrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }
        }
    }
}
