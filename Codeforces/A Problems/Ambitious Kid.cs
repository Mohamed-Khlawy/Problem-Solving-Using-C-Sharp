using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1866/A
    internal class Ambitious_Kid
    {
        public int FindMinAbsoluteNumber(int[] numbers)
        {
            int minAbsoluteNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                minAbsoluteNumber = Math.Min(minAbsoluteNumber, Math.Abs(numbers[i]));

                if (minAbsoluteNumber == 0) break;
            }

            return minAbsoluteNumber;
        }
    }
}
