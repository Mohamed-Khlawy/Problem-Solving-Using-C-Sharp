namespace A._XORwice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1421/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int first_number = input[0];
                int second_number = input[1];

                //Console.Write("************************************** ");

                Console.WriteLine(first_number ^ second_number);
            }
        }
    }
}
