using System;
public class QuotientRemainder{
public static void Main(){
int number1,number2;
number1=int.Parse(Console.ReadLine());
number2=int.Parse(Console.ReadLine());
int quotient=number1/number2;
int remainder=number1%number2;
Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2);
}
}
