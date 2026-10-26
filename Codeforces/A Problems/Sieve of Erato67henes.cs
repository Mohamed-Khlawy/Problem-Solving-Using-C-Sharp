using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2195/A
    internal class Sieve_of_Erato67henes
    {
        public bool CanWeGet67(int[] arr)
        {
            Array.Sort(arr);
            return arr[^1] == 67;
        }
    }
}
