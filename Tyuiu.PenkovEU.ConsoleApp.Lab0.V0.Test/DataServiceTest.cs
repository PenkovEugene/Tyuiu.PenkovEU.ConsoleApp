using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PenkovEU.ConsoleApp.Lab0.V0.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAdd()
        {
            DataService ds = new DataService();

            int a = 5, b = 5;
            var result = ds.Add(a, b);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ValidMinus()
        {
            DataService ds = new DataService();

            int a = 5, b = 5;
            var result = ds.Minus(a, b);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ValidMultiplication()
        {
            DataService ds = new DataService();

            int a = 5, b = 5;
            var result = ds.Multiplication(a, b);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void ValidDivision()
        {
            DataService ds = new DataService();

            int a = 5, b = 5;
            var result = ds.Division(a, b);

            Assert.AreEqual(1, result);
        }
    }
}
