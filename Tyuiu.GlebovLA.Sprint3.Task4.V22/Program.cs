using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint3.Task4.V22.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операторы continue и break                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(sin(x) - x). При х = 0 пропустить значение.                *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начальное значение x = {startValue}");
            Console.WriteLine($"Конечное значение x = {stopValue}");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine($"Произведение значений = {res}");
            Console.ReadKey();
        }
    }
}