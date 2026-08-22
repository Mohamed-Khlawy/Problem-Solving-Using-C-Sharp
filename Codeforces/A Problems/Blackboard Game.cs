using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2123/A
    internal class Blackboard_Game
    {
        public string WhoIsTheWinner(int number)
        {
            return number % 4 == 0 ? "Bob" : "Alice";
        }
    }
}
