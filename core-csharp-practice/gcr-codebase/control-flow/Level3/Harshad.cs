using System;
public class Harshad{
public static void Main(){
int number=int.Parse(Console.ReadLine());
int temp=number;
int sum=0;
while(temp!=0){
sum+=temp%10;
temp/=10;
}
Console.WriteLine(number%sum==0?"Harshad Number":"Not a Harshad Number");
}
}
