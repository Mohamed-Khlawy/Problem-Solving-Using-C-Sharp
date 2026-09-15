using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2121/A
    internal class Letter_Home
    {
        public int CalculateMinNumberOfSteps(int[] positions, int myPosition)
        {
            int minSteps = 0;

            for (int i = 0; i < positions.Length - 1; i++)
            {
                minSteps += Math.Abs(positions[i] - positions[i + 1]);
            }

            minSteps += Math.Min(Math.Abs(positions[0] - myPosition),
                                 Math.Abs(positions[^1] - myPosition));

            return minSteps;
        }
    }
}
