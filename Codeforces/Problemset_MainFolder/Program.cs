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
                int[] kosharyCoordinates = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                //Console.Write("********************** ");

                Console.WriteLine(kosharyCoordinates[0] % 2 == 1 && kosharyCoordinates[1] % 2 == 1
                    ? "NO"
                    : "YES");
            }
        }
    }
}