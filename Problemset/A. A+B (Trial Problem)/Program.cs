namespace A._A_B__Trial_Problem_
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1351/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Array.ConvertAll
                    (Console.ReadLine()!.Split(' '), int.Parse);

                int firstNumber = input[0];
                int secondNumber = input[1];

                //Console.Write("***************************** ");

                Console.WriteLine(firstNumber + secondNumber);
            }
        }
    }
}
