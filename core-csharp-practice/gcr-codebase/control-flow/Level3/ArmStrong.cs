using System;
public class Armstrong{
public static void Main(){
int number=int.Parse(Console.ReadLine());
int originalNumber=number;
int sum=0;
while(originalNumber!=0){
int rem=originalNumber%10;
sum+=rem*rem*rem;
originalNumber/=10;
}
Console.WriteLine(sum==number?"Armstrong Number":"Not an Armstrong Number");
}
}
