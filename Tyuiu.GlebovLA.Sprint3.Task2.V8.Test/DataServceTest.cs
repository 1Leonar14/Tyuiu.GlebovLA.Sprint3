using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task2.V8.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;
            double wait = 0.001;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}