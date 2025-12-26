using System;
public class Purchase{
public static void Main(){
double unitPrice;
int quantity;
unitPrice=double.Parse(Console.ReadLine());
quantity=int.Parse(Console.ReadLine());
double total=unitPrice*quantity;
Console.WriteLine("The total purchase price is INR "+total+" if the quantity "+quantity+" and unit price is INR "+unitPrice);
}
}
