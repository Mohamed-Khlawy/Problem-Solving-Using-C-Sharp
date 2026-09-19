using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2131/A
    internal class Lever
    {
        public int CalculateLeverIterations(int[] arrA, int[] arrB)
        {
            int iterations = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] > arrB[i])
                {
                    iterations += arrA[i] - arrB[i];
                }
            }

            return iterations + 1;
        }
    }
}
