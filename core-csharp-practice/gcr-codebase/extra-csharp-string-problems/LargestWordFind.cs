//using System;
//using System.Collections.Generic;
//using System.Text;

//class LongestWordFind
//{
//    public static void Main()
//    {
//        string sentence = Console.ReadLine();
//        string word = "";
//        string longest = "";

//        for (int i = 0; i < sentence.Length; i++)
//        {
//            if (sentence[i] != ' ')
//            {
//                word += sentence[i];
//            }
//            else
//            {
//                if (word.Length > longest.Length)
//                    longest = word;
//                word = "";
//            }
//        }

//        if (word.Length > longest.Length)
//            longest = word;

//        Console.WriteLine(longest);
//    }
//}
