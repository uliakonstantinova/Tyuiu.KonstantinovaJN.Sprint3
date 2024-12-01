using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            
            while (startValue <= stopValue)
            {
                double u = Math.Cos(5);
                double l = Math.Pow((u + 1), 2);
                for (int k = 1; k <= 10; k++)
                {
                    multSeries = multSeries * (k / l);
                    startValue++;
                }
            }
            return Math.Round(multSeries, 3);
        }
    }
}
