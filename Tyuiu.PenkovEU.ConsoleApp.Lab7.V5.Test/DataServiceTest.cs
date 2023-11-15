using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab7.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab7.V5.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void CheckedNegative()
    {
      DataService ds = new DataService();
      int[] mas = {-1, 2, -3, 4, 8};
      int result = ds.CountNegativeNumInArray(mas);

      int wait = 2;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedPositive()
    {
      DataService ds = new DataService();
      int[] mas = { -1, 2, -3, 4, 8 };
      int result = ds.CountPositiveNumInArray(mas);

      int wait = 3;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedChet()
    {
      DataService ds = new DataService();
      int[] mas = { -1, 2, -3, 4, 8 };
      int result = ds.CountChetNumInArray(mas);

      int wait = 3;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedNeChet()
    {
      DataService ds = new DataService();
      int[] mas = { -1, 2, -3, 4, 8 };
      int result = ds.CountNeChetNumInArray(mas);

      int wait = 2;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedNumInArray()
    {
      DataService ds = new DataService();
      int[] mas = { -1, 2, -3, 4, 8, 0 };
      int num = 0;
      bool result = ds.CountNumInArray(mas, num);

      bool wait = true;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedMiddleNumInArray()
    {
      DataService ds = new DataService();
      int[] mas = { 1, 2, 3, 4, 5 };
      float result = ds.CountMiddleNumInArray(mas);

      float wait = 3;
      Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void CheckedMinNum()
    {
      DataService ds = new DataService();
      int[] mas = { -1, 2, -3, 4, 8 };
      int result = ds.CountMinNumInArray(mas);

      int wait = -3;
      Assert.AreEqual(wait, result);
    }
  }
}
