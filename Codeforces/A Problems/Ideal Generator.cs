using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2093/A
    internal class Ideal_Generator
    {
        public bool IsIdealGenerator(int number)
        {
            // If the number is odd, it is an ideal generator
            return number % 2 != 0;
        }
    }
}
