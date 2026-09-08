using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1696/B
    internal class NIT_Destroys_the_Universe
    {
        public int NumberOfOpsToMakeAllElementsZero(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            bool foundZeroBetweenNumbers = false;

            while (left < right)
            {
                if (arr[left] == 0) left++;

                if (arr[right] == 0) right--;

                if (arr[left] != 0 && arr[right] != 0) break;
            }

            if (left > right) return 0;

            if (left == right)
            {
                return arr[left] == 0 ? 0 : 1;
            }

            for (int i = left + 1; i < right; i++)
            {
                if (arr[i] == 0)
                {
                    foundZeroBetweenNumbers = true;
                    break;
                }
            }

            return foundZeroBetweenNumbers ? 2 : 1;
        }
    }
}
