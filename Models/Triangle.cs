using System;
using System.Collections.Generic;

namespace Triangle.Models
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
      _sideA = newSideB;
    }

    public int GetSideB()
    {
      return _sideB;
    }

    public void SetSideC(int newSideC)
    {
      _sideA = newSideC;
    }

    public int GetSideC()
    {
      return _sideC;
    }

    public void SetType(int newType)
    {
      _type = newType;
    }

    public int GetType()
    {
      return _type;
    }

  }
}
