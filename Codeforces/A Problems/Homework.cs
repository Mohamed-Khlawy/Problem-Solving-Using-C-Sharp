using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    // Problem Link => https://codeforces.com/problemset/problem/2132/A
    internal class Homework
    {
        public string DoTheHomework(string a, string b, string turns)
        {
            StringBuilder homework = new StringBuilder(a);

            for (int i = 0; i < turns.Length; i++)
            {
                if (turns[i] == 'D')
                {
                    homework.Append(b[i]);
                }

                else // turns[i] == 'V'
                {
                    homework.Insert(0, b[i]);
                }
            }

            return homework.ToString();
        }
    }
}
