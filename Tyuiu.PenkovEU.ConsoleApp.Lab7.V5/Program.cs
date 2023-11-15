using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab7.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab7.V5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите количество элементов массива: ");
      int len = Convert.ToInt16(Console.ReadLine());
      int[] numsArray = new int[len];
      Random random = new Random();

      Console.WriteLine("Введите начало диапазона чисел: ");
      int start = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine("Введите конца диапазона чисел: ");
      int end = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine("Введите число, которые вы ходите найти в массиве: ");
      int num = Convert.ToInt16(Console.ReadLine());

      for (int i = 0; i < len; i++)
      {
        numsArray[i] = random.Next(start, end);
      }

      Console.WriteLine("****************************************");
      for (int i = 0; i < len; i++)
      {
        Console.Write(numsArray[i] + "\t");
      }

      DataService ds = new DataService();
      Console.WriteLine();
      Console.WriteLine($"Количество отрицательных элементов: {ds.CountNegativeNumInArray(numsArray)}");
      Console.WriteLine($"Количество положительных элементов: {ds.CountPositiveNumInArray(numsArray)}");
      Console.WriteLine($"Количество четных элементов: {ds.CountChetNumInArray(numsArray)}");
      Console.WriteLine($"Количество нечетных элементов: {ds.CountNeChetNumInArray(numsArray)}");
      Console.WriteLine($"Число {num} находится в массиве: {ds.CountNumInArray(numsArray, num)}");
      Console.WriteLine($"Среднее значение элементов массива равно: {ds.CountMiddleNumInArray(numsArray)}");
      Console.WriteLine($"Минимальное значение элементов массива равно: {ds.CountMinNumInArray(numsArray)}");


      Console.ReadKey();


      //Console.WriteLine("Введите количество элементов массива: ");
      //int len = Convert.ToInt16(Console.ReadLine());
      //int[] numsArray = new int[len];

      //for (int i = 0; i < len; i++)
      //{
      //  Console.WriteLine($"Введите {i}  элемент массива: ");
      //  numsArray[i] = Convert.ToInt16(Console.ReadLine());
      //}

      //Console.WriteLine("***************************************");

      //for (int i = 0; i < len;i++)
      //{
      //  Console.Write(numsArray[i] + "\t");
      //}

      //int count = 0;
      //for (int i = 0; i < len; i++)
      //{
      //  if (numsArray[i] % 2 == 0)
      //  {
      //    count++;
      //  }
      //}
      //int plus = 0;
      //int minus = 0;
      //for (int i = 0; i < len; i++)
      //{
      //  if (numsArray[i] >= 0)
      //  {
      //    plus++;
      //  } else
      //  {
      //    minus++;
      //  }
      //}
      //Console.WriteLine();
      //Console.WriteLine($"Количество четных элементов в массиве: {count}");
      //Console.WriteLine($"Количество положительных чисел {plus}");
      //Console.WriteLine($"Количество отрицательных чисел {minus}");

      //Console.ReadKey();
    }
  }
}
