using Tyuiu.KonstantinovaJN.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task1.V3.Test
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

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 24589.408;

            Assert.AreEqual(wait, res);
        }
    }
}