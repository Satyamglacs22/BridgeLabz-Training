using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class Program
    {
        static void Main()
        {
            DealMenu menu = new DealMenu();
            DealUtility utility = new DealUtility();

            Deal[] deals = menu.TakeDealInput();

            Console.WriteLine("\nBefore Sorting:");
            utility.DisplayDeals(deals);

            utility.QuickSort(deals, 0, deals.Length - 1);

            Console.WriteLine("\nAfter Sorting (Top Discounts First):");
            utility.DisplayDeals(deals);
        }
    }
}
