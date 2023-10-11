using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab3.V5.Lib;


namespace Tyuiu.PenkovEU.ConsoleApp.Lab3.V5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      DataService ds = new DataService();
      bool result; int x; int y;
      Console.WriteLine("Вариант 5");
      Console.WriteLine("Выполнил студент группы НТм-22-1 Пеньков Евгений");
      Console.WriteLine($"Введите значение X : ");
      x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Введите значение Y : ");
      y = Convert.ToInt32(Console.ReadLine());

      result = ds.GetPointShape(x, y);

      if (result)
      {
        Console.WriteLine("Вы попали в часть фигуры");
      }

      else { Console.WriteLine("Вы не попали в фигуру"); }

      Console.ReadKey();
    }
  }
}
