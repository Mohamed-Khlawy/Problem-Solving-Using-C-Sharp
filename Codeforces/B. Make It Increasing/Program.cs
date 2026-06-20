namespace B._Make_It_Increasing
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1675/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int divisions_counter = 0;

                bool we_did_it = true;

                for (int i = numbers.Count - 2; i >= 0; i--)
                {
                    while (numbers[i] >= numbers[i + 1] && numbers[i] > 0)
                    {
                        numbers[i] = numbers[i] / 2;

                        divisions_counter++;
                    }

                    if (numbers[i] == numbers[i + 1])
                    {
                        we_did_it = false;
                        break;
                    }
                }

                //Console.Write("********************************** ");

                if (!we_did_it)
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    Console.WriteLine(divisions_counter);
                }
            }
        }
    }
}
