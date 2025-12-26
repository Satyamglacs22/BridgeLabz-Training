using System;
class Friends{
static void Main(){
int aAge=int.Parse(Console.ReadLine());
int bAge=int.Parse(Console.ReadLine());
int cAge=int.Parse(Console.ReadLine());
int aH=int.Parse(Console.ReadLine());
int bH=int.Parse(Console.ReadLine());
int cH=int.Parse(Console.ReadLine());
if(aAge<bAge&&aAge<cAge)
Console.WriteLine("Amar is youngest");
else if(bAge<cAge)
Console.WriteLine("Akbar is youngest");
else 
Console.WriteLine("Anthony is youngest");
if(aH>bH&&aH>cH)
Console.WriteLine("Amar is tallest");
else if(bH>cH)
Console.WriteLine("Akbar is tallest");
else 
Console.WriteLine("Anthony is tallest");
}}
