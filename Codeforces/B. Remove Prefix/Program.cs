namespace B._Remove_Prefix
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1714/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool[] unique_numbers = new bool[200010];

                int unique_counter = 0;


                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (!unique_numbers[numbers[i]])
                    {
                        unique_numbers[numbers[i]] = true;
                        unique_counter++;
                    }

                    else
                    {
                        break;
                    }
                }

                //Console.Write("******************************** ");

                Console.WriteLine(numbers.Count - unique_counter);
            }
        }
    }
}
