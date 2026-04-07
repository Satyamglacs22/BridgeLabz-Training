using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Online_Food_Delivery
{
   

    public class FoodUtility
    {
        public void Run()
        {
            List<FoodItem> items = new List<FoodItem>();

            FoodItem veg = new VegItem
            {
                ItemName = "Paneer Butter Masala",
                Price = 200,
                Quantity = 2
            };

            FoodItem nonVeg = new NonVegItem
            {
                ItemName = "Chicken Biryani",
                Price = 250,
                Quantity = 1
            };

            items.Add(veg);
            items.Add(nonVeg);

            foreach (FoodItem item in items)
            {
                item.GetItemDetails();

                double total = item.CalculateTotalPrice();
                double discount = 0;

                if (item is IDiscountable)
                {
                    IDiscountable discountable = (IDiscountable)item;
                    discount = discountable.ApplyDiscount();
                    Console.WriteLine("Discount Info : " + discountable.GetDiscountDetails());
                }

                Console.WriteLine("Total Price   : " + total);
                Console.WriteLine("Discount      : " + discount);
                Console.WriteLine("Final Amount  : " + (total - discount));
                Console.WriteLine("-----------------------------");
            }
        }
    }

}
