namespace A._AB_Balance
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1606/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] word = Console.ReadLine()!.ToCharArray();

                if (word[0] != word[^1])
                {
                    word[0] = word[^1];
                }

                //Console.Write("********************* ");

                Console.WriteLine(string.Join("", word));
            }
        }
    }
}
