namespace A._Three_Indices
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1380/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                List<int> permutation = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool weFouondThem = false;

                int lessFromLeft = 0;
                int middleIndex = 0;
                int lessFromRight = 0;

                for (int i = 1; i < permutationSize - 1; i++)
                {
                    int toLeft = i - 1;
                    int toRight = i + 1;

                    lessFromLeft = -1;
                    lessFromRight = -1;

                    while (toLeft >= 0 && toRight < permutationSize)
                    {
                        if (permutation[i] > permutation[toLeft]) lessFromLeft = toLeft + 1;

                        if (permutation[i] > permutation[toRight]) lessFromRight = toRight + 1;


                        if (lessFromLeft != -1 && lessFromRight != -1)
                        {
                            middleIndex = i + 1;
                            weFouondThem = true;
                            break;
                        }

                        else
                        {
                            if (lessFromLeft == -1) toLeft--;

                            if (lessFromRight == -1) toRight++;
                        }
                    }

                    if (weFouondThem) break;
                }

                //Console.WriteLine("****************** ");

                if (weFouondThem)
                {
                    Console.WriteLine("YES");

                    Console.WriteLine($"{lessFromLeft} {middleIndex} {lessFromRight}");
                }

                else
                {
                    Console.WriteLine("NO");
                }

                //Console.WriteLine("****************** ");
            }
        }
    }
}
