using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2065/A
    internal class Skibidus_and_Amog_u
    {
        public string ConvertSingularToPlural(string singular)
        {
            string plural = singular[..^2] + 'i';

            //plural = singular.Substring(0, singular.Length - 2) + 'i';

            return plural;
        }
    }
}
