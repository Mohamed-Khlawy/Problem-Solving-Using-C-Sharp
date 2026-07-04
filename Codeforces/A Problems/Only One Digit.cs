using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2126/A
    internal class Only_One_Digit
    {
        public int FindSmallestNumberSharingADigitWith(int number)
        {
            int smallestNumber = int.MaxValue;

            while (number > 0)
            {
                int digit = number % 10;

                number /= 10;

                smallestNumber = Math.Min(smallestNumber, digit);
            }

            return smallestNumber;
        }

    }
}
