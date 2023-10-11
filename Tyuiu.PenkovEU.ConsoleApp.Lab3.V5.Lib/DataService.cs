using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab3.V5.Lib
{
  public class DataService
  {
    public bool GetPointShape(int x, int y)
    {
      bool result;
      if (((x == 3) && (((y >= 3) && (y <= 4)) | (y == 11)))
          | ((x == 4) && ((y >= 3) && (y <= 11)))
          | ((x == 5) && (((y >= 3) && (y <= 4)) | (y == 11)))
          | ((x == 6) && ((y >= 9) && (y <= 11)))
          | ((x == 7) && (y == 6) | ((y >= 9) && (y <= 11)))
          | (((x >= 7) && (x <= 10)) && (y == 12))
          | ((x == 8) && ((y >= 5) && (y <= 11)))
          | (((x >= 9) && (x <= 12)) && ((y >= 3) && (y <= 11)))
          | ((x == 13) && ((y >= 6) && (y <= 8)))
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
