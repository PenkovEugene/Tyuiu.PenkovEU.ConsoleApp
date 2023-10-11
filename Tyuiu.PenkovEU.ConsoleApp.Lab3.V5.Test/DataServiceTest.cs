using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab3.V5.Lib;


namespace Tyuiu.PenkovEU.ConsoleApp.Lab3.V5.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void ValidGetPoint()
    {
      DataService ds = new DataService();

      int x = 8; int y = 5;

      bool result = ds.GetPointShape(x, y);
      bool wait = true;


      Assert.AreEqual(wait, result);
    }
  }
}
