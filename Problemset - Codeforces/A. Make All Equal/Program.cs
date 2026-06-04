namespace A._Make_All_Equal
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2001/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int[] numbers_frequency = new int[size + 1];

                int max_frequency = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers_frequency[numbers[i]]++;

                    if (numbers_frequency[numbers[i]] > max_frequency)
                    {
                        max_frequency = numbers_frequency[numbers[i]];
                    }
                }

                int min_operations = size - max_frequency;

                //Console.Write("*************************************** ");

                Console.WriteLine(min_operations);
            }
        }
    }
}
