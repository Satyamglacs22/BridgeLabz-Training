using System;
public class Computation{
public static void Main(){
int n=int.Parse(Console.ReadLine());
if(n>0){
int sumF=n*(n+1)/2;
int sumW=0;
int temp=n;
while(temp>0){
sumW+=temp;
temp--;
}
if(sumF==sumW){
Console.WriteLine("Both Computations were Correct");
}
else{
Console.WriteLine("Computations were Not Correct");
}
}
else{
Console.WriteLine("The number is not a natural number");
}
}
}
