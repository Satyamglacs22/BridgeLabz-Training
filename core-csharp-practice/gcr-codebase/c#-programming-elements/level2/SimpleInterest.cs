using System;
public class SimpleInterest{
public static void Main(){
double principal,rate,time;
principal=double.Parse(Console.ReadLine());
rate=double.Parse(Console.ReadLine());
time=double.Parse(Console.ReadLine());
double si=(principal*rate*time)/100;
Console.WriteLine("The Simple Interest is "+si+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
}
}
