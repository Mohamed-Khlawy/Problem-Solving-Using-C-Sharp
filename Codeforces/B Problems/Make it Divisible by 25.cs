using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1593/B
    internal class Make_it_Divisible_by_25
    {
        public static int FindNumberOfRemovals(string number, int searchingIndex)
        {
            switch (number[searchingIndex])
            {
                case '0':
                    for (int i = searchingIndex - 1; i >= 0; i--)
                    {
                        if (number[i] == '0' || number[i] == '5')
                        {
                            return
                                number.Length - searchingIndex - 1 + (searchingIndex - i - 1);
                        }
                    }
                    break;

                case '5':
                    for (int i = searchingIndex - 1; i >= 0; i--)
                    {
                        if (number[i] == '2' || number[i] == '7')
                        {
                            return
                                number.Length - searchingIndex - 1 + (searchingIndex - i - 1);
                        }
                    }
                    break;
            }

            return -1;
        }
        public static int MakeItDivisibleBy25(string number)
        {
            int minRemovals = int.MaxValue;

            bool processedZero = false;
            bool processedFive = false;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] == '0' && !processedZero)
                {
                    processedZero = true;
                }

                else if (number[i] == '5' && !processedFive)
                {
                    processedFive = true;
                }

                else continue;

                int removals = FindNumberOfRemovals(number, i);

                if (removals != -1)
                {
                    minRemovals = Math.Min(minRemovals, removals);
                }

                if (processedZero && processedFive) break;
            }

            return minRemovals;
        }
    }
}
