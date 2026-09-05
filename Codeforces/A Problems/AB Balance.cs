using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1606/A
    internal class AB_Balance
    {
        public string BalanceABandBA(char[] wordChars)
        {
            if (wordChars[0] != wordChars[^1])
            {
                wordChars[0] = wordChars[^1];
            }

            return string.Join("", wordChars);
        }
    }
}
