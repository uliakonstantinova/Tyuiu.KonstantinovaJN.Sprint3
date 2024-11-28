using Tyuiu.KonstantinovaJN.Sprint3.Task0.V5.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 81.08259534166108;

            Assert.AreEqual(wait, res);

        }
    }
}