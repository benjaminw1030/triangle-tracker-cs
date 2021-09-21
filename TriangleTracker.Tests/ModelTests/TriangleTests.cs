using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void TriangleCheck_IsTriangleEquilateral_Equilateral()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual("This triangle is equilateral.", testTriangle.TriangleCheck());
    }

    [TestMethod]
    public void TriangleCheck_IsTriangleIsosceles_Isosceles()
    {
      Triangle testTriangle = new Triangle(4, 4, 5);
      Assert.AreEqual("This triangle is isosceles.", testTriangle.TriangleCheck());
    }
    
    [TestMethod]
    public void TriangleCheck_IsTriangleScalene_Scalene()
    {
      Triangle testTriangle = new Triangle (2, 3, 4);
      Assert.AreEqual("This triangle is scalene.", testTriangle.TriangleCheck());
    }

    [TestMethod]
    public void TriangleCheck_IsTriangleNotATriangle_NotATriangle()
    {
      Triangle testTriangle = new Triangle (1, 3, 4);
      Assert.AreEqual("This is not a triangle.", testTriangle.TriangleCheck());
    }
  }
}