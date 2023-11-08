using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab6.V5.Lib
{
    public class DataService
    {
      public double[] GetMassFunction(int startValue, int stopValue)
      {
        double[] valueArray;
        int len = (stopValue - startValue) + 1;
        valueArray = new double[len];
        double y;
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
          y = Math.Round((Math.Pow(((Math.Pow(x, 2) + (1 / Math.Pow(x, 2)))), x) - 12 * Math.Pow(x, 2)), 2);
          valueArray[count] = y;
          if (x == 0)
          {
            valueArray[count] = 0;
          }
          count++;
        }

        return valueArray;
      }
    }
}
