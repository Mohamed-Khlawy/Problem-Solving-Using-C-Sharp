namespace A._Game_23
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1141/A
        static void Main(string[] args)
        {

            int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int first_number = n_m[0];
            int second_number = n_m[1];

            int result = -1;

            if (second_number % first_number == 0)
            {
                result = 0;

                int x = second_number / first_number;

                while (x % 2 == 0)
                {
                    x /= 2;
                    result++;
                }

                while (x % 3 == 0)
                {
                    x /= 3;
                    result++;
                }

                if (x != 1)
                {
                    result = -1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
