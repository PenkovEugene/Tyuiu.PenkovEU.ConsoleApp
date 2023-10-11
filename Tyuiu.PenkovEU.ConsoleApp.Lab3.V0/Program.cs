using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PenkovEU.ConsoleApp.Lab3.V0.Lib;


namespace Tyuiu.PenkovEU.ConsoleApp.Lab3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool result; int x; int y;
            Console.WriteLine($"Введите значение X : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите значение Y : ");
            y = Convert.ToInt32(Console.ReadLine());

            result = ds.GetPointShape(x,y);

            if ( result )
            {
                Console.WriteLine("Точка находится в фигуре");
            }

            else { Console.WriteLine("Вы не попали в фигуру"); }

            Console.ReadKey();
        }
    }
}
