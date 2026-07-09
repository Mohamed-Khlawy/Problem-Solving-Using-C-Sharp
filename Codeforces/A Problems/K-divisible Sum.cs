using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1476/A
    internal class K_divisible_Sum
    {
        public static int FindMinimumMaximumElement(int arraySize, int divisor)
        {
            int extra = (divisor - (arraySize % divisor)) % divisor;

            int increasingAmountForAll = extra / arraySize;

            int remainingExtra = extra % arraySize;

            // Last +1 is the initial value of the array elements.
            int minMaxElement = increasingAmountForAll + (remainingExtra > 0 ? 1 : 0) + 1;

            return minMaxElement;
        }
    }
}
