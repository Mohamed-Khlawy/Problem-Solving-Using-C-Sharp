namespace A._Nastya_and_Rice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1341/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_grains = input[0];
                int a = input[1];
                int b = input[2];
                int c = input[3];
                int d = input[4];

                int a_minus_b = a - b;
                int a_plus_b = a + b;

                int c_minus_d = c - d;
                int c_plus_d = c + d;

                int min_weight_of_all_grains = number_of_grains * a_minus_b;
                int max_weight_of_all_grains = number_of_grains * a_plus_b;

                //Console.Write("******************************************* ");

                if (max_weight_of_all_grains < c_minus_d ||
                    min_weight_of_all_grains > c_plus_d)
                {
                    Console.WriteLine("No");
                }

                else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
