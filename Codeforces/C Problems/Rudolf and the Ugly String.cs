using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1941/C
    internal class Rudolf_and_the_Ugly_String
    {
        public int CalculateMinNumberOfCharsToRemove(string word)
        {
            int mapCounter = 0;
            int pieCounter = 0;
            int mapieCounter = 0;
            bool mapieFound = false;

            for (int i = 0; i < word.Length - 2; i++)
            {
                if (word[i] == 'm' && word[i + 1] == 'a' && word[i + 2] == 'p')
                {
                    mapCounter++;

                    if (i < word.Length - 4 &&
                        word[i + 3] == 'i' && word[i + 4] == 'e')
                    {
                        mapieCounter++;
                        mapieFound = true;
                    }

                    if (mapieFound)
                    {
                        i += 1; // To stop on the P and count the "pie" substring.
                        mapieFound = false;
                    }

                    else i += 2;
                }

                else if (word[i] == 'p' && word[i + 1] == 'i' && word[i + 2] == 'e')
                {
                    pieCounter++;

                    i += 2;
                }
            }

            return mapCounter + pieCounter - mapieCounter;
        }
    }
}
