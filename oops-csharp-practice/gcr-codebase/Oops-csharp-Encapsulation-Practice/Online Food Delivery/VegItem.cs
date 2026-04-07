using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Online_Food_Delivery
{
    public class VegItem : FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return price * quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10; // 10% discount
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount 10%";
        }
    }


}
