//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class OtpGenerator
//    {
//        public static void Main()
//        {
//            int[] otps = new int[10];

//            for (int i = 0; i < 10; i++)
//                otps[i] = GenerateOtp();

//            Console.WriteLine(AreUnique(otps));
//        }

//        public static int GenerateOtp()
//        {
//            Random random = new Random();
//            return random.Next(100000, 1000000);
//        }

//        public static bool AreUnique(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//                for (int j = i + 1; j < arr.Length; j++)
//                    if (arr[i] == arr[j]) return false;
//            return true;
//        }
//    }
//}
