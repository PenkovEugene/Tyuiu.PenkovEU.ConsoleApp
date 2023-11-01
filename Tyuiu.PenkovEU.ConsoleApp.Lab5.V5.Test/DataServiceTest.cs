using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab5.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab5.V5.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void ValidGetSum()
    {
      DataService ds = new DataService();

      int n = 10;

      double result = ds.GetSum(n);
      double wait = 5.038;

      Assert.AreEqual(wait, result);
    }
  }
}
