using System;

namespace ClassLibrary
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        public bool IsPalindrome(string str)
        {
            return str == Reverse(str);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
