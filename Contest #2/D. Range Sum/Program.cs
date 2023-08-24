using System.Numerics;

namespace D._Range_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while(tests-- > 0)
            {
                string l_r = Console.ReadLine()!;
                string[] l_rArray = l_r.Split(' ');

                int left = Math.Min(int.Parse(l_rArray[0]), int.Parse(l_rArray[1]));
                int right = Math.Max(int.Parse(l_rArray[0]), int.Parse(l_rArray[1]));
                long numbersInRamge = right - left + 1;

                long sum = (numbersInRamge * (left + right)) / 2;

                Console.WriteLine(sum);
            }
        }
    }
}