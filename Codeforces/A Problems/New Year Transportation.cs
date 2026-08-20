using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/500/A
    internal class New_Year_Transportation
    {
        public bool CanWeReachCell(int targetCell, int[] cellsArr)
        {
            int currentCell = 0;

            while (currentCell < targetCell - 1)
            {
                currentCell += cellsArr[currentCell];
            }

            return currentCell == (targetCell - 1);
        }
    }
}
