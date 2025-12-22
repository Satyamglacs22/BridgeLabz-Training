using System;
public class Computation1{
public static void Main(){
int n=int.Parse(Console.ReadLine());
if(n>0){
int sumF=n*(n+1)/2;
int sumW=0;
int temp=n;
for(int i=1;i<=temp;i++){
	sumW +=i;
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
