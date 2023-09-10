using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab0.V0.Lib;

namespace Tyuiu.PenkovEU.ConsoleApp.Lab0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите значение переменной k:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной w:");
            int w = Convert.ToInt32(Console.ReadLine());

            DataService solve = new DataService();
            var resultAdd = solve.Add(k, w);
            var resultMinus = solve.Minus(k, w);
            var resultMultiplication = solve.Multiplication(k, w);
            var resultDivision = solve.Division(k, w);

            Console.WriteLine("Результат сложения k и w: " + resultAdd);
            Console.WriteLine("Результат вычитания k и w: " + resultMinus);
            Console.WriteLine("Результат умножения k и w: " + resultMultiplication);
            Console.WriteLine("Результат деления k и w: " + resultDivision);
            Console.ReadKey();
        }
    }
}
