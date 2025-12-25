//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Method.Level2
//{
//    public class StudentVote
//    {
//        public static void Main()
//        {
//            int[] ages = new int[10];

//            for (int i = 0; i < ages.Length; i++)
//            {
//                ages[i] = int.Parse(Console.ReadLine());
//                bool canVote = CanStudentVote(ages[i]);
//                Console.WriteLine(canVote ? "Can Vote" : "Cannot Vote");
//            }
//        }

//        public static bool CanStudentVote(int age)
//        {
//            if (age < 0)
//                return false;

//            return age >= 18;
//        }
//    }
//}
