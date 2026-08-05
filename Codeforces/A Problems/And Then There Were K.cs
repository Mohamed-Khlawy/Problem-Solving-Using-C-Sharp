using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1527/A
    internal class And_Then_There_Were_K
    {
        public int FindMaxValueToReachZeroWithAND(int n)
        {
            if (n == 1) return 0;

            int power = 0;
            int highestPowerOfTwo = 0;

            while (highestPowerOfTwo <= n)
            {
                power++;
                highestPowerOfTwo = (int)Math.Pow(2, power);
            }

            return (int)Math.Pow(2, power - 1) - 1;
        }
    }
}
