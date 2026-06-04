namespace B._Generate_Permutation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2001/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutaionSize = int.Parse(Console.ReadLine()!);

                bool weCanDoIt = false;

                int[] permutationArray = new int[permutaionSize];

                if (permutaionSize % 2 != 0)
                {
                    weCanDoIt = true;

                    permutationArray[0] = permutaionSize;

                    for (int i = 1; i < permutaionSize; i++)
                    {
                        if (permutationArray[i - 1] == 1)
                        {
                            permutationArray[i] = 2;
                        }

                        else if (permutationArray[i - 1] % 2 != 0)
                        {
                            permutationArray[i] = permutationArray[i - 1] - 2;
                        }

                        else
                        {
                            permutationArray[i] = permutationArray[i - 1] + 2;
                        }
                    }
                }

                //Console.Write("**************************** ");

                Console.WriteLine(weCanDoIt
                    ? string.Join(" ", permutationArray)
                    : -1);
            }
        }
    }
}
