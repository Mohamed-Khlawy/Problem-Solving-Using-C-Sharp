using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2227/A
    internal class Koshary
    {
        public bool CanYousefReachToKoshary(int[] kosharyCoordinates)
        {
            return kosharyCoordinates[0] % 2 == 1 && kosharyCoordinates[1] % 2 == 1;
        }
    }
}
