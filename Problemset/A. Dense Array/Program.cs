namespace A._Dense_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1490/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int number_of_inserts = 0;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    double diff = Math.Max((double)numbers[i], (double)numbers[i + 1]) /
                        Math.Min((double)numbers[i], (double)numbers[i + 1]);

                    if (diff > 2)
                    {
                        diff = Math.Max((double)numbers[i], (double)numbers[i + 1]) / 2;

                        numbers.Insert(i + 1, (int)Math.Ceiling(diff));
                        number_of_inserts++;

                        i--;

                    }
                }

                //Console.Write("*** ");
                Console.WriteLine(number_of_inserts);
            }
        }
    }
}
