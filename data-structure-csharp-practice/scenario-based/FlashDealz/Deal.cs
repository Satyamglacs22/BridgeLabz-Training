using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class Deal
    {
        private int discount;   // private data member

        // Setter
        public void SetDiscount(int discount)
        {
            this.discount = discount;
        }

        // Getter
        public int GetDiscount()
        {
            return discount;
        }
    }
}
