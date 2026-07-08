using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2044/C
    internal class Hard_Problem
    {
        public static void CountSatMonkeysHelper
            (ref long maxSatMonkeys, ref long availableSeats, int rowSeats, int prefType)
        {
            if (rowSeats >= prefType)
            {
                maxSatMonkeys += prefType;
                availableSeats += rowSeats - prefType;
            }

            else
            {
                maxSatMonkeys += rowSeats;
            }
        }
        public static long FindMaxNumberOfMonkeysCanSit
            (int rowSeats, int row1Pref, int row2Pref, int noPref)
        {
            long maxSatMonkeys = 0;

            long availableSeats = 0;

            CountSatMonkeysHelper(ref maxSatMonkeys, ref availableSeats, rowSeats, row1Pref);
            CountSatMonkeysHelper(ref maxSatMonkeys, ref availableSeats, rowSeats, row2Pref);

            maxSatMonkeys += Math.Min(availableSeats, noPref);

            return maxSatMonkeys;
        }
    }
}
