namespace A._Rudolph_and_Cut_the_Rope
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1846/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_nails = int.Parse(Console.ReadLine()!);

                int result = 0;

                for (int i = 0; i < number_of_nails; i++)
                {
                    int[] nail_robe = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                    if (nail_robe[0] > nail_robe[1])
                    {
                        result++;
                    }
                }

                // Console.Write("*** ");

                Console.WriteLine(result);
            }
        }
    }
}
