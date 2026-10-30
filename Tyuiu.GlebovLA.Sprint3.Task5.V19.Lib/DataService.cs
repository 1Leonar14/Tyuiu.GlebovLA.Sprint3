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
            int x_fixed = 2;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Pow(x_fixed / Math.Cos(x_fixed), k);
                }
            }

            return Math.Round(sum, 3);
        }
    }
}