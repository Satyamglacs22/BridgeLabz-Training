using System;
public class Handshakes{
public static void Main(){
int numberOfStudents;
numberOfStudents=int.Parse(Console.ReadLine());
int handshakes=(numberOfStudents*(numberOfStudents-1))/2;
Console.WriteLine("The maximum number of handshakes is "+handshakes);
}
}
