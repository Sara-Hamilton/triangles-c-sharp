using System;
using System.Collections.Generic;

namespace Triangles.Models
{
  public class Triangle
  {
    private int _sideA;
    private int _sideB;
    private int _sideC;
    private string _type;

    // public Triangle(int sideA, int sideB, int sideC)
    // {
    //   _sideA = sideA;
    //   _sideB = sideB;
    //   _sideC = sideC;
    // }

    public void SetSideA(int newSideA)
    {
      _sideA = newSideA;
    }

    public int GetSideA()
    {
      return _sideA;
    }

    public void SetSideB(int newSideB)
    {
      _sideB = newSideB;
    }

    public int GetSideB()
    {
      return _sideB;
    }

    public void SetSideC(int newSideC)
    {
      _sideC = newSideC;
    }

    public int GetSideC()
    {
      return _sideC;
    }

    public void SetType(string newType)
    {
      _type = newType;
    }

    public string GetType()
    {
      return _type;
    }

    public bool IsTriangle(Triangle triangle)
    {
      if ((_sideA >= _sideB + _sideC) || (_sideB >= _sideA + _sideC) || (_sideC >= _sideA + _sideB))
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public bool IsEquilateral(Triangle triangle)
    {
      if ((_sideA == _sideB) && (_sideB == _sideC))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsIsosceles(Triangle triangle)
    {
      if ((_sideA == _sideB) || (_sideB == _sideC) || (_sideA == _sideC))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string DetermineType(Triangle triangle)
    {
      if (!triangle.IsTriangle(triangle))
      {
        return "Not a Triangle";
      }
      else if (triangle.IsEquilateral(triangle))
      {
        return "Equilateral";
      }
      else if (triangle.IsIsosceles(triangle))
      {
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }

  }
}



// public class Program
// {
//   public static void Main()
//   {
//     Triangle triangle1 = new Triangle(5, 3, 2);
//     // triangle1.SetSideA(5);
//     // triangle1.SetSideB(3);
//     // triangle1.SetSideC(2);
//     string result = triangle1.DetermineType(triangle1);
//     Console.WriteLine(result);
//   }
// }
