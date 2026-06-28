using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/579/A
    internal class Raising_Bacteria
    {
        public int HowManyBacteriaV1(int requiredBacteria)
        {
            // V1 Using Shifting Bits Solution.
            int bacteriaCounter = 0;

            while (requiredBacteria > 0)
            {
                if ((requiredBacteria & 1) == 1) bacteriaCounter++;

                requiredBacteria >>= 1;
            }

            return bacteriaCounter;
        }

        public int HowManyBacteriaV2(int requiredBacteria)
        {
            // V2 using traditional loop with dividing by 2 solution.
            int bacteriaCounter = 0;

            while (requiredBacteria > 0)
            {
                if (requiredBacteria % 2 == 1) // Odd numbers increment the bacteriaCounter.
                {
                    requiredBacteria /= 2;
                    bacteriaCounter++;
                }

                else
                {
                    requiredBacteria /= 2;
                }
            }

            return bacteriaCounter;
        }
    }
}
