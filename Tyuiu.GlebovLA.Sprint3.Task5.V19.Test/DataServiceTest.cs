using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task5.V19.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 3;
            int stopValue2 = 6;
            double wait = 30598.002;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Assert.AreEqual(wait, res);
        }
    }
}