namespace B._Construct_the_String
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/1335/B
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] n_a_b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int n = n_a_b[0];
                int a = n_a_b[1];
                int b = n_a_b[2];

                string requiredLetters = letters.Substring(0, b);
                string result = "";

                for (int i = 0; i < n; i++)
                {
                    result += requiredLetters[i % b];
                }

                Console.WriteLine(result);
            }
        }
    }
}