using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2065/B
    internal class Skibidus_and_Ohio
    {
        public int FindMinimumLength(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    return 1;
                }
            }

            return word.Length;
        }
    }
}
