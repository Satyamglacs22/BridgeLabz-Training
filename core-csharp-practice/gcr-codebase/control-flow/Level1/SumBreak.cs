using System;
class SumBreak{
static void Main(){
double total=0;
while(true){
double n=double.Parse(Console.ReadLine());
if(n<=0)
break;
total+=n;
}
Console.WriteLine(total);
}}
