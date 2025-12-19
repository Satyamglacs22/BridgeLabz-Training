using System;
public class ProfitLoss{
 public static void Main(){
   int cp=129;
   int sp=191;
   Console.WriteLine("The Cost Price is INR " + cp + "The Selling Price is INR " + sp);
   if(sp>cp){
     int profit= sp-cp;
	 double profitp= (profit*100)/cp;
	 Console.WriteLine("The Profit is INR "+ profit +" and the Profit Percentage is " + profitp);
	 }
	 }
}