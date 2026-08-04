using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2162/A
    internal class Beautiful_Average
    {
        public int FindMaximumAverage(int[] arr)
        {
            int maxElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            return maxElement;
        }
    }
}
