using System;

public class Discounted
{
    public static void Main()
    {
        int fee = 125000;
        int discount = 10;

        double discounted = (fee * discount) / 100.0;
        double discountedPrice = fee - discounted;

        Console.WriteLine("The discount amount is INR " + discounted +
                          " and the final discounted fee is INR " + discountedPrice);
    }
}
