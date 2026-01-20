using System;

namespace GenericProduct
{
    internal class DiscountUtility
    {
        public static void ApplyDiscount<T>(T product, double percentage) where T : Product
        {
            product.ApplyDiscount(percentage);
            Console.WriteLine($"Discount applied on {product.ProductName}. New Price: {product.Price}");
        }
    }
}
