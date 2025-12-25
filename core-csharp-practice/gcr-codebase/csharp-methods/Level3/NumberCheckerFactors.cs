//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace Level3
//{
//    public class NumberCheckerFactors
//    {
//        public static void Main()
//        {
//            int number = int.Parse(Console.ReadLine());

//            int[] factors = GetFactors(number);

//            Console.WriteLine(GetGreatestFactor(factors));
//            Console.WriteLine(GetSum(factors));
//            Console.WriteLine(GetProduct(factors));
//            Console.WriteLine(GetCubeProduct(factors));
//            Console.WriteLine(IsPerfect(number, factors));
//            Console.WriteLine(IsAbundant(number, factors));
//            Console.WriteLine(IsDeficient(number, factors));
//            Console.WriteLine(IsStrong(number));
//        }

//        public static int[] GetFactors(int number)
//        {
//            int count = 0;
//            for (int i = 1; i <= number; i++)
//                if (number % i == 0) count++;

//            int[] factors = new int[count];
//            int index = 0;

//            for (int i = 1; i <= number; i++)
//                if (number % i == 0) factors[index++] = i;

//            return factors;
//        }

//        public static int GetGreatestFactor(int[] factors)
//        {
//            int max = factors[0];
//            foreach (int f in factors)
//                if (f > max) max = f;
//            return max;
//        }

//        public static int GetSum(int[] factors)
//        {
//            int sum = 0;
//            foreach (int f in factors) sum += f;
//            return sum;
//        }

//        public static long GetProduct(int[] factors)
//        {
//            long product = 1;
//            foreach (int f in factors) product *= f;
//            return product;
//        }

//        public static double GetCubeProduct(int[] factors)
//        {
//            double product = 1;
//            foreach (int f in factors)
//                product *= Math.Pow(f, 3);
//            return product;
//        }

//        public static bool IsPerfect(int number, int[] factors)
//        {
//            int sum = 0;
//            foreach (int f in factors)
//                if (f != number) sum += f;
//            return sum == number;
//        }

//        public static bool IsAbundant(int number, int[] factors)
//        {
//            int sum = 0;
//            foreach (int f in factors)
//                if (f != number) sum += f;
//            return sum > number;
//        }

//        public static bool IsDeficient(int number, int[] factors)
//        {
//            int sum = 0;
//            foreach (int f in factors)
//                if (f != number) sum += f;
//            return sum < number;
//        }

//        public static bool IsStrong(int number)
//        {
//            int temp = number;
//            int sum = 0;

//            while (temp > 0)
//            {
//                sum += Factorial(temp % 10);
//                temp /= 10;
//            }

//            return sum == number;
//        }

//        public static int Factorial(int n)
//        {
//            int fact = 1;
//            for (int i = 1; i <= n; i++) fact *= i;
//            return fact;
//        }
//    }
//}
