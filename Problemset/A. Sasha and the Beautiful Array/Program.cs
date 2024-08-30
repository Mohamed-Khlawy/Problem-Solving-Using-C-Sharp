namespace A._Sasha_and_the_Beautiful_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1929/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                numbers.Sort();

                long max_beauty = 0;

                for (int i = 1; i < numbers.Count; i++)
                {
                    max_beauty += numbers[i] - numbers[i - 1];
                }

                //Console.Write("******************* ");

                Console.WriteLine(max_beauty);
            }
        }
    }
}
