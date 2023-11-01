using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab5.V5.Lib;


namespace Tyuiu.PenkovEU.ConsoleApp.Lab5.V5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      DataService ds = new DataService();

      double result;
      int n;
      Console.WriteLine("Вариант 5");
      Console.WriteLine("Выполнил студент группы НТм-22-1 Пеньков Евгений");
      Console.WriteLine("Введите число N: ");
      n = Convert.ToInt32(Console.ReadLine());
      
      result = ds.GetSum(n);

      Console.WriteLine($"Ответ: {result}");

      Console.ReadKey();
    }
  }
}
