using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1726/A
    internal class Mainak_and_Array
    {
        public int CalculateMaxDiffBetweenLastAndFirst(int[] arr)
        {
            int minAfterFirst = int.MaxValue;
            int maxBeforeLast = int.MinValue;
            int maxDiff = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    maxDiff = Math.Max(maxDiff, arr[i] - arr[i + 1]);
                }

                if (i == 0)
                {
                    maxBeforeLast = Math.Max(maxBeforeLast, arr[i]);
                }

                if (i == arr.Length - 1)
                {
                    maxDiff = Math.Max(maxDiff, arr[i] - arr[0]);
                    minAfterFirst = Math.Min(minAfterFirst, arr[i]);
                }

                else
                {
                    minAfterFirst = Math.Min(minAfterFirst, arr[i]);
                    maxBeforeLast = Math.Max(maxBeforeLast, arr[i]);
                }
            }

            int candidate1 = arr[arr.Length - 1] - minAfterFirst;
            int candidate2 = maxBeforeLast - arr[0];
            int candidate3 = arr[arr.Length - 1] - arr[0];

            maxDiff = Math.Max(maxDiff, Math.Max(candidate1, Math.Max(candidate2, candidate3)));

            return maxDiff;
        }
    }
}
