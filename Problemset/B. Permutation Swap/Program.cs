namespace B._Permutation_Swap
{
    internal class Program
    {
        // Proble Link : https://codeforces.com/problemset/problem/1828/B
        public static int CalculateGCD(int a, int b)
        {
            while (b > 0)
            {
                (a, b) = (b, a % b);
            }

            return a;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutaionSize = int.Parse(Console.ReadLine()!);

                int[] permutaion = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int maxKValue = 0;

                for (int i = 0; i < permutaion.Length; i++)
                {
                    int tempValue = Math.Abs(permutaion[i] - (i + 1));

                    maxKValue = CalculateGCD(maxKValue, tempValue);
                }

                //Console.Write("************************ ");

                Console.WriteLine(maxKValue);
            }
        }
    }
}
