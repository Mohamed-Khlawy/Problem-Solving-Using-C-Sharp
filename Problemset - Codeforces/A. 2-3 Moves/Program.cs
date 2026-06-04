namespace A._2_3_Moves
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1716/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                double number = double.Parse(Console.ReadLine()!);

                if (number == 1)
                {
                    Console.WriteLine(2);
                }

                else
                {
                    Console.WriteLine(Math.Ceiling(number / 3));
                }
            }
        }
    }
}
