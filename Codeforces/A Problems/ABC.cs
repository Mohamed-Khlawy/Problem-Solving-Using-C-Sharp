using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1632/A
    internal class ABC
    {
        public bool CanWeRemoveAllPalindromes(string binaryStr)
        {
            return binaryStr.Length == 1 ||
                  (binaryStr.Length == 2 && binaryStr[0] != binaryStr[1]);
        }
    }
}
