using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1904/A
    internal class Forked_
    {
        public HashSet<(int x, int y)> GetAttackingPositions
            (int k_qX, int k_qY, int knightA, int knightB)
        {
            HashSet<(int x, int y)> attackingPositions = new();

            attackingPositions.Add((k_qX + knightA, k_qY + knightB));
            attackingPositions.Add((k_qX - knightA, k_qY - knightB));
            attackingPositions.Add((k_qX + knightA, k_qY - knightB));
            attackingPositions.Add((k_qX - knightA, k_qY + knightB));

            attackingPositions.Add((k_qX + knightB, k_qY + knightA));
            attackingPositions.Add((k_qX - knightB, k_qY - knightA));
            attackingPositions.Add((k_qX + knightB, k_qY - knightA));
            attackingPositions.Add((k_qX - knightB, k_qY + knightA));

            return attackingPositions;
        }
    }
}
