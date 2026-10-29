using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using Tyuiu.GlebovLA.Sprint3.Task0.V7.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double wait = 0.333;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}