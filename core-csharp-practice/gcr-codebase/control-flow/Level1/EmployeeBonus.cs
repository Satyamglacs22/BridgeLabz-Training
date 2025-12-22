using System;
class EmployeeBonus{
static void Main(){
double salary=double.Parse(Console.ReadLine());
int years=int.Parse(Console.ReadLine());
Console.WriteLine(years>5?salary*0.05:0);
}}
