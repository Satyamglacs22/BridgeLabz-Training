using System;
public class Calculator{
public static void Main(){
double number1,number2;
number1=double.Parse(Console.ReadLine());
number2=double.Parse(Console.ReadLine());
double add=number1+number2;
double sub=number1-number2;
double mul=number1*number2;
double div=number1/number2;
Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+add+", "+sub+", "+mul+", and "+div);
}
}
