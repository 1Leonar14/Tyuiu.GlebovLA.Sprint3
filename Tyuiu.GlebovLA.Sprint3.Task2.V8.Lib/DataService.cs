using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GlebovLA.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;
            do
            {
                p *= 1 / Math.Pow(Math.Cos(5) + 1, 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(p, 3);
        }
    }
}