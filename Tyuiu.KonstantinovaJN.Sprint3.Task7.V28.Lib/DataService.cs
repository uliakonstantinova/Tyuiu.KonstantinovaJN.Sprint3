using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double u = Math.Cos(2 * x);
                double l = u + (Math.Sin(x) / (x + 2.5));
                y = Math.Round((l + 2 * x), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
