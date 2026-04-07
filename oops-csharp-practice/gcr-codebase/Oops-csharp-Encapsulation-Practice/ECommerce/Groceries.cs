using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.ECommerce
{
    public class Groceries : Product
    {
        public Groceries(double price)
        {
            Price = price;
        }

        public override double CalculateDiscount()
        {
            return 0; // No discount
        }
    }

}
