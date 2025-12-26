using System;
public class Height{
public static void Main(){
double cm;
cm=double.Parse(Console.ReadLine());
double inches=cm/2.54;
double feet=inches/12;
Console.WriteLine("Your Height in cm is "+cm+" while in feet is "+feet+" and inches is "+inches);
}
}
