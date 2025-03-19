namespace A._Balanced_Substring
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1569/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int stringSize = int.Parse(Console.ReadLine()!);

                string word = Console.ReadLine()!;

                int substringStartIndex = -1;

                if (word.Contains("ab")) substringStartIndex = word.IndexOf("ab");

                else if (word.Contains("ba")) substringStartIndex = word.IndexOf("ba");

                //Console.Write("********************** ");

                Console.WriteLine(substringStartIndex != -1
                    ? $"{substringStartIndex + 1} {substringStartIndex + 2}"
                    : $"-1 -1");
            }
        }
    }
}
