namespace A._Game_with_Integers
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1899/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                if (number % 3 == 0)
                {
                    Console.WriteLine("Second");
                }

                else
                {
                    Console.WriteLine("First");
                }
            }
        }
    }
}
