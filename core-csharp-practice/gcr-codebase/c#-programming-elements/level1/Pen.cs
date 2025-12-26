using System;
public class Pen{
  public static void Main(){
   int pens=14;
   int students=3;
   int penperstudent= pens/students;
   int left= pens%students;
   Console.WriteLine("The Pen Per Student is " + penperstudent +"and the remaining pen not distributed is " + left);
   
   }
   }
   