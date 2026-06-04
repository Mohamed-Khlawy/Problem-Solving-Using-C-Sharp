namespace A._Equal_Subsequences
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2118/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int stringSize = input[0];   // n
                int numberOfOnes = input[1]; // k

                List<int> onesList = Enumerable.Repeat(1, numberOfOnes).ToList();
                List<int> zerosList = Enumerable.Repeat(0, stringSize - numberOfOnes).ToList();

                zerosList.AddRange(onesList);

                //Console.Write("***************************** ");

                Console.WriteLine(string.Join("", zerosList));
            }
        }
    }
}
