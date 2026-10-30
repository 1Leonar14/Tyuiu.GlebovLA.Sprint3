using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GlebovLA.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] res = new double[count];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x - 0.4;

                if (denominator == 0)
                {
                    res[index] = 0;
                }
                else
                {
                    double value = (Math.Cos(x) / denominator) + Math.Sin(x) * 8 * x + 2;
                    res[index] = Math.Round(value, 2);
                }

                index++;
            }

            return res;
        }
    }
}