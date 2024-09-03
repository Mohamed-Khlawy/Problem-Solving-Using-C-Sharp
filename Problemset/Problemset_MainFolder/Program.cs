using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
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
                int[] n_x = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_gas_stations = n_x[0];
                int final_point = n_x[1];

                List<int> gas_stations = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                
            }
        }
    }
}