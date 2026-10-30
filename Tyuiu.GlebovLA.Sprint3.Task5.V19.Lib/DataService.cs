using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GlebovLA.Sprint3.Task5.V19.Lib
{
    public class DataService : ISprint3Task5V19
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 6; k++)
                {
                    sum += Math.Pow(x / Math.Cos(x), k);
                }
            }

            return Math.Round(sum, 3);
        }
    }
}