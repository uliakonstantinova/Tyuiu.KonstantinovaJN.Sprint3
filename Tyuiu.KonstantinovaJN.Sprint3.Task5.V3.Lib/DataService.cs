using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int j, k;
            for (j = startValue1; j <= stopValue1; j++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sum += (Math.Sin(k) + x) / x;
                }
            }
            return Math.Round(sum, 3);
        }
    }
}
