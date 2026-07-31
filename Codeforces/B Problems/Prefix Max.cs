using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2185/B
    internal class Prefix_Max
    {
        public int FindMaximumPossibleValueInArray(int[] numbers)
        {
            int maxElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }

            return maxElement * numbers.Length;
        }
    }
}
