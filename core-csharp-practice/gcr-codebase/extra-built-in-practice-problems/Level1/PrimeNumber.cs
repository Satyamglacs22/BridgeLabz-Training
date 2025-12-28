using System;
using System.Collections.Generic;
using System.Text;

namespace String_Extra
{
    public class PrimeNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            CheckPrime(n);
        }

        public static void CheckPrime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Not a Prime Number");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}
