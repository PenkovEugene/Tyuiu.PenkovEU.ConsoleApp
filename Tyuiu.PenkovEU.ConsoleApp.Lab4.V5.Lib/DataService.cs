using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab4.V5.Lib
{
  
    public class DataService
    {
    public bool GetPointShape(double x, double y)
    {
      bool result;
      double e = Math.Exp(1);

      if ((y > (Math.Pow(x, 2))) && (y < (Math.Pow(e, -x))) && (y < (Math.Pow(e, x)))
        )
          
      {
        result = true;
      }

      else
      {
        result = false;
      }

      return result;
    }
  }
}
