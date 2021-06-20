using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of the item");
    var name = Console.ReadLine();
    Console.WriteLine("Enter the quantity");
var x = Console.ReadLine();//2 becomes "2"
Console.WriteLine("Enter the price");
var y = Console.ReadLine();//

int x1 = Convert.ToInt32(x);
double y1 = Convert.ToDouble(y);
Console.Write("The Total Price of " + name ); 
Console.Write(" = $");

Console.Write(x1*y1);
Console.WriteLine();


  }
}