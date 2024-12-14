namespace A._Turtle_and_Good_Strings
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2003/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string word = Console.ReadLine()!;

                //Console.Write("******************************************* ");

                if (word[0] == word[^1])
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
