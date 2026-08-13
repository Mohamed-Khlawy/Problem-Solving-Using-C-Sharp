using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1716/A
    internal class _2_3_Moves
    {
        public int CalculateMoves(int number)
        {
            if (number == 1)
            {
                return 2;
            }
            
            return (number + 2) / 3; // This is equivalent to Math.Ceiling(number / 3.0)
        }
    }
}
