namespace A._Subtraction_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1844/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] removingAmounts = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int firstAmount = removingAmounts[0];  // a
                int secondAmount = removingAmounts[1]; // b

                //Console.Write("**************************** ");

                Console.WriteLine(firstAmount + secondAmount);
            }
        }
    }
}
