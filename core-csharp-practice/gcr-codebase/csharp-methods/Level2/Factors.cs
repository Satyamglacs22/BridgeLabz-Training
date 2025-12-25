//using System;

//namespace Method.Level1
//{
//    public class Factors
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

//            int[] factors = FindFactors(number);

//            Console.WriteLine("Factors:");
//            foreach (int f in factors)
//            {
//                Console.Write(f + " ");
//            }
//            Console.WriteLine();

//            int sum = FindSum(factors);
//            long product = FindProduct(factors);
//            double sumOfSquares = FindSumOfSquares(factors);

//            Console.WriteLine("Sum of factors: " + sum);
//            Console.WriteLine("Product of factors: " + product);
//            Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
//        }

        
//        public static int[] FindFactors(int number)
//        {
//            int count = 0;

            
//            for (int i = 1; i <= number; i++)
//            {
//                if (number % i == 0)
//                {
//                    count++;
//                }
//            }

//            int[] factors = new int[count];
//            int index = 0;

            
//            for (int i = 1; i <= number; i++)
//            {
//                if (number % i == 0)
//                {
//                    factors[index++] = i;
//                }
//            }

//            return factors;
//        }

        
//        public static int FindSum(int[] factors)
//        {
//            int sum = 0;
//            foreach (int f in factors)
//            {
//                sum += f;
//            }
//            return sum;
//        }

        
//        public static long FindProduct(int[] factors)
//        {
//            long product = 1;
//            foreach (int f in factors)
//            {
//                product *= f;
//            }
//            return product;
//        }

        
//        public static double FindSumOfSquares(int[] factors)
//        {
//            double sum = 0;
//            foreach (int f in factors)
//            {
//                sum += Math.Pow(f, 2);
//            }
//            return sum;
//        }
//    }
//}
