using System;
public class DiscountFee{
public static void Main(){
double fee,discountPercent;
fee=double.Parse(Console.ReadLine());
discountPercent=double.Parse(Console.ReadLine());
double discount=(fee*discountPercent)/100;
double finalFee=fee-discount;
Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+finalFee);
}
}
