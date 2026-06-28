using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2167/A
    internal class Square
    {
        public static bool CanWeFormSquare(int[] sticks)
        {
            return sticks[0] == sticks[1] && 
                   sticks[1] == sticks[2] && 
                   sticks[2] == sticks[3];
        }
    }
}
