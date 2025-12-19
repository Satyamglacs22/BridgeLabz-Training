using System;
public class Distance{
public static void Main(){
double feet;
feet=double.Parse(Console.ReadLine());
double yards=feet/3;
double miles=yards/1760;
Console.WriteLine("Distance in yards is "+yards+" and in miles is "+miles);
}
}
