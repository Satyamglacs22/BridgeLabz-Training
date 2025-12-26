using System;
public class CelsiusToFahrenheit{
public static void Main(){
double celsius;
celsius=double.Parse(Console.ReadLine());
double fahrenheit=(celsius*9/5)+32;
Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
}
}
