﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonstantinovaJN.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;

            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sum += d;
                    }

                }
            }
            return sum;
        }
    }
}
