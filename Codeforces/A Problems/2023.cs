using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1916/A
    internal class _2023
    {
        public (bool, string) CanWeGet2023(long[] numbers, int numberOfRemoved)
        {
            long product = 1;

            foreach (long number in numbers)
            {
                product *= number;
            }

            if (2023 % product == 0)
            {
                List<int> removedNumbers = Enumerable.Repeat(1, numberOfRemoved - 1).ToList();
                removedNumbers.Insert(0, 2023 / (int)product);
                return (true, string.Join(" ", removedNumbers));
            }
            else
            {
                return (false, string.Empty);
            }
        }

    }
}
