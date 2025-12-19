using System;
public class DoubleOperation{
public static void Main(){
double a,b,c;
a=double.Parse(Console.ReadLine());
b=double.Parse(Console.ReadLine());
c=double.Parse(Console.ReadLine());
double r1=a+b*c;
double r2=a*b+c;
double r3=c+a/b;
double r4=a%b+c;
Console.WriteLine("The results of Double Operations are "+r1+", "+r2+", "+r3+", and "+r4);
}
}
