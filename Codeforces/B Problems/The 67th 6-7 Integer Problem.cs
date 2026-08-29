using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2218/B
    internal class The_67th_6_7_Integer_Problem
    {
        public int CalculateMaxSum(int[] arr)
        {
            int sumOfLowest6 = 0;
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= maxValue)
                {
                    sumOfLowest6 += maxValue;
                    maxValue = arr[i];
                }

                else
                {
                    sumOfLowest6 += arr[i];
                }
            }

            return (sumOfLowest6 * -1) + maxValue;
        }
    }
}
