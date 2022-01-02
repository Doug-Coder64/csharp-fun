using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double area = Triangle(750,500)+Rect(1500, 2500)+(Circle(375)/2);
      double cost = 180;
      Console.WriteLine($"Flooring Cost is {CalculateTotalCost(area, cost)}");
    }

    public static double Rect(double length, double width){
      return length*width;
    }

    public static double Circle(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }

    public static double Triangle(double bottom, double height){
      return 0.5 * bottom * height;
    }

    public static double CalculateTotalCost(double area, double cost){
        double totalCost = Math.Round((area*cost), 2);
        return totalCost;
    }
  }
}
