using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.ECommerce
{
    public class Electronics : Product, ITaxable
    {
        public Electronics(double price)
        {
            Price = price;
        }

        public override double CalculateDiscount()
        {
            return price * 0.10; // 10% discount
        }

        public double CalculateTax()
        {
            return price * 0.18; // 18% GST
        }

        public string GetTaxDetails()
        {
            return "Electronics GST 18%";
        }
    }


}
