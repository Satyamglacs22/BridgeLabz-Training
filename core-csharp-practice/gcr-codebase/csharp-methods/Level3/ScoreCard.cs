//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Level3
//{
//    public class Scorecard
//    {
//        public static void Main()
//        {
//            int students = int.Parse(Console.ReadLine());
//            int[,] scores = GenerateScores(students);
//            double[,] result = CalculateResults(scores);
//            Display(scores, result);
//        }

//        public static int[,] GenerateScores(int n)
//        {
//            Random random = new Random();
//            int[,] scores = new int[n, 3];

//            for (int i = 0; i < n; i++)
//                for (int j = 0; j < 3; j++)
//                    scores[i, j] = random.Next(10, 100);

//            return scores;
//        }

//        public static double[,] CalculateResults(int[,] scores)
//        {
//            int n = scores.GetLength(0);
//            double[,] result = new double[n, 3];

//            for (int i = 0; i < n; i++)
//            {
//                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
//                result[i, 0] = total;
//                result[i, 1] = Math.Round(total / 3, 2);
//                result[i, 2] = Math.Round((total / 300) * 100, 2);
//            }

//            return result;
//        }

//        public static void Display(int[,] scores, double[,] result)
//        {
//            for (int i = 0; i < scores.GetLength(0); i++)
//            {
//                Console.WriteLine(
//                    scores[i, 0] + "\t" +
//                    scores[i, 1] + "\t" +
//                    scores[i, 2] + "\t" +
//                    result[i, 0] + "\t" +
//                    result[i, 1] + "\t" +

//                    result[i, 2]);
//            }
//        }
//    }
//}
