using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint3.Task0.V7.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по  *");
            Console.WriteLine("* формуле.                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите начальное значение k (startValue): ");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечное значение k (stopValue): ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();
            double res = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine($"Сумма ряда = {res}");
            Console.ReadKey();
        }
    }
}