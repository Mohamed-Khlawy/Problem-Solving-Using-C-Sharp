using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2149/A
    internal class Be_Positive
    {
        public int MinOpsToBePositive(int[] arr)
        {
            int minOps = 0;
            int zeroCounter = 0;
            bool hasNegative = false;

            foreach (int number in arr)
            {
                if (number == 0) zeroCounter++;

                if (number < 0) hasNegative = !hasNegative;
            }

            if (zeroCounter > 0)
            {
                minOps += zeroCounter;
                if (hasNegative) minOps += 2;
            }
            else
            {
                if (hasNegative) minOps += 2;
            }

            return minOps;
        }
    }
}
