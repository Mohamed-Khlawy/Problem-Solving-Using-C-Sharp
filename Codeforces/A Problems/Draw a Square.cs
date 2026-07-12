using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2074/A
    internal class Draw_a_Square
    {
        public static bool CanWeDrawASquare(int left, int right, int down, int up)
        {
            return left == right &&
                   right == up &&
                   up == down;
        }
    }
}
