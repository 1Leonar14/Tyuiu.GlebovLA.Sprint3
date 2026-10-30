using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task1.V18.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double wait = 0.121;
            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}