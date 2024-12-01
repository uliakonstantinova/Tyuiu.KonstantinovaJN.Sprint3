using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;
            do
            {
                double u = Math.Pow(value, k) + 1;
                double l = u * Math.Cos(k);
                sumSeries += l;
                k++;
            } while (k <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
