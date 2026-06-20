namespace B._Count_the_Number_of_Pairs
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1800/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int wordSize = input[0];      /// n
                int maxOperations = input[1]; /// k

                char[] wordChars = Console.ReadLine()!.ToCharArray();

                int[,] charsFrequency = new int[26, 2];

                int maxBurles = 0;
                int availableOperations = 0;

                for (int i = 0; i < wordSize; i++)
                {
                    if (char.IsLower(wordChars[i])) /// Column Zero for Lowercase Char
                    {
                        int charIndex = wordChars[i] - 97;
                        charsFrequency[charIndex, 0]++;
                    }

                    else /// Column One for Uppercase Char
                    {
                        int charIndex = wordChars[i] - 65;
                        charsFrequency[charIndex, 1]++;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    maxBurles += Math.Min(charsFrequency[i, 0], charsFrequency[i, 1]);

                    availableOperations +=
                        Math.Abs(charsFrequency[i, 0] - charsFrequency[i, 1]) / 2;
                }

                maxBurles += Math.Min(maxOperations, availableOperations);

                //Console.Write("**************************** ");

                Console.WriteLine(maxBurles);
            }
        }
    }
}
