namespace A._Mahmoud_and_Longest_Uncommon_Subsequence
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/766/A
        static void Main(string[] args)
        {
            List<char> str1 = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();
            List<char> str2 = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

            if (str1.Count != str2.Count)
            {
                Console.WriteLine(Math.Max(str1.Count, str2.Count));
            }

            else if (str1.Count == str2.Count && str1.SequenceEqual(str2))
            {
                Console.WriteLine(-1);
            }

            else
            {
                Console.WriteLine(str1.Count); // Or str2.Count because they have same length.
            }
        }
    }
}
