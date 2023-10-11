using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab3.V0.Lib
{
    public class DataService
    {
        public bool GetPointShape(int x, int y) {
            bool result;
            if ((x >= -3 && x <= 3) && (y >= -3 && y <= 3)) { 
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
