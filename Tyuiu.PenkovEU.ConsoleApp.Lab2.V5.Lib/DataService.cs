using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab2.V5.Lib
{
    public class DataService
    {
        public double SolveExpressV_5_1(double x) 
        {
            double result = (Math.Log10(Math.Abs(Math.Cos(x)))) / (Math.Log10(1 + Math.Pow(x, 2)));
            return result;
        }

        public double SolveExpressV_5_2(double x)
        {
            double result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - ((Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x));
            return result;
        }
    }
}
