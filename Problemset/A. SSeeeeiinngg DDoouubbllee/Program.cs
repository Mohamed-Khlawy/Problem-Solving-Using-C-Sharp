namespace A._SSeeeeiinngg_DDoouubbllee
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1758/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> wordChars1 =
                    Console.ReadLine()!.Select(ch => char.Parse(ch.ToString())).ToList();

                List<char> wordChars2 = new List<char>(wordChars1);

                wordChars2.Reverse();

                //Console.Write("***************************** ");

                Console.WriteLine($"{string.Join("", wordChars1)}{string.Join("", wordChars2)}");
            }
        }
    }
}
