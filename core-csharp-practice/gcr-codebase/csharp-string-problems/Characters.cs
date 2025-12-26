using System;
using System.Collections.Generic;
using System.Text;

namespace String.Level1
{
    public class Characters
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            char[] ch = AllCharacters(s);
            bool result = Compare(s, ch);

            Console.WriteLine(result);
        }

        public static char[] AllCharacters(string s)
        {
            char[] ch = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                ch[i] = s[i];
            }

            return ch;
        }

        public static bool Compare(string s, char[] ch)
        {
            char[] c = s.ToCharArray();

            if (c.Length != ch.Length)
            {
                return false;
            }

            for (int i = 0; i < ch.Length; i++)
            {
                if (c[i] != ch[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
