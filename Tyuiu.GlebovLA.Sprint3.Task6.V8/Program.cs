using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint3.Task6.V8.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [18, 28] сумму всех делителей больше 11               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = 18;
            int stopValue = 28;

            Console.WriteLine($"Начало отрезка = {startValue}");
            Console.WriteLine($"Конец отрезка = {stopValue}");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine($"Сумма делителей = {res}");
            Console.ReadKey();
        }
    }
}