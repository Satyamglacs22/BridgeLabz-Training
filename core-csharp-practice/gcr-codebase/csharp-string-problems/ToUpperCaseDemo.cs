//using System;
//using System.Collections.Generic;
//using System.Text;

//class ToUppercaseDemo
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();

//        string s1 = ConvertToUpper(s);
//        string s2 = s.ToUpper();

//        Console.WriteLine(s1);
//        Console.WriteLine(s1 == s2);
//    }

//    static string ConvertToUpper(string s)
//    {
//        char[] ch = new char[s.Length];

//        for (int i = 0; i < s.Length; i++)
//        {
//            if (s[i] >= 'a' && s[i] <= 'z')
//            {
//                ch[i] = (char)(s[i] - 32);
//            }
//            else
//            {
//                ch[i] = s[i];
//            }
//        }

//        return new string(ch);
//    }
//}
