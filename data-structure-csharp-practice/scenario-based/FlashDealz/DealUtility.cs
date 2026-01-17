using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class DealUtility : IDeal
    {
        public void QuickSort(Deal[] deals, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(deals, low, high);

                QuickSort(deals, low, pivotIndex - 1);
                QuickSort(deals, pivotIndex + 1, high);
            }
        }

        private int Partition(Deal[] deals, int low, int high)
        {
            int pivot = deals[high].GetDiscount();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // Descending order (highest discount first)
                if (deals[j].GetDiscount() > pivot)
                {
                    i++;
                    Swap(deals, i, j);
                }
            }

            Swap(deals, i + 1, high);
            return i + 1;
        }

        private void Swap(Deal[] deals, int i, int j)
        {
            Deal temp = deals[i];
            deals[i] = deals[j];
            deals[j] = temp;
        }

        public void DisplayDeals(Deal[] deals)
        {
            for (int i = 0; i < deals.Length; i++)
            {
                Console.Write(deals[i].GetDiscount() + "% ");
            }
            Console.WriteLine();
        }
    }
}
