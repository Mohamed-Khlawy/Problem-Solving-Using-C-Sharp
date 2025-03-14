namespace B._Funny_Permutation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1741/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutaionSize = int.Parse(Console.ReadLine()!);

                if (permutaionSize == 3)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                int[] funnyPermutaion = Enumerable.Range(1, permutaionSize).ToArray();

                Array.Reverse(funnyPermutaion);

                int halfIndex = permutaionSize / 2;

                if (permutaionSize % 2 == 1 && permutaionSize != 5)
                {
                    (funnyPermutaion[halfIndex], funnyPermutaion[halfIndex + 1]) =
                        (funnyPermutaion[halfIndex + 1], funnyPermutaion[halfIndex]);
                }

                else if (permutaionSize == 5)
                {
                    (funnyPermutaion[0], funnyPermutaion[halfIndex]) =
                        (funnyPermutaion[halfIndex], funnyPermutaion[0]);
                }

                //Console.Write("************************** ");

                Console.WriteLine(string.Join(" ", funnyPermutaion));
            }
        }
    }
}
