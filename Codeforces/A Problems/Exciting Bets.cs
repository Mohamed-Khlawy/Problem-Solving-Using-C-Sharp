using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1543/A
    internal class Exciting_Bets
    {
        public (long maxGCD, long minMoves) ExcitingFans(long ronnie, long me)
        {
            long maxGCD = Math.Abs(ronnie - me);

            if (maxGCD == 0) return (0, 0);

            long previousMultipleMoves = ronnie % maxGCD;

            long nextMultipleMoves = maxGCD - previousMultipleMoves;

            long minMoves = Math.Min(previousMultipleMoves, nextMultipleMoves);

            return (maxGCD, minMoves);
        }
    }
}
