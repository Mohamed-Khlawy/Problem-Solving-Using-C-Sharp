using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2072/A
    internal class New_World_New_Me_New_Array
    {
        public int minOpsToMakeSumEqualToK(int arraLength, int k, int opValue)
        {
            int minOps = (Math.Abs(k) + opValue - 1) / opValue; // Instead of Math.Ceiling function.

            return minOps <= arraLength
                ? minOps
                : -1;
        }
    }
}
