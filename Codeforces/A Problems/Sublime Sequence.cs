using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problems
{
    internal class Sublime_Sequence
    {
        public int CalculateSequenceSum(int number, int sequenceLength)
        {
            return (sequenceLength % 2 == 0) ? 0 : number;
        }
    }
}
