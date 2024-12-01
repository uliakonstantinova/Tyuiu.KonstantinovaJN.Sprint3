using NuGet.Frameworks;
using Tyuiu.KonstantinovaJN.Sprint3.Task2.V5.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 20.802;

            Assert.AreEqual(wait, res);
        }
    }
}