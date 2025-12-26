using System;
public class LeapYear{
 public static void Main(){
int y=int.Parse(Console.ReadLine());
if(y>=1582){
if(y%400==0)Console.WriteLine("Year is a Leap Year");
else if(y%100==0)Console.WriteLine("Year is not a Leap Year");
else if(y%4==0)Console.WriteLine("Year is a Leap Year");
else Console.WriteLine("Year is not a Leap Year");
}
else Console.WriteLine("Year is not in Gregorian calendar");
}
}
