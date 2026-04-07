using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal interface IDeal
    {
        void QuickSort(Deal[] deals, int low, int high);
        void DisplayDeals(Deal[] deals);
    }
}
