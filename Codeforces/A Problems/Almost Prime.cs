using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/26/A
    internal class Almost_Prime
    {
        public void UpdateMultiplesOfPrimeN(int[] primeDivisorCount, int primeN)
        {
            for (int i = primeN; i < primeDivisorCount.Length; i += primeN)
            {
                primeDivisorCount[i]++;
            }
        }
        public int CountAlmostPrimesToN(int n)
        {
            int[] primeDivisorCount = new int[n + 1];

            for (int i = 2; i <= n; i++)
            {
                if (primeDivisorCount[i] == 0) // I is Prime Number
                {
                    UpdateMultiplesOfPrimeN(primeDivisorCount, i);
                }
            }

            int almostPrimes = primeDivisorCount.Count(x => x == 2);

            return almostPrimes;
        }
    }
}
