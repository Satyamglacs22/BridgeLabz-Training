//using System;
//using System.Collections.Generic;
//using System.Text;

//class MostFrequentChar
//{
//    public static void Main()
//    {
//        string text = Console.ReadLine();
//        int maxCount = 0;
//        char maxChar = text[0];

//        for (int i = 0; i < text.Length; i++)
//        {
//            int count = 0;

//            for (int j = 0; j < text.Length; j++)
//            {
//                if (text[i] == text[j])
//                    count++;
//            }

//            if (count > maxCount)
//            {
//                maxCount = count;
//                maxChar = text[i];
//            }
//        }

//        Console.WriteLine("Most Frequent Character: " + maxChar);
//    }
//}
