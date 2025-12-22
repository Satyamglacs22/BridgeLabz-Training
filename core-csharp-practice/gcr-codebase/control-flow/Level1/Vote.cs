using System;
public class Vote{
public static void Main(){
int n= int.Parse(Console.ReadLine());
if(n>18){
Console.WriteLine($"The Person's age is {n} and can Vote");
}
else{
Console.WriteLine($"The Person's age is {n} and cannot Vote");
}
}
}
     