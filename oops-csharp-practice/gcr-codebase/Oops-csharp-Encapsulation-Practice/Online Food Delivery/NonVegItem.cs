using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Online_Food_Delivery
{
    public class NonVegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            double extraCharge = 50;
            return (price * quantity) + extraCharge;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05; // 5% discount
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Item Discount 5%";
        }
    }

}
