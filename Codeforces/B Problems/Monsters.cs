using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1849/B
    internal class Monsters
    {
        public static int[] OrderDeadMonsters(int[] monstersInitialHealths, int MonoDamage)
        {
            List<(int Value, int Index)> monstersLastHealths = new();

            for (int i = 0; i < monstersInitialHealths.Length; i++)
            {
                int lastHealth = monstersInitialHealths[i] % MonoDamage == 0
                    ? MonoDamage
                    : monstersInitialHealths[i] % MonoDamage;

                monstersLastHealths.Add((lastHealth, i));
            }

            monstersLastHealths.Sort((a, b) =>
            {
                if (a.Value != b.Value) // Descending Order By Last Health
                {
                    return b.Value.CompareTo(a.Value);
                }

                return a.Index.CompareTo(b.Index); // Ascending Order By Index
            });

            // +1 to convert from 0-based index to 1-based index
            return monstersLastHealths.Select(mon => mon.Index + 1).ToArray();
        }

    }
}
