using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2193/A
    internal class DBMB_and_the_Array
    {
        public static bool CanWeAppealDBMB(int[] giftsArr, int requiredSum, int addingAmount)
        {
            int giftsSum = giftsArr.Sum();

            int difference = requiredSum - giftsSum;

            if (difference == 0) return true;

            else if (difference > 0 && difference % addingAmount == 0) return true;

            return false;
        }
    }
}
