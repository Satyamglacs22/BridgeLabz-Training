using System;

namespace Pipe_Cutting
{
    public class PipeInput
    {
        public static int TakePipeLength()
        {
            Console.Write("Enter Total Pipe Length: ");
            return int.Parse(Console.ReadLine());
        }

        public static int[] TakeLengths(int n)
        {
            int[] lengths = new int[n];
            Console.WriteLine("Enter available lengths:");

            for (int i = 0; i < n; i++)
            {
                lengths[i] = int.Parse(Console.ReadLine());
            }
            return lengths;
        }

        public static int[] TakePrices(int n)
        {
            int[] prices = new int[n];
            Console.WriteLine("Enter prices for each length:");

            for (int i = 0; i < n; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }
            return prices;
        }
    }
}
