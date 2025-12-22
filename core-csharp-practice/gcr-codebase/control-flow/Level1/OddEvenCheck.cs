using System;
public class OddEvenCheck{
public static void Main(){
int n= int.Parse(Console.ReadLine());
if(n>0){
for(int i=1;i<=n;i++){
if(i%2==0){
Console.WriteLine($"The Number {i} is Even");
}
else{
Console.WriteLine($"The Number {i} is Odd");
}
}
}
}

}