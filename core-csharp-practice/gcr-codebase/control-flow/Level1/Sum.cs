using System;
public class Sum{
public static void Main(){
int n= int.Parse(Console.ReadLine());
if(n>0){
int sum= n*(n+1)/2;
Console.WriteLine($"The Sum of {n} natural Numbers is {sum}");
}
else{
Console.WriteLine($"The Number {n} is not a natural number ");
}
}
}
 
