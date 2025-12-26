using System;
public class Trip{
public static void Main(){
string name,fromCity,viaCity,toCity;
double fromToVia,viaToFinal,timeTaken;
name=Console.ReadLine();
fromCity=Console.ReadLine();
viaCity=Console.ReadLine();
toCity=Console.ReadLine();
fromToVia=double.Parse(Console.ReadLine());
viaToFinal=double.Parse(Console.ReadLine());
timeTaken=double.Parse(Console.ReadLine());
double totalDistance=fromToVia+viaToFinal;
double speed=totalDistance/timeTaken;
Console.WriteLine("The results of the trip are "+totalDistance+", "+timeTaken+", and "+speed);
}
}
