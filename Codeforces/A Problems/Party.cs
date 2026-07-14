using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/115/A
    internal class Party
    {
        public static int CalculateDepth(int employee, int[] managers, int[] depths)
        {
            if (depths[employee] != 0) return depths[employee];

            if (managers[employee] == -1)
            {
                depths[employee] = 1;
                return depths[employee];
            }

            depths[employee] = CalculateDepth(managers[employee] - 1, managers, depths) + 1;

            return depths[employee];
        }
        public static int CalculateMinGroupsOrMaxDepth(int[] managers)
        {
            int[] depths = new int[managers.Length];

            int maxDepth = 0;

            for (int empIndex = 0; empIndex < managers.Length; empIndex++)
            {
                int tempDepth = CalculateDepth(empIndex, managers, depths);
                maxDepth = Math.Max(maxDepth, tempDepth);
            }

            return maxDepth;
        }
    }
}
