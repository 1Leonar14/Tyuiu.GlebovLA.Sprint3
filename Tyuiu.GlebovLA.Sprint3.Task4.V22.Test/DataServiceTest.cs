using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task4.V22.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double wait = 73.346;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}