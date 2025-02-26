using System.Data.Common;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problemset_MainFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] dimensionsInput = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfRows = dimensionsInput[0];    /// n
                int numberOfColumns = dimensionsInput[1]; /// m

                int maxSumForBishop = 0;
                int maxSidesSum = 0;

                List<List<int>> chessBoard = new List<List<int>>();

                
            }
        } 
    }
}