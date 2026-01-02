using System;
using System.Collections.Generic;
using System.Text;

namespace Diwali_Mela
{
    public class LuckyDraw
    {
        public static void Main()
        {
            LuckyDraw obj = new LuckyDraw();

            Console.WriteLine("Enter number of visitors:");
            int visitors = int.Parse(Console.ReadLine());

            for (int i = 1; i <= visitors; i++)
            {
                Console.WriteLine($"Visitor {i}, enter number:");

                try
                {
                    int number = int.Parse(Console.ReadLine());
                    obj.CheckWin(number);
                }
                catch
                {
                    Console.WriteLine("Invalid input, moving to next visitor.");
                    continue;
                }
            }
        }

        public void CheckWin(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Congratulations! You won a gift");
            }
            else
            {
                Console.WriteLine("Better Luck Next time.");
            }
        }
    }
}
