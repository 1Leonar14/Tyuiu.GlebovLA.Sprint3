using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint3.Task6.V8.Lib;

namespace Tyuiu.GlebovLA.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 28;

            int wait = 292;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}