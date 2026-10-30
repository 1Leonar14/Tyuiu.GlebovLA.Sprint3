using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint3.Task5.V19.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму ряда по формуле при X=2.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Начало внешнего цикла = {startValue1}");
            Console.WriteLine($"Конец внешнего цикла = {stopValue1}");
            Console.WriteLine($"Начало внутреннего цикла = {startValue2}");
            Console.WriteLine($"Конец внутреннего цикла = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Console.WriteLine($"Двойная сумма = {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}