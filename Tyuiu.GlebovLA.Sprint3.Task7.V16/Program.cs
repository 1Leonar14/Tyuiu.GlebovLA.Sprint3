using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint3.Task7.V16.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Работа с массивами                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* f(x) = cos(x)/(x-0.4) + sin(x)*8x + 2 на диапазоне [-5, 5] с шагом 1.   *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("  X  |   F(X)   ");
            Console.WriteLine("-----------------");

            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(startValue, stopValue);

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($" {x,2} | {res[index],8:F2} ");
                index++;
            }
            Console.ReadKey();
        }
    }
}