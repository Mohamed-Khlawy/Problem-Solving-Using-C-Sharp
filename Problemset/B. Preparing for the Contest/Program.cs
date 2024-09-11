namespace B._Preparing_for_the_Contest
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1914/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int size = n_k[0];
                int excited_times = n_k[1];

                List<int> numbers = Enumerable.Range(1, size).ToList();

                int end_index = size - excited_times;

                List<int> sub_list = numbers.Take(end_index).ToList();

                sub_list.Reverse();

                numbers.RemoveRange(0, end_index);
                numbers.InsertRange(0, sub_list);

                //Console.Write("**************************** ");

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == numbers.Count - 1)
                    {
                        Console.WriteLine(numbers[i]);
                    }

                    else
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}
