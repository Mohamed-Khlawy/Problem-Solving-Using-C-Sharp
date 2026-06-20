namespace A._Distance_and_Axis
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1401/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int A_Position = input[0];         /// n
                int requiredDifference = input[1]; /// k

                //Console.Write("************************* ");

                if (requiredDifference > A_Position)
                {
                    Console.WriteLine(Math.Abs(requiredDifference - A_Position));
                }

                else if (A_Position % 2 == requiredDifference % 2)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    Console.WriteLine(1);
                }
            }
        }
    }
}
