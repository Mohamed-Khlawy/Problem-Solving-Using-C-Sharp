namespace A._Insert_Digit
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1811/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] n_d = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long n = n_d[0];
                long d = n_d[1];

                List<long> numbers = Console.ReadLine()!.Select(c => long.Parse(c.ToString())).ToList();

                //Console.WriteLine("*** ");

                bool d_inserted_successfully = false;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < d)
                    {
                        Console.Write(d);
                        d_inserted_successfully = true;

                        for (int j = i; j < numbers.Count; j++)
                        {
                            Console.Write(numbers[j]);
                        }

                        break;
                    }

                    else
                    {
                        Console.Write(numbers[i]);
                    }
                }

                if (!d_inserted_successfully)
                {
                    Console.Write(d);
                }

                //Console.WriteLine("*** ");

                Console.WriteLine();
            }
        }
    }
}
