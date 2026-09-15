using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/1180/A
    internal class Alex_and_a_Rhombus
    {
        public int CalculateNumberOfCellsInRhombus(int orderRhombus)
        {
            int totalCells = (orderRhombus * 2) - 1; /// Middle row of the Rhombus

            for (int i = 0; i < orderRhombus - 1; i++)
            {
                int rowCells = ((i * 2) + 1) * 2;
                totalCells += rowCells;
            }

            return totalCells;
        }
    }
}
