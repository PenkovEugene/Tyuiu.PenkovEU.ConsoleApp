using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab2.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionV_5_1()
        {
            double x = 5;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_5_1(x);

            result = Math.Round(result, 9);
            double wait = -0.386720044;

            Assert.AreEqual(result, wait);
        }

        [TestMethod]
        public void ValidExpressionV_5_2()
        {
            double x = 5;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_5_2(x);

            result = Math.Round(result, 8);
            double wait = 96.48424571;

            Assert.AreEqual(result, wait);
        }
    }
}
