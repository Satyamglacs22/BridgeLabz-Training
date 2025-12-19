using System;
public class Income{
public static void Main(){
double salary,bonus;
salary=double.Parse(Console.ReadLine());
bonus=double.Parse(Console.ReadLine());
double income=salary+bonus;
Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+income);
}
}
