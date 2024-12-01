using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                for (int k = 1; k <= 20; k++)
                {
                    sumSeries += (Math.Pow(value, k) + 1) * Math.Cos(k);
                    startValue++;
                }
            } while (sumSeries <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
