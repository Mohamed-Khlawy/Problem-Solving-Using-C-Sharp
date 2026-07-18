using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2114/A
    internal class Square_Year
    {
        public (bool, string) CanWeSquareYear(int year)
        {
            int yearSqrt = (int)Math.Sqrt(year);

            if (Math.Pow(yearSqrt, 2) == year)
            {
                StringBuilder newRepresentation = new StringBuilder($"0 {yearSqrt}");
                return (true, newRepresentation.ToString());
            }

            return (false, string.Empty);
        }
    }
}
