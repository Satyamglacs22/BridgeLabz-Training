using System;
public class Factorial{
public static void Main(){
int n=int.Parse(Console.ReadLine());
int val=1;
int temp=n;
while(temp>0){
val*=temp;
temp--;
}
Console.WriteLine($"Factorial of number {n} is {val}");
}
}
