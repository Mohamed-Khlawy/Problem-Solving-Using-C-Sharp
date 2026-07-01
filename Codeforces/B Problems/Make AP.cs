using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1624/B
    internal class Make_AP
    {
        public bool CanWeMakeAP(int a, int b, int c)
        {
            // The equation to form an arithmetic progression from 3 numbers a, b, c is: 2 * b = a + c
            int requiredA = 2 * b - c;
            int requiredB = (a + c) / 2;
            int requiredC = 2 * b - a;

            if (requiredA > 0 && requiredA % a == 0)
            {
                return true;
            }

            if ((a + c) % 2 == 0 && requiredB > 0 && requiredB % b == 0)
            {
                return true;
            }

            if (requiredC > 0 && requiredC % c == 0)
            {
                return true;
            }

            return false;
        }
    }
}
