namespace B._Good_Kid
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1873/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbersArray);

                numbersArray[0]++;

                long summation = 1;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    summation *= numbersArray[i];
                }

                Console.WriteLine(summation);
            }
        }
    }
}