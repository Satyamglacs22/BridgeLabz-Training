using System;
public class Athlete{
public static void Main(){
double side1,side2,side3;
side1=double.Parse(Console.ReadLine());
side2=double.Parse(Console.ReadLine());
side3=double.Parse(Console.ReadLine());
double perimeter=side1+side2+side3;
double rounds=5000/perimeter;
Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
}
}
