using System;
using System.Collections.Generic;
using TriangleTracker;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("TRIANGLE TRACKER");
      Console.WriteLine("-------------------");
      Console.WriteLine("Enter the length of 3 sides of a triangle to see what kind it is.");
      Console.WriteLine("Side 1:");
      string stringSideOne = Console.ReadLine();
      Console.WriteLine("Side 2:");
      string stringSideTwo = Console.ReadLine();
      Console.WriteLine("Side 3:");
      string stringSideThree = Console.ReadLine();

      int sideOne = int.Parse(stringSideOne);
      int sideTwo = int.Parse(stringSideTwo);
      int sideThree = int.Parse(stringSideThree);

      Triangle triangleForCheck = new Triangle(sideOne, sideTwo, sideThree);
      Console.WriteLine(triangleForCheck.TriangleCheck());
    }
  }
}