using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task7.V16.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, res.Length);
            Assert.AreEqual(-0.5, res[5]);
        }
    }
}