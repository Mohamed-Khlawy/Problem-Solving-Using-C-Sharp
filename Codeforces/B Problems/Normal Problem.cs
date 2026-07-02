using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2044/B
    internal class Normal_Problem
    {
        public string StringWithTwoFaces(string word)
        {
            char[] wordChars = word.ToCharArray();

            //Array.Reverse(wordChars);

            // Instead of the built in Reverse function we can make the reverse manually.
            int left = 0;
            int right = wordChars.Length - 1;

            while (left <= right)
            {
                if (wordChars[left] == 'p') wordChars[left] = 'q';

                else if (wordChars[left] == 'q') wordChars[left] = 'p';

                if (left != right)
                {
                    if (wordChars[right] == 'p') wordChars[right] = 'q';

                    else if (wordChars[right] == 'q') wordChars[right] = 'p';
                }

                (wordChars[left], wordChars[right]) = (wordChars[right], wordChars[left]);

                left++;
                right--;
            }

            return new string(wordChars);
        }
    }
}
