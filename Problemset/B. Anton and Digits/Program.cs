namespace B._Anton_and_Digits
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/734/B
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int number_of_2s = input[0]; // k2
            int number_of_3s = input[1]; // k3
            int number_of_5s = input[2]; // k5
            int number_of_6s = input[3]; // k6

            int max_number_of_256 = Math.Min(number_of_2s,
                                    Math.Min(number_of_5s, number_of_6s));

            int max_number_of_32 = 0;

            number_of_2s -= max_number_of_256;

            if (number_of_2s > 0)
            {
                max_number_of_32 = Math.Min(number_of_2s, number_of_3s);
            }

            long max_sum = (max_number_of_256 * 256) + (max_number_of_32 * 32);

            //Console.Write("********************************** ");

            Console.WriteLine(max_sum);
        }
    }
}
