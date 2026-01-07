using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.ECommerce
{
    public class Clothing : Product, ITaxable
    {
        public Clothing(double price)
        {
            Price = price;
        }

        public override double CalculateDiscount()
        {
            return price * 0.20; // 20% discount
        }

        public double CalculateTax()
        {
            return price * 0.05; // 5% tax
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax 5%";
        }
    }

}
