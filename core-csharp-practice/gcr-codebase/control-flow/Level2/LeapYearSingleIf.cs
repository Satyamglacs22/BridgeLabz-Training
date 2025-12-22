using System;
class LeapYearSingleIf{
static void Main(){
int y=int.Parse(Console.ReadLine());
if(y>=1582&&(y%400==0||(y%4==0&&y%100!=0)))
Console.WriteLine("Year is a Leap Year");
else 
Console.WriteLine("Year is not a Leap Year");
}
}
