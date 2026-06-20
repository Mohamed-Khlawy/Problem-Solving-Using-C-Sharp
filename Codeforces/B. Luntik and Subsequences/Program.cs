namespace B._Luntik_and_Subsequences
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1582/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfZeros = numbers.Count(digit => digit == 0);
                int numberOfOnes = numbers.Count(digit => digit == 1);

                long nearlyFullSubs = ((long)Math.Pow(2, numberOfZeros)) * numberOfOnes;

                //Console.Write("*********************************** ");

                Console.WriteLine(nearlyFullSubs);
            }
        }
    }
}
