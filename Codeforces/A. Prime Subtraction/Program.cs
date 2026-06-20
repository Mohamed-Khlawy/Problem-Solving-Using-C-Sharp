namespace A._Prime_Subtraction
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1238/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long number1 = input[0]; /// x
                long number2 = input[1]; /// y

                long diff = number1 - number2;

                //Console.Write("*********************** ");

                Console.WriteLine(diff > 1 ? "YES" : "NO");
            }
        }
    }
}
