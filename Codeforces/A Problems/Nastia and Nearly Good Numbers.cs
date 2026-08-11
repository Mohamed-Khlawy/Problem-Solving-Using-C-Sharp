using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1521/A
    internal class Nastia_and_Nearly_Good_Numbers
    {
        public (bool canWemakeNastiaHappy, long[] requiredNumbers) CanWeMakeNastiaHappy(long a, long b)
        {
            if (b == 1)
            {
                return (false, new long[0]);
            }

            return (true, new long[] { a, a * b, a * (b + 1) });
        }
    }
}
