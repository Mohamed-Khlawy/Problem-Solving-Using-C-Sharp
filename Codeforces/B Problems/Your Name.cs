using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2167/B
    internal class Your_Name
    {
        public bool AreTheyHaveSameChars(string str1, string str2)
        {
            int[] charsFrequency = new int[26];

            foreach (char ch in str1)
            {
                charsFrequency[ch - 'a']++;
            }

            foreach (char ch in str2)
            {
                if (charsFrequency[ch - 'a'] == 0) return false;

                charsFrequency[ch - 'a']--;
            }

            return true;
        }
    }
}
