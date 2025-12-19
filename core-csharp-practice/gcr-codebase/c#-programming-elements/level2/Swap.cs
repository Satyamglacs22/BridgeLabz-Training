using System;
public class Swap{
public static void Main(){
int number1,number2,temp;
number1=int.Parse(Console.ReadLine());
number2=int.Parse(Console.ReadLine());
temp=number1;
number1=number2;
number2=temp;
Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
}
}
