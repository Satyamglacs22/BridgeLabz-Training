using System;
public class Chocolates{
public static void Main(){
int numberOfChocolates,numberOfChildren;
numberOfChocolates=int.Parse(Console.ReadLine());
numberOfChildren=int.Parse(Console.ReadLine());
int each=numberOfChocolates/numberOfChildren;
int remaining=numberOfChocolates%numberOfChildren;
Console.WriteLine("The number of chocolates each child gets is "+each+" and the number of remaining chocolates is "+remaining);
}
}
