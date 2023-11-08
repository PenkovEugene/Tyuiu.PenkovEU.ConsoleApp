using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab6.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab6.V5.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void ValidCalc()
    {
      DataService ds = new DataService();

      int startValue = -5;
      int stopValue = -1;
      int len = stopValue - startValue + 1;

      double[] valueWaitArray;
      valueWaitArray = new double[len];

      valueWaitArray[0] = -300;
      valueWaitArray[1] = -192;
      valueWaitArray[2] = -108;
      valueWaitArray[3] = -47.94;
      valueWaitArray[4] = -11.5;
      //valueWaitArray[5] = 0;
      //valueWaitArray[6] = -10;
      //valueWaitArray[7] = -29.94;
      //valueWaitArray[8] = 648.33;
      //valueWaitArray[9] = 66374.02;
      //valueWaitArray[10] = 9843700.4;


      double[] res;
      res = new double[len];
      res = ds.GetMassFunction(startValue, stopValue);
      CollectionAssert.AreEqual(valueWaitArray, res);
    }
  }
}
