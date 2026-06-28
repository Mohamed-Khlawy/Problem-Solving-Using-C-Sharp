using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1883/B
    internal class Chemistry
    {
        public bool PalindromePossibility(string word, int deletedChars)
        {
            int[] charsFrequency = new int[26];

            int remainingLength = word.Length - deletedChars;

            int oddCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                charsFrequency[word[i] - 'a']++;
            }

            foreach (int freq in charsFrequency)
            {
                if (freq % 2 == 1) oddCount++;
            }

            if (deletedChars >= oddCount) return true;

            oddCount -= deletedChars;

            return (remainingLength % 2 == 0 && oddCount == 0) || 
                   (remainingLength % 2 == 1 && oddCount == 1);
        }
    }
}
