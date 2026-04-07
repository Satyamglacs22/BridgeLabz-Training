using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.ECommerce
{
    

    public class ECommerceUtility
    {
        public void Run()
        {
            List<Product> products = new List<Product>();

            Product p1 = new Electronics(50000)
            {
                ProductId = 1,
                Name = "Laptop"
            };

            Product p2 = new Clothing(2000)
            {
                ProductId = 2,
                Name = "Jacket"
            };

            Product p3 = new Groceries(500)
            {
                ProductId = 3,
                Name = "Rice Bag"
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            foreach (Product product in products)
            {
                product.DisplayProduct();

                double tax = 0;

                if (product is ITaxable)
                {
                    ITaxable taxable = (ITaxable)product;
                    tax = taxable.CalculateTax();
                    Console.WriteLine("Tax Info     : " + taxable.GetTaxDetails());
                }

                Console.WriteLine("Discount     : " + product.CalculateDiscount());
                Console.WriteLine("Final Price  : " + product.CalculateFinalPrice(tax));
                Console.WriteLine("-----------------------------");
            }
        }
    }


}
