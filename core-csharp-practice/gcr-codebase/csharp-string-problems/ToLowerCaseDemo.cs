//using System;
//using System.Collections.Generic;
//using System.Text;
//class ToLowercaseDemo
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();

//        string s1 = ConvertToLower(s);
//        string s2 = s.ToLower();

//        Console.WriteLine(s1);
//        Console.WriteLine(s1 == s2);
//    }

//    static string ConvertToLower(string s)
//    {
//        char[] ch = new char[s.Length];

//        for (int i = 0; i < s.Length; i++)
//        {
//            if (s[i] >= 'A' && s[i] <= 'Z')
//            {
//                ch[i] = (char)(s[i] + 32);
//            }
//            else
//            {
//                ch[i] = s[i];
//            }
//        }

//        return new string(ch);
//    }
//}
