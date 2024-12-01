using Tyuiu.KonstantinovaJN.Sprint3.Task4.V3.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1.067;
            Assert.AreEqual(wait, res);
        }
    }
}