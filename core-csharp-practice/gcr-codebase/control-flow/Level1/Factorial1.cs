using System;
public class Factorial1{
public static void Main(){
int n=int.Parse(Console.ReadLine());
int val=1;
int temp=n;
for(int i=1;i<=temp;i++){
val *=i;
}
Console.WriteLine($"Factorial of number {n} is {val}");
}
}
