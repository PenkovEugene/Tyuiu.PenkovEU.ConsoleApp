using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionV_1_1()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_1_1(x, y, a);

            result = Math.Round(result, 6);
            double wait = 534.387395;

            Assert.AreEqual(result, wait);

        }

        [TestMethod]
        public void ValidExpressionV_1_2()
        {
            double x = 4;
            double y = -3;
            double a = 7;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_1_2(x, y, a);

            result = Math.Round(result, 8);
            double wait = 19.78571429;

            Assert.AreEqual(result, wait);

        }

        [TestMethod]
        public void ValidExpressionV_5_1()
        {
            double x = 5;
            double y = 15;
            double a = 45;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_5_1(x, y, a);

            result = Math.Round(result, 7);
            double wait = 166.0768634;

            Assert.AreEqual(result, wait);

        }

        [TestMethod]
        public void ValidExpressionV_5_2()
        {
            double x = 5;
            double y = 15;
            double a = 45;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_5_2(x, y, a);

            result = Math.Round(result, 7);
            double wait = 116.9346405;

            Assert.AreEqual(result, wait);

        }
    }
}
