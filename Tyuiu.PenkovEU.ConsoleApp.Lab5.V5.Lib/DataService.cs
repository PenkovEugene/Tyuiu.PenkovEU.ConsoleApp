using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab5.V5.Lib
{
    public class DataService
    {
    public double GetSum(int n)
    {
      double sum = 0;
      for (int i = 1; i <= n; i++) 
      {
        sum = sum + ((5 * (Math.Pow(i, 2)) - Math.Cos(Math.Pow(i, 2))) / (3 * Math.Pow(i, 3) - Math.Cos(Math.Pow(i, 2))));        
      }
      return Math.Round(sum, 3);
    }

  }
}
