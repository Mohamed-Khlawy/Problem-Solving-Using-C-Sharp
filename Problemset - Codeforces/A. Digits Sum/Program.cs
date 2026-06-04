namespace A._Digits_Sum
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1553/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                int last_digit = number % 10;

                //Console.Write("**************** ");

                if (last_digit == 9)
                {
                    Console.WriteLine((number / 10) + 1);
                }

                else
                {
                    Console.WriteLine(number / 10);
                }
            }
        }
    }
}
