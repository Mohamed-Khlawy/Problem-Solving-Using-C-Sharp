using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2094/A
    internal class Trippi_Troppi
    {
        public string ExtractModernCountryName(string[] ancientCountryName)
        {
            char[] modernCountryName = new char[3];

            for (int i = 0; i < ancientCountryName.Length; i++)
            {
                modernCountryName[i] = ancientCountryName[i][0];
            }

            return string.Join("", modernCountryName);
        }
    }
}
