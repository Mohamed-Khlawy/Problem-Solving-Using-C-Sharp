using System.Diagnostics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_grains = input[0];
                int a = input[1];
                int b = input[2];
                int c = input[3];
                int d = input[4];

                int a_minus_b = a - b;
                int a_plus_b = a + b;

                int c_minus_d = c - d;
                int c_plus_d = c + d;

                int min_weight_of_all_grains = number_of_grains * a_minus_b;
                int max_weight_of_all_grains = number_of_grains * a_plus_b;

                //Console.Write("******************************************* ");

                //if ()
                //{

                //}

                //else
                //{
                //    Console.WriteLine("No");
                //}
            }
        }
    }
}