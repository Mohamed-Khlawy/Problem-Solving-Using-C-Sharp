using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1978/A
    internal class Alice_and_Books
    {
        public int CalculateMaxNumberOfPages(int[] books)
        {
            int biggestBookBeforeLast = int.MinValue;

            for (int i = 0; i < books.Length - 1; i++)
            {
                if (books[i] > biggestBookBeforeLast)
                {
                    biggestBookBeforeLast = books[i];
                }
            }

            return biggestBookBeforeLast + books[^1];
        }
    }
}
