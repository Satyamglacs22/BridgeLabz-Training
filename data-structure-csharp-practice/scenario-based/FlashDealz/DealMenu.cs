using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class DealMenu
    {
        public Deal[] TakeDealInput()
        {
            Console.WriteLine("Enter number of deals:");
            int size = int.Parse(Console.ReadLine());

            Deal[] deals = new Deal[size];

            for (int i = 0; i < size; i++)
            {
                deals[i] = new Deal();

                Console.Write("Enter discount for deal " + (i + 1) + ": ");
                int discount = int.Parse(Console.ReadLine());

                deals[i].SetDiscount(discount);
            }

            return deals;
        }
    }
}
