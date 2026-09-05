using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2184/A
    internal class Social_Experiment
    {
        public int FindMinPossibleDifference(int number)
        {
            if (number == 2) return 2;

            if (number == 3) return 3;

            if (number % 2 == 0) return 0;

            return 1;
        }
    }
}
