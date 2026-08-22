using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2030/A
    internal class A_Gift_From_Orangutan
    {
        public int CalculateMaxScore(int[] numbers)
        {
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number > maxElement)
                {
                    maxElement = number;
                }

                if (number < minElement)
                {
                    minElement = number;
                }
            }

            return (maxElement - minElement) * (numbers.Length - 1);
        }
    }
}
