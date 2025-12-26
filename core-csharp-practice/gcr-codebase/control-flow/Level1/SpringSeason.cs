using System;
class SpringSeason{
static void Main(){
int m=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());
bool s=(m==3&&d>=20 && d<32)||(m==4 && d<31 && d>0)||(m==5 && d<30 && d>0)||(m==6&&d<=20 && d>0);
Console.WriteLine(s?"Its a Spring Season":"Not a Spring Season");
}}
