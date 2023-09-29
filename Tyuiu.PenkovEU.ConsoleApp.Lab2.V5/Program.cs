using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab2.V5.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #2 | Выполнил: Пеньков Е.Ю. | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #2                                                  *");
            Console.WriteLine("* Расчёты математических выражений в C#                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Пеньков Евгений Юрьевич | НТм-22-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая выполняет расчёты          *");
            Console.WriteLine("* математических выражений в С#.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 5;

            Console.WriteLine($"  x = {x}");

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_5_1(x);
            double result2 = ds.SolveExpressV_5_2(x);

            result1 = Math.Round(result1, 9);
            result2 = Math.Round(result2, 8);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"  1-е выражение: {result1}");
            Console.WriteLine($"  2-е выражение: {result2}");
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}
