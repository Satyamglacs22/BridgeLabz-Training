using System;
class SumUntilZero{
 public static void Main(){
double total=0,num;
while((num=double.Parse(Console.ReadLine()))!=0)
{
total+=num;
}
Console.WriteLine(total);
}}
