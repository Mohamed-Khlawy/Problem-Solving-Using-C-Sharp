using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2091/A
    internal class Olympiad_Date
    {
        public int WhereToStopToCreateTheOlympiadDate(int[] digitsArr)
        {
            // The required Olympiad Date to form is => 01.03.2025
            int counterOf0s = 3;
            int counterOf1s = 1;
            int counterOf2s = 2;
            int counterOf3s = 1;
            int counterOf5s = 1;

            for (int i = 0; i < digitsArr.Length; i++)
            {
                if (digitsArr[i] == 0) counterOf0s--;
                else if (digitsArr[i] == 1) counterOf1s--;
                else if (digitsArr[i] == 2) counterOf2s--;
                else if (digitsArr[i] == 3) counterOf3s--;
                else if (digitsArr[i] == 5) counterOf5s--;

                if (counterOf0s <= 0 &&
                    counterOf1s <= 0 &&
                    counterOf2s <= 0 &&
                    counterOf3s <= 0 &&
                    counterOf5s <= 0)
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
