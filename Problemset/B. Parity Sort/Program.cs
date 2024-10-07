namespace B._Parity_Sort
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1851/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> copy_numbers = new List<int>(numbers);

                copy_numbers.Sort();

                bool can_be_sorted = true;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != copy_numbers[i] % 2)
                    {
                        can_be_sorted = false;
                        break;
                    }
                }

                //Console.Write("************************************** ");

                if (can_be_sorted)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
