using System;
class BMI{
static void Main(){
double w=double.Parse(Console.ReadLine());
double h=double.Parse(Console.ReadLine())/100;
double bmi=w/(h*h);
Console.WriteLine("BMI: "+bmi);
if(bmi<=18.4)
Console.WriteLine("Underweight");
else if(bmi<24.9 && bmi >18.5)
Console.WriteLine("Normal");
else if(bmi<39.9 && bmi >25.0)
Console.WriteLine("Overweight");
else 
Console.WriteLine("Obese");
}}
