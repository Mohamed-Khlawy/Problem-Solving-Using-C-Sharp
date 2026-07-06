using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1840/C
    internal class Ski_Resort
    {
        public static long CountWaysForSkiResortInVacation
            (int[] resortWeather, int minSkiingDays, int maxTemperature)
        {
            long numberOfWays = 0;

            int tempBlockLength = 0;

            for (int i = 0; i < resortWeather.Length; i++)
            {
                if (resortWeather[i] <= maxTemperature)
                {
                    tempBlockLength++;
                }
                else
                {
                    if (tempBlockLength >= minSkiingDays)
                    {
                        long tempStarters = tempBlockLength - minSkiingDays + 1;
                        numberOfWays += tempStarters * (tempStarters + 1) / 2;
                    }
                    tempBlockLength = 0;
                }
            }

            if (tempBlockLength >= minSkiingDays)
            {
                long tempStarters = tempBlockLength - minSkiingDays + 1;
                numberOfWays += tempStarters * (tempStarters + 1) / 2;
            }

            return numberOfWays;
        }
    }
}
