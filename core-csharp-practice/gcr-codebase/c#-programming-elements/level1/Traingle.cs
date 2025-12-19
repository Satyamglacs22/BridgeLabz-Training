using System;
public class Triangle{
public static void Main(){
double b,h;
b=double.Parse(Console.ReadLine());
h=double.Parse(Console.ReadLine());
double areaInInches=0.5*b*h;
double areaInCm=areaInInches*6.4516;
Console.WriteLine("Area in square inches is "+areaInInches+" and in square centimeters is "+areaInCm);
}
}
