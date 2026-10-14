using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1831/B
    internal class Array_merging
    {
        private int[] FindLongestSubarrayForEachNumber(int[] arr)
        {
            int[] result = new int[2 * arr.Length + 1];

            int counter = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) counter++;

                else
                {
                    result[arr[i - 1]] = Math.Max(result[arr[i - 1]], counter);
                    counter = 1;
                }
            }

            result[arr[^1]] = Math.Max(result[arr[^1]], counter);

            return result;
        }
        public int FindLongestSubarrayAfterMerging(int[] arrA, int[] arrB)
        {
            int[] longestSubA = FindLongestSubarrayForEachNumber(arrA);
            int[] longestSubB = FindLongestSubarrayForEachNumber(arrB);

            int maxLength = 0;

            for (int i = 0; i < longestSubA.Length; i++)
            {
                maxLength = Math.Max(maxLength, longestSubA[i] + longestSubB[i]);
            }

            return maxLength;
        }
    }
}
