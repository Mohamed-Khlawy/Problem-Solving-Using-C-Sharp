namespace A._Game_with_Board
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1841/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfIntegers = int.Parse(Console.ReadLine()!);

                //Console.Write("**************** ");

                Console.WriteLine((numberOfIntegers == 2 || numberOfIntegers == 3 || numberOfIntegers == 4)
                    ? "Bob"
                    : "Alice");
            }
        }
    }
}
