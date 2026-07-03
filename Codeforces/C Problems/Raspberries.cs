using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1883/C
    internal class Raspberries
    {
        public int HelperFunction(int[] numbers, int divisor)
        {
            int minOps = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number % divisor == 0) return 0;

                else
                {
                    int currentOps = divisor - (number % divisor);
                    minOps = Math.Min(minOps, currentOps);
                }
            }

            return minOps;
        }
        public int CalculateMinimumOperations(int[] numbers, int divisor)
        {
            switch (divisor)
            {
                case 2:
                    int evenCounter2 = 0;
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0) evenCounter2++;
                    }
                    return evenCounter2 > 0 ? 0 : 1;

                case 3:
                    int minOps3 = HelperFunction(numbers, 3);
                    return minOps3;

                case 4:
                    int evenCounter4 = 0;
                    foreach (int number in numbers)
                    {
                        if (number % 4 == 0) return 0;

                        else if (number % 2 == 0) evenCounter4++;
                    }

                    if (evenCounter4 >= 2) return 0;

                    else if (evenCounter4 == 1) return 1;

                    else
                    {
                        int minOps4 = HelperFunction(numbers, 4);
                        return minOps4 < 2 ? minOps4 : 2;
                    }

                case 5:
                    int minOps5 = HelperFunction(numbers, 5);
                    return minOps5;
            }
            return -1;
        }
    }
}
