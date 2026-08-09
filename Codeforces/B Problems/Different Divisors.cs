using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1474/B
    internal class Different_Divisors
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public int GetNextPrime(int number)
        {
            while (!IsPrime(number))
            {
                number++;
            }
            return number;
        }
        public int FindSmallestIntegerWithFourDivisors(int diffBetweenDivisors)
        {
            int primeDivisor1 = GetNextPrime(diffBetweenDivisors + 1);
            int primeDivisor2 = GetNextPrime(diffBetweenDivisors + primeDivisor1);

            int smallestInteger = primeDivisor1 * primeDivisor2;

            return smallestInteger;
        }
    }
}
