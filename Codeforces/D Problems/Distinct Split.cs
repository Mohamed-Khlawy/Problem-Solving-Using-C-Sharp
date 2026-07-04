using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1791/D
    internal class Distinct_Split
    {
        public int CalculateMaximumDistinctCharactersAfterSplitting(string str)
        {
            int[] frequency = new int[26];

            int[] prefixDistinct = new int[str.Length];

            int[] suffixDistinct = new int[str.Length];

            int distinctCounter = 0;

            int maxDistinctChars = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (frequency[str[i] - 'a'] == 0)
                {
                    distinctCounter++;
                }

                frequency[str[i] - 'a']++;
                prefixDistinct[i] = distinctCounter;
            }

            Array.Clear(frequency, 0, frequency.Length);
            distinctCounter = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (frequency[str[i] - 'a'] == 0)
                {
                    distinctCounter++;
                }

                frequency[str[i] - 'a']++;
                suffixDistinct[i] = distinctCounter;
            }

            for (int i = 0; i < str.Length - 1; i++)
            {
                int leftDistinct = prefixDistinct[i];
                int rightDistinct = suffixDistinct[i + 1];

                maxDistinctChars = Math.Max(maxDistinctChars, leftDistinct + rightDistinct);
            }

            return maxDistinctChars;
        }

    }
}
